﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robo;
using OpenQA.Selenium.Support.UI;
using robo.Control.Legado;

namespace robo.Control.Relatorios.FIES_Legado
{
    class ExportarExtratoMensalDeRepasse : UtilFiesLegado
    {
        private IWebDriver Driver;
        public void ExtratoMensalDeRepasseLegado(IWebDriver driver, string campus, string ano, string mes)
        {
            Driver = driver;
            ClickDropDown(Driver, "id", "nu_ano", ano);
            ClickDropDown(Driver, "id", "nu_mes", mes);
            SelectElement select = new SelectElement(Driver.FindElement(By.Id("dt_repasse")));
            if (select.Options.Count > 2)
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("alert(\"Por favor selecione uma data\")");
                while (isAlertPresent(Driver))
                {
                    System.Threading.Thread.Sleep(100);
                }
                while (select.SelectedOption.Text == "Selecione")
                {
                    System.Threading.Thread.Sleep(500);
                }
            }
            else if (select.Options.Count == 1)
            {
                return;
            }
            else
            {
                select.SelectByIndex(1);
            }
            Driver.FindElement(By.Id("btn_excel")).Click();
            SalvarArquivos(Driver, "Extrato_Mensal_Repasse_", campus);
        }
    }
}
