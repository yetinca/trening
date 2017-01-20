using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trening.Models
{
    public class OsobyModel
    {
        public int ID { get; set; } 
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string PESEL { get; set; }
        public int? Wiek { get; set; }


    }
}