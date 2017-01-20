using System.Collections.Generic;
using System.Linq;
using trening.Models;
using trening.DBModel;
namespace trening.Methods
{
    public class OsobyMethod
    {
        static SolarisEntities db = new SolarisEntities();

        public static List<OsobyModel> GetOsoby()
        {
            var model = db.Osoba.Select(x => new OsobyModel
            {
                ID = x.ID,
                Nazwisko = x.Nazwisko,
                Imie = x.Imie,
                PESEL = x.PESEL,
                Wiek = x.Wiek
            }).ToList();
            return (model);
        }
        //public Osoba PostOsoby()
        //{
        //    var model = new OsobyModel(x => new Main
        //    {
        //        ID = x.
        //        Nazwisko = x.Nazwisko,
        //        Imie = x.Imie,
        //        PESEL = x.PESEL,
        //        Wiek = x.Wiek
        //    });
        //}

    }
}