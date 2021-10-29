﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using robo.Control.Update;
using CsvHelper;
using System.Globalization;
using robo.View;

namespace Robo
{
    /// <summary>
    /// Métodos comuns que podem ser utilizados no código como um todo
    /// </summary>
    class Util
    {
        /// <summary>
        /// Inicia nova sessão do browser.
        /// <param name="url">URL que será aberta</param>
        /// <param name="downloadFldr">TRUE se for necessário utilizar a pasta RelatorioExportacao</param>
        /// <param name="firefox">false para utilizar o Google Chrome</param>
        /// <param name="headless">Rodar sem abrir navegador (versão CAE)</param>
        /// </summary>
        public static IWebDriver StartBrowser(string url, bool downloadFldr = false, bool firefox = true, bool headless = false)
        {
            IWebDriver driver;

            string downloadFolder = "";
            if (downloadFldr == true)
            {
                CreateDirectoryIfNotExists("RelatorioExportacao\\");
                downloadFolder = Directory.GetCurrentDirectory() + "\\RelatorioExportacao\\";
            }
            else
            {
                downloadFolder = GetDownloadsFolderPath();
            }

            if (firefox == true)
            {

                //Firefox
                var firefoxDriverService = FirefoxDriverService.CreateDefaultService(Environment.CurrentDirectory + @"\driver");
                firefoxDriverService.HideCommandPromptWindow = true;

                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.AcceptInsecureCertificates = true;
                if (FormInterface2.versaoRobo != "operacoesFinanceiras" || headless == true)
                {
                    firefoxOptions.AddArgument("--headless");
                }
                var firefoxProfile = new FirefoxProfile();

                //profile.SetPreference("browser.download.downloadDir", downloadFolder);
                //profile.SetPreference("browser.download.defaultFolder", downloadFolder);
                //profile.SetPreference("browser.helperApps.neverAsk.openFile", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                //profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf;text/plain;application/text;text/xml;application/xml");
                firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/plain,application/octet-stream,application/pdf,application/x-pdf,application/vnd.pdf,application/zip,text/csv,application/csv,application/vnd.ms-excel,text/comma-separat‌​ed-values,application/excel,text/x-server-parsed-html,application/vnd.ms-excel,application/msexcel");
                firefoxProfile.SetPreference("browser.download.folderList", 2);
                firefoxProfile.SetPreference("browser.download.dir", downloadFolder);
                firefoxProfile.SetPreference("browser.helperApps.alwaysAsk.force", false);
                firefoxProfile.SetPreference("browser.download.manager.useWindow", false);
                firefoxProfile.SetPreference("browser.download.manager.focusWhenStarting", false);
                firefoxProfile.SetPreference("browser.download.manager.showAlertOnComplete", false);
                firefoxProfile.SetPreference("browser.download.manager.closeWhenDone", true);
                firefoxProfile.SetPreference("security.tls.version.min", 1);
                firefoxProfile.SetPreference("security.tls.version.max", 4);
                firefoxProfile.SetPreference("dom.enable_window_print", false);
                //firefoxProfile.SetPreference("print.tab_modal.enabled", true);
                firefoxOptions.Profile = firefoxProfile;
                driver = new FirefoxDriver(firefoxDriverService, firefoxOptions);
            }
            else
            {
                //Chrome
                var chromeDriverService = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory + @"\driver");
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOptions = new ChromeOptions();
                if (RoboForm.versaoRobo != "operacoesFinanceiras")
                {
                    chromeOptions.AddArgument("--headless");
                }
                chromeOptions.AddUserProfilePreference("download.default_directory", downloadFolder);
                try
                {

                    driver = new ChromeDriver(chromeDriverService, chromeOptions);
                }
                catch
                {
                    MessageBox.Show("Versão do Google Chrome desatualizada. Clique em 'Ok' para atualizar e continuar o processo.");
                    chromeDriverService.Dispose();

                    UpdateChromedriver.DownloadChromedriver();
                    chromeDriverService = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory + @"\driver");
                    chromeDriverService.HideCommandPromptWindow = true;
                    driver = new ChromeDriver(chromeDriverService, chromeOptions);
                    //throw new Exception("Versão do chromedriver foi atualizada, favor tentar novamente!");
                }
            }
            driver.Manage().Window.Maximize();
            driver.Url = url;
            //driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 3, 0);
            if (headless == true)
            {
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            return driver;
        }

