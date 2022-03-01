using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Architecture.UI;
using Architecture.Types.AgriculturalProductsMarketing;
using Architecture.Base;
using System.Net;
using System.IO;
using System.Text;
using HtmlAgilityPack;

namespace AgriculturalProductsMarketing.Controllers
{
    public class HomeController : Architecture.UI.MVCExecuterBase
    {
        public ActionResult Index()
        {
            CategoryRequest request = new CategoryRequest();
            request.MetodName = "Select";
            //request.Contract = contract;
            var response = this.Execute<CategoryRequest, GenericResponse<List<CategoryContract>>>(request);
            if (!response.Success)
            {

            }
            var returnValue = response.Value;
            
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Deneme()
        {
            /*
            string url = "http://www.yigitsantarim.com/hizmet.asp?bidx=2&basl=TUm+Hizmetler.html";

            Uri uri = new Uri(url);
            WebClient client = new WebClient();
            string html = client.DownloadString(uri);

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
            htmldoc.LoadHtml(html);
            //İndirilen Html kodları, yukarıda oluşturulan htmlagilitypack'den türetilen htmldocument nesnesine aktarılıyor...

            string secilenHtml = "/html/body/div[1]/div[2]/div/div/h1/div[1]";
            HtmlNodeCollection basliklar = htmldoc.DocumentNode.SelectNodes(secilenHtml);
            if (basliklar.Count > 0)
            {
                ViewBag.Html = basliklar[0].InnerHtml;
            }
            */
            return View();
            
        }
    }
}