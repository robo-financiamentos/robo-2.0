﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robo;
using System.Windows.Forms;

namespace robo.Control.Aditamento
{
    public class AditamentoNovo : UtilFiesNovo
    {
        private IWebDriver Driver;
        public void AditamentoFiesNovo(TOAluno aluno, string IES, string semestreAtual)
        {
            ConsultarAluno(Driver, aluno);
            WaitForLoading(Driver);

            if (VerificarNenhumaInformacaoDisponivel(Driver) == true)
            {
                Util.EditarConclusaoAluno(aluno, "Nenhuma informação disponível");
                return;
            }

            if (Driver.PageSource.Contains("Não iniciado pela CPSA") == true)
            {
                ScrollToElementByID(Driver, "btnAditarEstudante");
                ClickButtonsById(Driver, "btnAditarEstudante");

                EsperarAjax();

                WaitForLoading(Driver);
                VerificarAditamentoNaoDisponivel(aluno);
                if (ConclusaoAlunoAlterada(aluno) == true)
                {
                    return;
                }

                VerificarEstudanteTransferidoNoSemestre();
                VerificarAlertaAlunoTransferido(aluno);

                PreencherReceitaAluno(aluno);
                if (ConclusaoAlunoAlterada(aluno) == true)
                {
                    return;
                }

                WaitForLoading(Driver);
                string alertMessage = VerificarAlertaReceitaAluno(aluno, IES);

                //Prouni
                string possuiProuni = Driver.FindElement(By.Id("prouni")).Text;

                PreencherQuestionamentoAluno(aluno, possuiProuni);
                if (ConclusaoAlunoAlterada(aluno) == true)
                {
                    return;
                }

                BuscarValoresAditamento(aluno);

                ConfirmarAditamento(aluno, alertMessage);
                ScrollToElementByID(Driver, "btnVoltar");
                ClickButtonsById(Driver, "btnVoltar");
            }
            else
            {
                MarcarSituacaoAtualAluno(aluno, semestreAtual);
            }
        }

