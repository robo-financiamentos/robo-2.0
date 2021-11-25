﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using robo.Utils;

namespace robo.Modos_de_Execucao.FIES_Legado
{
    public class ExportarDRI : UtilFiesLegado
    {
        private IWebDriver Driver;
        public void ExportarDRILegado(IWebDriver driver, string campus, string situacaoDRI)
        {
            Driver = driver;

            ClickDropDown(Driver, "id", "co_situacao_inscricao", situacaoDRI);

            ClickButtonsById(Driver, "excel");

            Util.ExportarDocumento("DRI_" + situacaoDRI, campus);
        }
    }
}
