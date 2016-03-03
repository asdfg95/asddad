using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class book
    {
        public string name;
        public string author;
     

        public book(string nm, string ath )
        {
            this.name = nm;
            this.author = ath;
            
        }


    }
}