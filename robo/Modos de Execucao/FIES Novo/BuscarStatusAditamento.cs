﻿using OpenQA.Selenium;
using robo.TO;
using robo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo.Modos_de_Execucao.FIES_Novo
{
    public class BuscarStatusAditamento : UtilFiesNovo
    {
        private IWebDriver Driver;

        public void BuscarStatus(TOAluno aluno, string semestreAtual)
        {
            ConsultarAluno(Driver, aluno);
            if (aluno.Conclusao != "Não Feito")
            {
                return;
            }
            WaitForLoading(Driver);

            if (VerificarNenhumaInformacaoDisponivel(Driver) == true)
            {
                Util.EditarConclusaoAluno(aluno, "Nenhuma informação disponível");
                return;
            }
            else
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
        }

        public void SetDriver(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
