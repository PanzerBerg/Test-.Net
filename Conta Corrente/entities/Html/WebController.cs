using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;

namespace Conta_Corrente.entities
{
    class WebController
    {
        public static void StartCrawler()
        {
            var url = "https://www.infomoney.com.br/ferramentas/cambio/";

            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var value = doc.DocumentNode.SelectSingleNode("//*[@id='container_table']/table/tbody/tr[5]/td[3]");
            Console.WriteLine(value.InnerText);
            DolarCotacao.SetPreco(value.InnerText);
            DolarCotacao.Arredondar();
        }
    }
}
