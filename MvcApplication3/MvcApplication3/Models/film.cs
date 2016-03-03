using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class film
    {
        public string name;
        public string year;


        public film(string nm, string yr)
        {
            this.name = nm;
            this.year = yr;

        }


    }
}