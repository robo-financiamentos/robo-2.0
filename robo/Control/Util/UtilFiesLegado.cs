﻿using OpenQA.Selenium;
using Robo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo.Control.Legado
{
    public class UtilFiesLegado : UtilSelenium
    {
        public UtilFiesLegado()
        {

        }


        public bool RealizarLoginSucesso(TOLogin login, IWebDriver Driver)
        {
            while (Driver.PageSource.Contains("img/titAcessoInstituicao.gif") == false)
            {
                System.Threading.Thread.Sleep(500);
            }
            ClickButtonsByCss(Driver, "#link-instituicao img:nth-child(1)");

            ClickButtonsByCss(Driver, "center:nth-child(10) td:nth-child(2) .guest-box:nth-child(1) span:nth-child(2)");
            while (Driver.Url.Contains("InitAuthenticationByIdentifierAndPassword") == false)
            {
                System.Threading.Thread.Sleep(100);
            }
            ClickAndWriteById(Driver, "id", login.Usuario);
            ClickAndWriteById(Driver, "pw", login.Senha);

            ClickButtonsById(Driver, "botoes");
            if (!Driver.PageSource.Contains("A senha informada não confere. Número de tentativas restAes:"))//Ocorreu uma falha na execução da aplicação. A caixa de erro ao lado mostra o motivo da falha. Provavelmente alguma informação incorreta foi processada.
            {
                return true;
            }
            else
            {
                throw new Exception("A senha informada não confere. Por favor, cheque se todos logins foram inseridos corretamente.");
            }

        }
        public void SelecionarPerfilPresidencia(IWebDriver Driver)
        {
            while (Driver.PageSource.Contains("Aditamentos FIES") == false)
            {
                Driver.FindElement(By.XPath("//select[@name='co_perfil']/option[contains(.,'CPSA Presidência')]")).Click();
                WaitPageToLoad(Driver);
            }
        }
        public void WaitinLoading(IWebDriver Driver)
        {
            IWebElement Carregando = Driver.FindElement(By.ClassName("background-grey"));
            bool carr = Carregando.Displayed;
            while (carr == true)
            {
                System.Threading.Thread.Sleep(1000);
                Carregando = Driver.FindElement(By.ClassName("background-grey"));
                carr = Carregando.Displayed;
            }
        }
        public void FazerLogout(IWebDriver Driver)
        {
            ClickButtonsByXpath(Driver, "//a[contains(text(),'Sair')]");
        }
        public void SelecionarMenuDRI(IWebDriver Driver)
        {
            ClickButtonsByXpath(Driver, "//a[contains(text(),'Validação pela CPSA Fies')]");
        }
        public void SelecionarMenuBaixarDocumentos(IWebDriver Driver)
        {
            ClickButtonsByCss(Driver, "div:nth-child(3) > ul > .menu-button:nth-child(3) > a");
        }
        public void SelecionarMenuExtratoMensalDeRepasse(IWebDriver Driver)
        {
            ClickButtonsByXpath(Driver, "/html/body/div[3]/div[4]/div[1]/div[4]/ul/li[1]/a");
        }
        public bool VerificaErro(IWebDriver Driver, TOAluno aluno)
        {
            IWebElement listaME = Driver.FindElement(By.Id("lista-mensageiro-erros"));
            if (listaME.Displayed)
            {
                IWebElement listaF = listaME.FindElement(By.XPath(".//li"));
                Util.EditarConclusaoAluno(aluno, listaF.Text);
                return true;
            }
            return false;
        }
        public string SelecionarTipoRelatorio(IWebDriver Driver, string tipoRelatorio)
        {
            switch (tipoRelatorio)
            {
                case "DRM":
                    ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Aditamento de Renovação");
                    return "Aditamento de Renovação";
                case "DRT":
                    ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Aditamento de Transferência");
                    return "Aditamento de Transferência";
                case "DRD":
                    ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Aditamento de Dilatação");
                    return "Aditamento de Dilatação";
                case "Suspensao":
                    ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Suspensão");
                    return "Suspensão";
                default:
                    return string.Empty;
            }
        }
    }
}