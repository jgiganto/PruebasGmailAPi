using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Plus.v1;
using AE.Net.Mail;
using PruebasGmailAPi.Models;
 


namespace PruebasGmailAPi.Controllers
{
    public class HomeController : Controller
    {
        ModeloCorreos modelo;
        GmailService mails;
        public HomeController()
        {
            modelo = new ModeloCorreos();
            mails = new GmailService();
        }

        public ActionResult Index()
        {
             
            var lista = modelo.ListThreads(mails, "correosencriptados123@gmail.com");
            
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
    }
}