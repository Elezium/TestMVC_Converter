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
                new Language { LanguageId = 1, Name = "C#", PrismName="language-csharp" },
                new Language { LanguageId = 2, Name = "JavaScript", PrismName="language-javascript" },
                new Language { LanguageId = 3, Name = "Markdown", PrismName="language-markdown"}
                
            };

            Paste paste = new Paste();
            paste.PasteId = 1;
            paste.Expiry = DateTime.Now.AddDays(5);
            paste.Title = "Title";
            paste.Languages = lang;


            ViewBag.LanguageId = new SelectList(lang, "LanguageId", "Name");

            return View(paste);
        }
    }
}