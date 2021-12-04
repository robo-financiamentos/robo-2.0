﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using robo.Utils;
using robo.Contratos;

namespace robo.Modos_de_Execucao.FIES_Legado
{
    public class ExportarDRI : UtilFiesLegado, IModosDeExecucao.IModoSemAlunos
    {
        private string campus;
        private string situacaoDRI;
        public ExportarDRI(string campus, string situacaoDRI)
        {
            this.campus = campus;
            this.situacaoDRI = situacaoDRI;
        }

        public void Executar()
        {
            ExportarDRILegado();
        }

        public void ExportarDRILegado()
        {
            ClickDropDown( "id", "co_situacao_inscricao", situacaoDRI);

            ClickButtonsById( "excel");

            Util.ExportarDocumento("DRI_" + situacaoDRI, campus);
        }

        public void SelecionarMenu()
        {
            SelecionarMenuDRI();
        }

        public void SetWebDriver(IWebDriver Driver)
        {
            this.Driver = Driver;
        }
    }
}
