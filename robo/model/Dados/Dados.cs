using System;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;
using robo.pgm;
using robo;
using robo.Model.TO;
//using ExcelManager;

namespace Robo
{
    public static class Dados
    {
        private static readonly Dictionary<string, string> insertTOAluno = new Dictionary<string, string>()
        {
            {"Cpf", "Cpf" },
            {"Nome", "Nome"},
            {"Campus", "Campus"},
            {"AproveitamentoAtual", "AproveitamentoAtual"},
            {"HistoricoAproveitamento", "HistoricoAproveitamento"},
            {"ReceitaLiquida", "ReceitaLiquida"},
            {"ReceitaBruta", "ReceitaBruta"},
            {"ReceitaFies", "ReceitaFies"},
            {"Tipo", "Tipo"},
            {"Conclusao", "Conclusao"},
            {"CampusAditado", "CampusAditado"},
            {"ValorAditado", "ValorAditado"},
            {"NumCampusAtual", "NumCampusAtual"},
            {"ValorAditadoFinanciamento", "ValorAditadoFinanciamento"},
            {"ValorPagoRecursoEstudante", "ValorPagoRecursoEstudante"},
            {"HorarioConclusao", "HorarioConclusao"},
            {"DescontoLiberalidade", "DescontoLiberalidade"},
            {"Extraido", "Extraido"},
            {"Justificativa", "Justificativa"}
        };

        private static readonly Dictionary<string, string> insertTOAlunoInf = new Dictionary<string, string>()
        {
            {"Cpf", "Cpf"},
            {"Nome", "Nome"},
            {"Campus", "Campus"},
            {"Conclusao", "Conclusao"}
        };

        private static readonly Dictionary<string, string> insertAlunoConsultaNovoTO = new Dictionary<string, string>()
        {
            {"Cpf", "Cpf"},
            {"SemestreAno", "SemestreAno"},
            {"Finalidade", "Finalidade"},
            {"Situacao", "Situacao"},
            {"Tipo", "Tipo"},
            {"ProUni", "ProUni"},
            {"DataInclusao", "DataInclusao"},
            {"DataConclusao", "DataConclusao"},
            {"HorarioConclusao", "HorarioConclusao"}
        };

        private static readonly Dictionary<string, string> updateAlunoInf = new Dictionary<string, string>()
        {
            {"Cpf", "Cpf" },
            {"Curso", "Curso" },
            {"HorarioConclusao", "HorarioConclusao" },
            {"SemestreAditar", "SemestreAditar" },
            {"DuracaoRegular", "DuracaoRegular" },
            {"TotalDeSemestresSuspensos", "TotalDeSemestresSuspensos"},
            {"TotalDeSemestresDilatados", "TotalDeSemestresDilatados"},
            {"TotalDeSemestresConcluidos", "TotalDeSemestresConcluidos"},
            {"SemestreSerCursadoPeloEstudante", "SemestreSerCursadoPeloEstudante" },
            {"TotalDeSemestresJaFinanciados", "TotalDeSemestresJaFinanciados"},
            {"PercentualDeFinanciamentoSolicitado", "PercentualDeFinanciamentoSolicitado" },
            {"GradeAtualComDesconto", "GradeAtualComDesconto" },
            {"GradeAtualFinanciadoFIES", "GradeAtualFinanciadoFIES" },
            {"GradeAtualCoparticipacao", "GradeAtualCoparticipacao" },
            {"Conclusao", "Conclusao" }
        };
        //SELECTS
        public static List<Aluno> SelectAlunos(Type tipoAluno)
        {
            List<Aluno> alunos = new List<Aluno>();
            if (tipoAluno == typeof(TOAluno))
            {
                List<TOAluno> alunosTO = new List<TOAluno>();
                alunosTO = Database.Acess.SelectAll<TOAluno>("ALUNO");
                alunos = alunosTO.ConvertAll(x => (Aluno)x);
            }
            if (tipoAluno == typeof(AlunoConsultaNovoTO))
            {
                List<AlunoConsultaNovoTO> alunoConsultaNovo = new List<AlunoConsultaNovoTO>();
                alunoConsultaNovo = Database.Acess.SelectAll<AlunoConsultaNovoTO>("ALUNOCONSULTANOVO");
                alunos = alunoConsultaNovo.ConvertAll(x => (Aluno)x);
            }
            if (tipoAluno == typeof(TOAlunoInf))
            {
                List<TOAlunoInf> alunoInf = new List<TOAlunoInf>();
                alunoInf = Database.Acess.SelectAll<TOAlunoInf>("ALUNOINF");
                alunos = alunoInf.ConvertAll(x => (Aluno)x);
            }
            return alunos;
        }
        public static List<TOSemestre> SelectSemestre()
        {
            return Database.Acess.SelectAll<TOSemestre>("SEMESTRES");
        }
        public static List<TOLogin> SelectLogins()
        {
            return Database.Acess.SelectAll<TOLogin>("LOGIN", "Numero", true);
            //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{
            //    var output = cnn.Query<TOLogin>("select * from LOGIN ORDER BY Numero ASC", new DynamicParameters());
            //    return output.ToList();
            //}
        }
        public static List<TOUsuario> SelectUsuarios()
        {
            return Database.Acess.SelectAll<TOUsuario>("USUARIO");
        }
        public static List<TOAluno> SelectAlunos()
        {
            return Database.Acess.SelectAll<TOAluno>("ALUNO");
            //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{
            //    var output = cnn.Query<TOAluno>("select * from ALUNO", new DynamicParameters());
            //    return output.ToList();
            //}
        }
        public static List<TOAlunoInf> SelectAlunosInf()
        {
            return Database.Acess.SelectAll<TOAlunoInf>("ALUNOINF");
        }
        public static List<TOLoginAdmin> SelectLoginAdmin()
        {
            return Database.Acess.SelectAll<TOLoginAdmin>("LOGINADMIN");
        }
        public static List<AlunoConsultaNovoTO> SelectAlunoConsultaNovoTO()
        {
            return Database.Acess.SelectAll<AlunoConsultaNovoTO>("ALUNOCONSULTANOVO");
        }

