using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            return View();
        }

         public ActionResult Books()
        {
            var books = BooksFactory.CreateBooks();
            return View(books);
        }
        public ActionResult Film()
        {
            var films = FilmFactory.CreateFilm();
            return View(films);
        }

        public ActionResult AboutMe()
        {
           
            return View();
        }

      

    }
}