        private void BuscarValoresAditamento(TOAluno aluno)
        {
            aluno.ValorPagoRecursoEstudante = Driver.FindElement(By.Id("vlrPagoRecursoEstudante")).Text;
            aluno.ValorAditadoFinanciamento = Driver.FindElement(By.Id("vlrPagoRecursoFinanciamento")).Text;
        }
        private void ConfirmarAditamento(TOAluno aluno, string alertMessage)
        {
            if (alertMessage == "")
            {
                ScrollToElementByID(Driver, "btnConfirmar");
                ClickButtonsById(Driver, "btnConfirmar");
                WaitForLoading(Driver);

                alertMessage = BuscarMensagemDeErro(Driver);
            }

            if (alertMessage != "")
            {
                Util.EditarConclusaoAluno(aluno, alertMessage);
            }
            else
            {
                Util.EditarConclusaoAluno(aluno, "Aditado com sucesso");
            }
        }
        private void VerificarAlertaAlunoTransferido(TOAluno aluno)
        {
            string alerta = VerificarAlertaAditamento();
            if (alerta != string.Empty)
            {
                if (alerta.ToUpper().Contains("TRANSFERIDO NO SEMESTRE") == false)
                {
                    Util.EditarConclusaoAluno(aluno, alerta);
                    ScrollToElementByID(Driver, "btnVoltar");
                    ClickButtonsById(Driver, "btnVoltar");
                }
            }
        }
        private void VerificarAditamentoNaoDisponivel(TOAluno aluno)
        {
            string erro = VerificarErroAditamento();
            if (erro != string.Empty)
            {
                Util.EditarConclusaoAluno(aluno, erro);
                ScrollToElementByID(Driver, "btnVoltar");
                ClickButtonsById(Driver, "btnVoltar");
                WaitForLoading(Driver);
                ClicarMenuAditamento(Driver);
            }
        }
        private bool ConclusaoAlunoAlterada(TOAluno aluno)
        {
            if (aluno.Conclusao.ToUpper() != "NÃO FEITO")
            {
                return true;
            }
            return false;
        }
        private void MarcarSituacaoAtualAluno(TOAluno aluno, string semestreAtual)
        {
            string situacaoAluno = string.Empty;
            IWebElement grid = Driver.FindElement(By.Id("gridResult"));
            if (grid.Text.Contains(semestreAtual) == true)
            {
                situacaoAluno = BuscarSituacaoAluno(Driver, semestreAtual);
            }
            else
            {
                situacaoAluno = "Semestre não encontrado.";
            }

            Util.EditarConclusaoAluno(aluno, situacaoAluno);
        }
        private void PreencherQuestionamentoAluno(TOAluno aluno, string possuiProuni)
        {
            ScrollToElementByID(Driver, "aproveitamento75S");
            if (aluno.AproveitamentoAtual.ToUpper().Contains("SUPERIOR A 75%") == true)
            {
                AproveitamentoMaiorDe75(aluno, possuiProuni);
            }
            else if (aluno.AproveitamentoAtual.ToUpper().Contains("INFERIOR A 75%") == true)
            {
                AproveitamentoMenorDe75(aluno, possuiProuni);
            }
            else
            {
                Util.EditarConclusaoAluno(aluno, "Aproveitamento: " + aluno.AproveitamentoAtual);
                ScrollToElementByID(Driver, "btnVoltar");
                ClickButtonsById(Driver, "btnVoltar");
            }
        }
        private string VerificarAlertaReceitaAluno(TOAluno aluno, string IES)
        {
            string alertMessage = string.Empty;
            if (Driver.PageSource.Contains("MDLalerta_"))
            {
                var elementosAlerta = Driver.FindElements(By.XPath("//div[contains(@id,\"MDLalerta_\")]"));
                if (elementosAlerta.Count == 1 && elementosAlerta[0].Displayed == true)
                {
                    if (Driver.PageSource.ToUpper().Contains("INFERIOR AO PERCENTUAL MÍNIMO DE SEMESTRALIDADE ATUAL") == false)
                    {
                        Driver.FindElement(By.ClassName("btn-ok")).Click();
                        EscreverJustificativaAluno(aluno, IES);
                        return string.Empty;
                    }

                    IWebElement alertElement = Driver.FindElement(By.XPath("//div[@class='modal hide fade in']/div[2]"));
                    alertMessage = alertElement.Text;
                    Driver.FindElement(By.ClassName("btn-ok")).Click();

                }
            }

            return alertMessage;
        }
        private void EscreverJustificativaAluno(TOAluno aluno, string IES)
        {
            if (IES.ToUpper() == "UNIRITTER" || IES.ToUpper() == "FADERGS")
            {
                if (aluno.Justificativa == string.Empty)
                {
                    ClickAndWriteById(Driver, "justificativaAcimaLimite", "Valores conforme o número de créditos financeiros matriculados no semestre");
                }
                else
                {
                    ClickAndWriteById(Driver, "justificativaAcimaLimite", aluno.Justificativa);
                }
            }
            else
            {
                ClickAndWriteById(Driver, "justificativaAcimaLimite", "Alteração na grade curricular em relação ao semestre anterior");
            }
        }
        private void PreencherReceitaAluno(TOAluno aluno)
        {
            //Definição semestre atual
            ScrollToElementByID(Driver, "qtSemestreACursar");
            int semestreASerCursado = Convert.ToInt32(Driver.FindElement(By.Id("totalSemestresFinanciados")).Text);
            ((IJavaScriptExecutor)Driver).ExecuteScript($@"document.getElementById(""qtSemestreACursar"").value = ""{semestreASerCursado + 1}"";");

            //Semestralidade Atual 
            ScrollToElementByID(Driver, "semestralidadeAtualComDescGradeASerCursada");
            ClickAndWriteById(Driver, "semestralidadeAtualComDescGradeASerCursada", aluno.ReceitaFies);

            //Click para atualizar a página
            Driver.FindElement(By.Id("semestralidadeAtualComDescGradeASerCursadaLabel")).Click();
            WaitForLoading(Driver);

            if (Driver.PageSource.Contains("inferior ao valor mínimo"))
            {
                string alerta = VerificarAlertaAditamento();
                Util.EditarConclusaoAluno(aluno, alerta);
                ScrollToElementByID(Driver, "btnVoltar");
                ClickButtonsById(Driver, "btnVoltar");
                return;
            }
        }
        private void VerificarEstudanteTransferidoNoSemestre()
        {
            if (Driver.PageSource.ToUpper().Contains("ESTUDANTE TRANSFERIDO NO SEMESTRE") == true)
            {
                Driver.FindElement(By.ClassName("btn-ok")).Click();
            }
        }
        private void EsperarAjax()
        {
            IWebElement ajax = Driver.FindElement(By.Id("ajaxStatus"));
            while (ajax.Displayed == true)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
        private void QuestionamentoPadrao(TOAluno aluno, string possuiProuni)
        {
            Driver.FindElement(By.Id("regularmenteMatriculadoS")).Click();

            if (possuiProuni.ToUpper().Contains("SIM") == true)
            {
                Driver.FindElement(By.Id("beneficioSimultaneoS")).Click();
            }
            else
            {
                Driver.FindElement(By.Id("beneficioSimultaneoN")).Click();
            }
            ScrollToElementByID(Driver, "duracaoCursoS");

            Driver.FindElement(By.Id("duracaoCursoS")).Click();
            Driver.FindElement(By.Id("transferiuCursoN")).Click();

            //Se aparecer: 
            if (Driver.FindElement(By.Id("erroValidarTotSemestresN")).Displayed)
            {
                //Houve erro do estudante e da CPSA ao registrar e validar, respectivamente, o total de semestres j� conclu�dos do curso: N�O 
                ClickButtonsById(Driver, "erroValidarTotSemestresN");
            }
            if (aluno.DescontoLiberalidade.Equals("Sim") == true)
            {
                ScrollToElementByID(Driver, "descontoLiberalidadeS");
                Driver.FindElement(By.Id("descontoLiberalidadeS")).Click();

                ScrollToElementByID(Driver, "motivoDesconto8");
                ClickButtonsById(Driver, "motivoDesconto8");

                //Caixa de texto separada
                var executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript($@"document.getElementById(""justificativaDesconto"").value = ""Desconto Semestral"";");
            }
            else
            {
                Driver.FindElement(By.Id("descontoLiberalidadeN")).Click();
            }
        }
        private void AproveitamentoMaiorDe75(TOAluno aluno, string possuiProuni)
        {
            Driver.FindElement(By.Id("aproveitamento75S")).Click();

            QuestionamentoPadrao(aluno, possuiProuni);
        }
        private void AproveitamentoMenorDe75(TOAluno aluno, string possuiProuni)
        {
            if (aluno.HistoricoAproveitamento.Contains("Excesso de reprovação"))
            {
                MessageBox.Show("Avisar os guris que aconteceu pela 1º vez Excesso de reprovação.");
                //O estudante teve aproveitamento acad�mico igual ou superior a 75% no semestre ? NAO 
                ClickButtonsById(Driver, "aproveitamento75N");
                aluno.Conclusao = "Rejeitou execesso de reprovação";
            }
            else
            {
                //A CPSA irá liberar o aditamento nesta situação? SIM  
                ScrollToElementByID(Driver, "aproveitamento75N");
                ClickButtonsById(Driver, "aproveitamento75N");

                //Justificativa 
                ScrollToElementByID(Driver, "justificativa");
                ClickAndWriteById(Driver, "justificativa", aluno.HistoricoAproveitamento);


                ClickButtonsById(Driver, "aproveitamentoInferior75S");

                QuestionamentoPadrao(aluno, possuiProuni);
            }
        }
        private string VerificarErroAditamento()
        {
            var executor = (IJavaScriptExecutor)Driver;
            string error = string.Empty;
            if (Driver.PageSource.Contains("alert-error"))
            {
                var errorMsg = Driver.FindElement(By.XPath("/html/body/div[1]/div"));
                error = errorMsg.Text;
                error = error.Replace("x\r\n", "");
                ClickButtonsByXpath(Driver, "/html/body/div[1]/div/button");
                var cpf = Driver.FindElement(By.Id("cpf"));
                ((IJavaScriptExecutor)Driver).ExecuteScript(string.Format("window.scrollTo({0}, {1})", cpf.Location.X, cpf.Location.Y - 100));

                if (error.Contains("Contrato possui parcela(s) vencida(s) e não paga(s).") == false)
                {
                    ClicarMenuAditamento(Driver);
                }
            }
            return error;
        }
        private string VerificarAlertaAditamento()
        {
            string alertMessage = "";
            if (Driver.PageSource.Contains("alert alert-warn"))
            {
                IWebElement temp = Driver.FindElement(By.ClassName("alert-warn"));
                alertMessage = temp.Text;
                Driver.FindElement(By.ClassName("close")).Click();
                alertMessage = alertMessage.Replace("x\r\n", "");
            }
            if (Driver.PageSource.Contains("modal-body"))
            {
                IWebElement temp = Driver.FindElement(By.ClassName("modal-body"));
                alertMessage = temp.Text;
                Driver.FindElement(By.ClassName("close")).Click();
                alertMessage = alertMessage.Replace("x\r\n", "");
            }

            return alertMessage;

        }
        public void SetDriver(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}