        /// <summary>
        /// Substitui \r por espacos vazios de todos os campos de strings
        /// </summary>
        /// <param name="infs">Aluno que será atualizado</param>
        public static void AcertaBarraR(TOAluno infs)
        {
            foreach (var propriedade in infs.GetType().GetProperties())
            {
                if (propriedade.Name != "Id")
                {
                    if (propriedade.GetValue(infs) != null)
                    {
                        infs.GetType().GetProperty(propriedade.Name).SetValue(infs, infs.GetType().GetProperty(propriedade.Name).GetValue(infs).ToString().Replace("\r", ""));
                        infs.GetType().GetProperty(propriedade.Name).SetValue(infs, infs.GetType().GetProperty(propriedade.Name).GetValue(infs).ToString().Replace("\n", ""));
                    }
                }
            }
        }

        /// <summary>
        /// Cria um diretorio caso não exista
        /// </summary>
        /// <param name="directories">Conjunto de diretórios que devem ser criados</param>
        public static void CreateDirectoryIfNotExists(params string[] directories)
        {
            foreach (String directory in directories)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
        }

        /// <summary>
        /// Busca o diretório de download do usuário
        /// </summary>
        /// <returns>Caminho da pasta de download do usuário</returns>
        public static string GetDownloadsFolderPath()
        {
            string userRoot = Environment.GetEnvironmentVariable("USERPROFILE");
            string downloadFolder = Path.Combine(userRoot, "Downloads");
            return downloadFolder;
        }

        /// <summary>
        /// Verifica qual o semestre atual
        /// </summary>
        /// <returns>1 ou 2</returns>
        public static string VerificaSemestreAtual()
        {
            DateTime aDate = DateTime.Now;
            string sem = string.Empty;
            if (aDate.Month > 6)
            {
                sem += "2";
            }
            else
            {
                sem += "1";
            }
            sem += "/" + aDate.Year.ToString();

            return sem;
        }

        /// <summary>
        /// Busca o mes atual
        /// </summary>
        /// <returns></returns>
        public static int BuscarMesAtual()
        {
            DateTime aDate = DateTime.Now;
            return aDate.Month;
        }

        /// <summary>
        /// Retorna o MD5 de uma string
        /// </summary>
        /// <param name="password">String que será convertida</param>
        /// <returns></returns>
        public static string GetMD5(string password)
        {
            MD5 md5password = MD5.Create();
            //Conversão a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5password.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Criação de um stringBuilder para concatenar os dados
            StringBuilder sBuilder = new StringBuilder();

            //Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        /// <summary>
        /// Exporta todos os alunos do banco de dados para um CSV
        /// </summary>
        /// <param name="countDataGrid">Quantidade de alunos</param>
        /// <param name="tipo">Alunos ou Informações</param>
        public static void ExportarCSV(int countDataGrid, string tipo)
        {
            if (countDataGrid > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Exportado_Robo.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Arquivo já existe, e está aberto em outro aplicativo" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            ExportarAlunosParaCSV(sfd.FileName, tipo);
                            MessageBox.Show("Dados Exportados com Sucesso!!!", "Info");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Sem Registro para Exportar!!!", "Info");
            }

        }

        /// <summary>
        /// Exporta todos os alunos do banco de dados para um arquivo CSV
        /// </summary>
        /// <param name="fileName">Nome do arquivo</param>
        /// <param name="tipo">Alunos ou Informações</param>
        public static void ExportarAlunosParaCSV(string fileName, string tipo)
        {
            if (fileName.Contains(".csv") == false)
            {
                fileName += ".csv";
            }
            List<TOAluno> alunoParaExportar = Dados.SelectAll<TOAluno>();
            using (StreamWriter exportaInf = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                using (CsvWriter csv = new CsvWriter(exportaInf, CultureInfo.CurrentCulture))
                {
                    var mapa = new TOAlunoMap(tipo);
                    csv.Context.RegisterClassMap(mapa);
                    csv.WriteRecords(alunoParaExportar);
                }
            }
        }

        /// <summary>
        /// Muda a conclusão de um aluno no banco
        /// </summary>
        /// <param name="aluno"></param>
        /// <param name="conclusao"></param>
        /// <param name="tipoAluno"></param>
        public static void EditarConclusaoAluno(TOAluno aluno, string conclusao, string tipoAluno = "ALUNO")
        {
            aluno.Conclusao = conclusao;
            aluno.HorarioConclusao = string.Format("{0:dd/MM/yyyy HH:mm}", DateTime.Now);

            Dados.UpdateDocumento<TOAluno>(aluno);
        }

        /// <summary>
        /// Apaga todos os arquivos de um diretório
        /// </summary>
        /// <param name="path">Caminho do diretório</param>
        public static void ApagaArquivos(string path)
        {
            string[] arquivos = Directory.GetFiles(path);
            for (int i = 0; i < arquivos.Length; i++)
            {
                File.Delete(arquivos[i]);
            }
        }

        /// <summary>
        /// Verifica se o CPF é válido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool VerificaCPFValido(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

    }
}