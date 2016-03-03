using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class FilmFactory
    {
        public static IEnumerable<film> CreateFilm()
        {
            List<film> films = new List<film>();
            films.Add(new film("Жизнь, как она есть", "2010"));
            films.Add(new film("Голая правда", "2009"));
            films.Add(new film("Игры разума", "2001"));
            films.Add(new film("Остров проклятых", "2009"));
            return films;
        }
    }
}