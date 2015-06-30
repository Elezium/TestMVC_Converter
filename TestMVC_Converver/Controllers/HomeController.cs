using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC_Converver.Models;

namespace TestMVC_Converver.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Language> lang = new List<Language>
            {
                new Language { LanguageId = 1, Name = "C#" },
                new Language { LanguageId = 2, Name = "JavaScript" },
                new Language { LanguageId = 3, Name = "Cobol"}
                
            };

            ViewBag.LanguageId = new SelectList(lang, "LanguageId", "Name");

            return View();
        }
    }
}