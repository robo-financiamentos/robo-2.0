﻿using OpenQA.Selenium;
using Robo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo.Control.Legado
{
    public class UtilFiesLegado
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
            Util.ClickButtonsByCss(Driver, "#link-instituicao img:nth-child(1)");

            Util.ClickButtonsByCss(Driver, "center:nth-child(10) td:nth-child(2) .guest-box:nth-child(1) span:nth-child(2)");
            while (Driver.Url.Contains("InitAuthenticationByIdentifierAndPassword") == false)
            {
                System.Threading.Thread.Sleep(100);
            }
            Util.ClickAndWriteById(Driver, "id", login.Usuario);
            Util.ClickAndWriteById(Driver, "pw", login.Senha);

            Util.ClickButtonsById(Driver, "botoes");
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
                Util.WaitPageToLoad(Driver);
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
            Util.ClickButtonsByXpath(Driver, "//a[contains(text(),'Sair')]");
        }
        public void SelecionarMenuDRI(IWebDriver Driver)
        {
            Util.ClickButtonsByXpath(Driver, "//a[contains(text(),'Validação pela CPSA Fies')]");
        }
        public void SelecionarMenuBaixarDocumentos(IWebDriver Driver)
        {
            Util.ClickButtonsByCss(Driver, "div:nth-child(3) > ul > .menu-button:nth-child(3) > a");
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
                    Util.ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Aditamento de Renovação");
                    return "Aditamento de Renovação";
                case "DRT":
                    Util.ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Aditamento de Transferência");
                    return "Aditamento de Transferência";
                case "DRD":
                    Util.ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Aditamento de Dilatação");
                    return "Aditamento de Dilatação";
                case "Suspensao":
                    Util.ClickDropDown(Driver, "id", "co_finalidade_aditamento", "Suspensão");
                    return "Suspensão";
                default:
                    return string.Empty;
            }
        }
    }
}