        //DELETES
        public static void DeleteLogin(TOLogin login)
        {
            List<TOLogin> loginList = new List<TOLogin>();
            loginList.Add(login);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("User", "User");
            Database.Acess.Delete<TOLogin>("LOGIN", loginList, dic);
        }
        public static void DeleteUsuario(TOUsuario usuario)
        {
            List<TOUsuario> usuarioList = new List<TOUsuario>();
            usuarioList.Add(usuario);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Usuario", "Usuario");
            Database.Acess.Delete<TOUsuario>("USUARIO", usuarioList, dic);
        }
        public static void DeleteTodosAlunosConsultaNovo()
        {
            Database.Acess.DeleteAll("ALUNOCONSULTANOVO");
        }
        public static void DeleteTodosAlunos()
        {
            Database.Acess.DeleteAll("ALUNO");
        }
        public static void DeleteTodosAlunosInf()
        {
            Database.Acess.DeleteAll("ALUNOINF");
        }
        public static void DeleteTodosAlunos(Type tipoAluno)
        {
            if (tipoAluno == typeof(TOAluno))
            {
                Database.Acess.DeleteAll("ALUNO");
            }
            if (tipoAluno == typeof(TOAlunoInf))
            {
                Database.Acess.DeleteAll("ALUNOINF");
            }
            if (tipoAluno == typeof(AlunoConsultaNovoTO))
            {
                Database.Acess.DeleteAll("ALUNOCONSULTANOVO");
            }
        }

