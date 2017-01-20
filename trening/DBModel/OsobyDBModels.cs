using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace trening.DBModel
{
    [Table("Osoba")]
    public class Main
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string PESEL { get; set; }
        public int? Wiek { get; set; }
    }
}