        //UPDATES
        public static void UpdateAluno(TOAluno aluno)
        {
            Dictionary<string, string> columnAndProperty = new Dictionary<string, string>();
            columnAndProperty.Add("Cpf", "Cpf");
            columnAndProperty.Add("Nome", "Nome");
            //columnAndProperty.Add("Curso", "Curso");
            columnAndProperty.Add("Campus", "Campus");
            columnAndProperty.Add("AproveitamentoAtual", "AproveitamentoAtual");
            columnAndProperty.Add("HistoricoAproveitamento", "HistoricoAproveitamento");
            columnAndProperty.Add("ReceitaLiquida", "ReceitaLiquida");
            columnAndProperty.Add("ReceitaBruta", "ReceitaBruta");
            columnAndProperty.Add("ReceitaFies", "ReceitaFies");
            columnAndProperty.Add("Tipo", "Tipo");
            columnAndProperty.Add("Conclusao", "Conclusao");
            columnAndProperty.Add("CampusAditado", "CampusAditado");
            columnAndProperty.Add("ValorAditado", "ValorAditado");
            columnAndProperty.Add("NumCampusAtual", "NumCampusAtual");
            columnAndProperty.Add("ValorAditadoFinanciamento", "ValorAditadoFinanciamento");
            columnAndProperty.Add("ValorPagoRecursoEstudante", "ValorPagoRecursoEstudante");
            columnAndProperty.Add("HorarioConclusao", "HorarioConclusao");
            columnAndProperty.Add("Extraido", "Extraido");
            Database.Acess.Update<TOAluno>("ALUNO", columnAndProperty, aluno, "Cpf", "Cpf");

            //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{
            //    cnn.Execute("update ALUNO set Cpf = @Cpf, Nome = @Nome, Curso = @Curso, AproveitamentoAtual = @AproveitamentoAtual, HistoricoAproveitamento = @HistoricoAproveitamento, ReceitaLiquida = @ReceitaLiquida, ReceitaBruta = @ReceitaBruta, Tipo = @Tipo, Conclusao = @Conclusao, CampusAditado = @CampusAditado, ValorAditado = @ValorAditado, NumCampusAtual = @NumCampusAtual, HorarioConclusao = @HorarioConclusao where Cpf = @Cpf", aluno);
            //}
        }
        public static void UpdateAluno(TOAlunoInf aluno)
        {

            Dictionary<string, string> columnAndProperty = new Dictionary<string, string>();
            columnAndProperty.Add("Cpf", "Cpf");
            columnAndProperty.Add("Curso", "Curso");
            columnAndProperty.Add("HorarioConclusao", "HorarioConclusao");
            columnAndProperty.Add("SemestreAditar", "SemestreAditar");
            columnAndProperty.Add("DuracaoRegular", "DuracaoRegular");
            columnAndProperty.Add("TotalDeSemestresSuspensos", "TotalDeSemestresSuspensos");
            columnAndProperty.Add("TotalDeSemestresDilatados", "TotalDeSemestresDilatados");
            columnAndProperty.Add("TotalDeSemestresConcluidos", "TotalDeSemestresConcluidos");
            columnAndProperty.Add("SemestreSerCursadoPeloEstudante", "SemestreSerCursadoPeloEstudante");
            columnAndProperty.Add("TotalDeSemestresJaFinanciados", "TotalDeSemestresJaFinanciados");
            columnAndProperty.Add("PercentualDeFinanciamentoSolicitado", "PercentualDeFinanciamentoSolicitado");
            columnAndProperty.Add("GradeAtualComDesconto", "GradeAtualComDesconto");
            columnAndProperty.Add("GradeAtualFinanciadoFIES", "GradeAtualFinanciadoFIES");
            columnAndProperty.Add("GradeAtualCoparticipacao", "GradeAtualCoparticipacao");
            columnAndProperty.Add("Conclusao", "Conclusao");
            Database.Acess.Update<TOAlunoInf>("ALUNOINF", columnAndProperty, aluno, "Cpf", "Cpf");

            //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{
            //    cnn.Execute("update ALUNO set Cpf = @Cpf, Nome = @Nome, Curso = @Curso, AproveitamentoAtual = @AproveitamentoAtual, HistoricoAproveitamento = @HistoricoAproveitamento, ReceitaLiquida = @ReceitaLiquida, ReceitaBruta = @ReceitaBruta, Tipo = @Tipo, Conclusao = @Conclusao, CampusAditado = @CampusAditado, ValorAditado = @ValorAditado, NumCampusAtual = @NumCampusAtual, HorarioConclusao = @HorarioConclusao where Cpf = @Cpf", aluno);
            //}
        }
        public static void UpdateLogin(TOLogin login)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("User", "User");
            dic.Add("Password", "Password");
            dic.Add("Campus", "Campus");
            dic.Add("Plataforma", "Plataforma");
            dic.Add("Faculdade", "Faculdade");
            Database.Acess.Update("LOGIN", dic, login, "Numero", "Numero");
        }
        public static void UpdateUsuario(TOUsuario usuario)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Usuario", "Usuario");
            dic.Add("Senha", "Senha");
            dic.Add("Permissao", "Permissao");
            dic.Add("IES", "IES");
            Database.Acess.Update("USUARIO", dic, usuario, "Usuario", "Usuario");
        }
        public static void UpdateAluno(Aluno aluno)
        {
            if (aluno is TOAluno)
            {
                Database.Acess.Update<TOAluno>("ALUNO", insertTOAluno, (TOAluno)aluno, "Cpf", "Cpf");
            }
            if (aluno is TOAlunoInf)
            {
                Database.Acess.Update<TOAlunoInf>("ALUNOINF", updateAlunoInf, (TOAlunoInf)aluno, "Cpf", "Cpf");
            }
        }

        //INSERTS
        public static void InsertAluno(Aluno aluno)
        {
            if (aluno is TOAluno)
            {
                List<TOAluno> alunos = new List<TOAluno>();
                alunos.Add(aluno as TOAluno);

                Database.Acess.InsertClassInBd("ALUNO", insertTOAluno, alunos);
            }
            if (aluno is TOAlunoInf)
            {
                List<TOAlunoInf> alunos = new List<TOAlunoInf>();
                alunos.Add(aluno as TOAlunoInf);

                Database.Acess.InsertClassInBd("ALUNOINF", insertTOAlunoInf, alunos);
            }
            if (aluno is AlunoConsultaNovoTO)
            {
                List<AlunoConsultaNovoTO> alunos = new List<AlunoConsultaNovoTO>();
                alunos.Add(aluno as AlunoConsultaNovoTO);
                Database.Acess.InsertClassInBd("ALUNOCONSULTANOVO", insertAlunoConsultaNovoTO, alunos);
            }
        }
        public static void InsertLogin(TOLogin login)
        {
            List<TOLogin> listLogin = new List<TOLogin>();
            listLogin.Add(login);

            Database.Acess.InsertClassInBd<TOLogin>("LOGIN", listLogin);
        }
        public static void InsertUsuario(TOUsuario usuario)
        {
            List<TOUsuario> listUsuario = new List<TOUsuario>();
            listUsuario.Add(usuario);
            Database.Acess.InsertClassInBd<TOUsuario>("USUARIO", listUsuario);
        }
        public static void InsertDRI(TODRI dri)
        {
            List<TODRI> listTODRI = new List<TODRI>();
            listTODRI.Add(dri);

            Database.Acess.InsertClassInBd<TODRI>("DRI", listTODRI);
        }
        public static void insertsemestre(TOSemestre semestre)
        {
            Dictionary<string, string> dicSemestre = new Dictionary<string, string>();
            dicSemestre.Add("Semestre", "Semestre");
            List<TOSemestre> listTOSemestre = new List<TOSemestre>();
            listTOSemestre.Add(semestre);
            Database.Acess.InsertClassInBd("SEMESTRES", dicSemestre, listTOSemestre);
        }

        //COUNTS
        public static int CountLogin(TOLogin login)
        {
            return Database.Acess.SelectWhere<TOLogin>("LOGIN", "User", login.User).Count;
        }
        public static int CountAluno(TOAluno aluno)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Cpf", "Cpf");
            return Database.Acess.SelectWhere<TOAluno>("ALUNO", dic).Count;

        }
        public static int CountAluno(TOAlunoInf aluno)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Cpf", "Cpf");
            return Database.Acess.SelectWhere<TOAlunoInf>("ALUNOINF", dic).Count;
        }
        public static int CountAluno(Type tipoAluno)
        {
            if (tipoAluno == typeof(TOAluno))
            {
                return Database.Acess.SelectCount("ALUNO");
            }
            if (tipoAluno == typeof(TOAlunoInf))
            {
                return Database.Acess.SelectCount("ALUNOINF");
            }
            return 0;
        }


        //CSV
        /// <summary>
        /// Busca todos alunos na planilha Excel.
        /// </summary>
        /// <param name="directory">Diret�rio da planilha excel.</param>
        /// <returns>Lista de alunos.</returns>
        public static List<TOAluno> BuscarListaAlunos(String directory)
        {
            try
            {
                TOAluno aluno = new TOAluno();
                List<String> headers = new List<String>();
                Dictionary<String, String> propriedades = new Dictionary<String, String>();

                propriedades.Add("CPF", "Cpf");
                propriedades.Add("NOME", "Nome");
                propriedades.Add("CAMPUS ADITADO", "Campus");
                propriedades.Add("APROVEITAMENTO ATUAL", "AproveitamentoAtual");
                propriedades.Add("HIST�RICO DE APROVEITAMENTO", "HistoricoAproveitamento");
                propriedades.Add("RECEITA BRUTA", "ReceitaBruta");
                propriedades.Add("RECEITA LIQUIDA", "ReceitaLiquida");
                propriedades.Add("RECEITA FIES", "ReceitaFies");
                propriedades.Add("MODALIDADE FIES", "Tipo");
                propriedades.Add("TIPO", "Tipo");
                propriedades.Add("Desconto Liberalidade", "DescontoLiberalidade");
                propriedades.Add("Justificativa", "Justificativa");

                List<TOAluno> alunos = CSVManager.CSVManager.ImportCSV<TOAluno>(directory, propriedades);

                for (int i = alunos.Count() - 1; i >= 0; i--)
                {
                    if (alunos[i].Cpf == string.Empty)
                    {
                        alunos.RemoveAt(i);
                    }
                    else
                    {
                        TratarCpf(alunos[i]);
                    }
                }

                //return TratarCpf(alunos);
                return alunos;
            }
            catch (Exception e)
            {
                //throw new Exception("Erro na busca de dados no excel.");
                throw new Exception(e.Message);
            }
        }
        public static List<TOAlunoInf> ImportAlunos(string diretory)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("CPF", "Cpf");
            dictionary.Add("NOME", "Nome");
            dictionary.Add("CAMPUS", "Campus");
            dictionary.Add("MODALIDADE FIES", "Tipo");

            List<TOAlunoInf> alunos = CSVManager.CSVManager.ImportCSV<TOAlunoInf>(diretory, dictionary);
            for (int i = alunos.Count() - 1; i >= 0; i--)
            {
                if (alunos[i].Cpf == string.Empty)
                {
                    alunos.RemoveAt(i);
                }
            }
            return alunos;
        }
        public static void Exportar_CSV(string fileName)
        {
            if (fileName.Contains(".csv") == false)
            {
                fileName += ".csv";
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("CPF", "Cpf");
            dic.Add("Semestre a Aditar", "SemestreAditar");
            dic.Add("Curso", "Curso");
            dic.Add("Dura��o regular", "DuracaoRegular");
            dic.Add("Total de semestres suspensos", "TotalDeSemestresSuspensos");
            dic.Add("Total de semestres dilatados", "TotalDeSemestresDilatados");
            dic.Add("Total de semestres j� concluidos e/ou aproveitadosnesta IES/curso", "TotalDeSemestresConcluidos");
            dic.Add("Semestre a ser cursado pelo estudante", "SemestreSerCursadoPeloEstudante");
            dic.Add("Total de semestres j� financiados", "TotalDeSemestresJaFinanciados");
            dic.Add("Percentual de financiamento solicitado", "PercentualDeFinanciamentoSolicitado");
            dic.Add("Grade Atual Semestralidade (R$) com desconto", "GradeAtualComDesconto");
            dic.Add("Grade Atual Semestralidade (R$) Financiado FIES", "GradeAtualFinanciadoFIES");
            dic.Add("Grade Atual Semestralidade (R$) Coparticipa��o", "GradeAtualCoparticipacao");

            List<TOAlunoInf> alunoParaExportar = Database.Acess.SelectAll<TOAlunoInf>("ALUNOINF");

            string[] arquivoSalvar = fileName.Split('\\');
            string[] diretorio = fileName.Split('\\');
            string nomeTemp = diretorio[diretorio.Length - 1];
            fileName = fileName.Replace(nomeTemp, string.Empty);
            CSVManager.CSVManager.ExportCSV<TOAlunoInf>(fileName, nomeTemp, dic, alunoParaExportar);
        }

        //Tratamentos de valores
        public static void TratarCpf(Aluno aluno)
        {
            aluno.Cpf = aluno.Cpf.Replace(".", "");
            aluno.Cpf = aluno.Cpf.Replace("-", "");

            while (aluno.Cpf.Length != 11)
            {
                aluno.Cpf = "0" + aluno.Cpf;
            }

        }
        /// <summary>
        /// Arredonda para duas casas decimais e remove caracteres desnecess�rios
        /// </summary>
        /// <param name="aluno"></param>
        /// <param name="chamadaInicial">se foi chamado no util (true) ou pelo tratamento de erro no formulario (false)</param>
        public static void TratarPorcentagemReceita(TOAluno aluno, bool chamadaInicial = true, float valorNovo = 0)
        {
            if ("Antigo".Equals(aluno.Tipo))
            {
                if (chamadaInicial == false)
                {
                    //Trata o erro dos 95% - N�O EST� EM USO
                    Double receitaLiquida = Double.Parse(aluno.ReceitaLiquida);
                    Double porcentagemLiquida = Math.Truncate((receitaLiquida * 0.95f) * 100) / 100;
                    aluno.ValorAditado = FormatarReceitas(porcentagemLiquida.ToString());
                }
            }

            aluno.ReceitaBruta = FormatarReceitas(aluno.ReceitaBruta);
            aluno.ReceitaLiquida = FormatarReceitas(aluno.ReceitaLiquida);
            aluno.ReceitaFies = FormatarReceitas(aluno.ReceitaFies);
            aluno.ValorAditado = FormatarReceitas(aluno.ValorAditado);
        }
        public static void TratarCampusAluno(TOAluno aluno)
        {
            switch (aluno.Campus)
            {
                case "ZS":
                    aluno.Campus = "ZONA SUL";
                    break;
                case "Fapa_Fapa":
                    aluno.Campus = "FAPA-FAPA";
                    break;
                case "GL":
                    aluno.Campus = "GALERIA LUSA";
                    break;
                case "GV":
                    aluno.Campus = "GENERAL VITORINO";
                    break;
                case "Andradas":
                    aluno.Campus = "URUGUAI";
                    break;
                case "LF":
                    aluno.Campus = "LUIS AFONSO";
                    break;
                case "LA":
                    aluno.Campus = "LUIS AFONSO";
                    break;
                case "Fadergs_Fapa":
                    aluno.Campus = "MANOEL ELIAS";
                    break;
                case "Mossor�":
                    aluno.Campus = "MOSSOR�";
                    break;
                case "Jo�o Medeiros ":
                    aluno.Campus = "JO�O MEDEIROS";
                    break;
                case "Nascimento de Castro ":
                    aluno.Campus = "NASCIMENTO DE CASTRO";
                    break;
                case "Salgado Filho ":
                    aluno.Campus = "SALGADO FILHO";
                    break;
                case "Salgado Fillho":
                    aluno.Campus = "SALGADO FILHO";
                    break;
                case "Faculdade Internacional ":
                    aluno.Campus = "Faculdade Internacional";
                    break;
                default:
                    aluno.Campus = aluno.Campus.Trim();
                    aluno.Campus = aluno.Campus.ToUpper();
                    break;
            }
        }
        public static void TratarCampusAluno(List<TOAlunoInf> alunos)
        {
            foreach (var aluno in alunos)
            {
                switch (aluno.Campus)
                {
                    case "ZS":
                        aluno.Campus = "ZONA SUL";
                        break;
                    case "Fapa_Fapa":
                        aluno.Campus = "FAPA-FAPA";
                        break;
                    case "GL":
                        aluno.Campus = "GALERIA LUSA";
                        break;
                    case "GV":
                        aluno.Campus = "GENERAL VITORINO";
                        break;
                    case "Andradas":
                        aluno.Campus = "URUGUAI";
                        break;
                    case "LF":
                        aluno.Campus = "LUIS AFONSO";
                        break;
                    default:
                        aluno.Campus = aluno.Campus.ToUpper();
                        break;
                }
            }
        }
        public static void TratarTipoFIES(TOAluno aluno)
        {
            if (aluno.Tipo.ToUpper().Contains("NOVO") == true)
            {
                aluno.Tipo = "FIES Novo";
            }
            else
            {
                aluno.Tipo = "FIES Legado";
            }
        }
        static string FormatarReceitas(string valor)
        {
            if (valor.Contains(","))
            {
                string[] split = valor.Split(new Char[] { ',' });
                if (split[1].Length == 1)
                {
                    valor += "0";
                }
            }
            else
            {
                valor += ",00";
            }
            return valor;
        }
        public static void TratarTextoReceitas(TOAluno aluno)
        {
            aluno.ReceitaBruta = aluno.ReceitaBruta.Replace("R$", "");
            aluno.ReceitaBruta = aluno.ReceitaBruta.Replace(" ", "");
            aluno.ReceitaLiquida = aluno.ReceitaLiquida.Replace("R$", "");
            aluno.ReceitaLiquida = aluno.ReceitaLiquida.Replace(" ", "");
            aluno.ReceitaFies = aluno.ReceitaFies.Replace("R$", "");
            aluno.ReceitaFies = aluno.ReceitaFies.Replace(" ", "");

            if (aluno.ReceitaBruta != string.Empty)
            {
                aluno.ReceitaBruta = Math.Round(Convert.ToDouble(aluno.ReceitaLiquida), 2).ToString();
            }
            if (aluno.ReceitaLiquida != string.Empty)
            {
                aluno.ReceitaLiquida = Math.Round(Convert.ToDouble(aluno.ReceitaLiquida), 2).ToString();
            }
            if (aluno.ReceitaFies != string.Empty)
            {
                aluno.ReceitaFies = Math.Round(Convert.ToDouble(aluno.ReceitaFies), 2).ToString();
            }
        }

        //Atualizar BD
        public static void AtualizarAlunosBD(List<TOAluno> alunos)
        {
            foreach (TOAluno aluno in alunos)
            {
                //if (CountAluno(aluno) > 0)
                //{
                //    UpdateAluno(aluno);
                //}
                //else
                //{
                //}
                InsertAluno(aluno);
            }
        }
        public static void AtualizarAlunosBD(List<TOAlunoInf> alunos)
        {

            //TratarCpf(alunos);
            foreach (TOAlunoInf aluno in alunos)
            {
                TratarCpf(aluno);
                if (CountAluno(aluno) > 0)
                {
                    UpdateAluno(aluno);
                }
                else
                {
                    InsertAluno(aluno);
                }
            }
        }
        public static void AtualizarAlunosBD(List<Aluno> alunos, Type tipoAluno)
        {
            if (tipoAluno == typeof(TOAluno))
            {
                foreach (TOAluno aluno in alunos)
                {
                    TratarCpf(aluno);
                    InsertAluno((TOAluno)aluno);
                }
            }
            if (tipoAluno == typeof(TOAlunoInf))
            {
                foreach (TOAlunoInf aluno in alunos)
                {
                    TratarCpf(aluno);
                    InsertAluno((TOAlunoInf)aluno);
                }
            }
        }

        //Validar Login
        public static TOUsuario ValidateLogin(string user, string password)
        {
            string hashedPassword = Util.GetMD5(password);
            List<TOUsuario> temp = Database.Acess.SelectWhere<TOUsuario>("USUARIO", "Usuario", "Senha", user, hashedPassword);
            if (temp.Count != 0)
            {
                return temp[0];
            }
            return null;
        }
        public static TOUsuario ValidateSession(string user, string password)
        {
            List<TOUsuario> temp = Database.Acess.SelectWhere<TOUsuario>("USUARIO", "Usuario", "Senha", user, password);
            if (temp.Count != 0)
            {
                return temp[0];
            }
            return null;
        }

        //Verifica��es
        public static int verficarSemestre(string semestre)
        {
            return Database.Acess.SelectWhere<TOLogin>("SEMESTRES", "Semestre", semestre).Count;
        }
        public static bool DRIExists(string cpf)
        {
            List<TODRI> list = Database.Acess.SelectWhere<TODRI>("DRI", "Cpf", cpf);
            if (list.Count == 1)
            {
                return true;
            }
            else if (list.Count == 0)
            {
                return false;
            }
            throw new Exception("Existem dados repetidos na tabela das DRIs.");
        }
        public static TODRI GetDRI(string cpf)
        {
            List<TODRI> list = Database.Acess.SelectWhere<TODRI>("DRI", "Cpf", cpf);
            if (list.Count == 1)
            {
                return list[0];
            }
            throw new Exception("Existem dados repetidos na tabela das DRIs.");

        }
    }
}