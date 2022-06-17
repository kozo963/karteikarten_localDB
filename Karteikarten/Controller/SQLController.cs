using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karteikarten.Model;
namespace Karteikarten.Controller
{
    public class SQLController
    {

        //Thema
        public static void InsertThema(thema thema)
        {
            EFController eFController = new EFController();
            eFController.thema.Add(thema);
            eFController.SaveChanges();
        }

        public static List<thema> GetThemas()
        {
            EFController eFController = new EFController();
            return eFController.thema.ToList();
        }

        public static List<ThemaHelper> GetThemasWithCount()
        {
            List<ThemaHelper> themaHelpers = new List<ThemaHelper>();

            List<karte> kartes = GetAllKarte();

            List<thema> themas = GetThemas();

            themas.ForEach(x => 
                themaHelpers.Add(new ThemaHelper()
                { 
                        id = x.id, 
                        themaName = x.themaName,
                        karteTotal = kartes.Where(k => k.themaid == x.id).Count()
                }
                ));;

            return themaHelpers;
        }
        public static int GetThemaIDByName(string name)
        {
            EFController eFController = new EFController();
            return eFController.thema.Where(t => t.themaName == name).First().id;
        }


        //Karte
        public static void AddKarte(karte karte)
        {
            EFController eFController = new EFController();
            //karte.t_id = 1;
            eFController.karte.Add(karte);
            eFController.SaveChanges();
        }

        public static void UpdateKarte(karte karte)
        {
            EFController eFController = new EFController();
            eFController.Entry(karte).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            eFController.SaveChanges();
        }

        private static List<karte> GetAllKarte()
        {
            EFController eFController = new EFController();
            return eFController.karte.ToList();
        }

        internal static List<karte> GetKartesByThemaID(int id)
        {
            EFController eFController = new EFController();
            return eFController.karte.Where(x=> x.themaid == id).ToList();
        }

        internal static void DeleteKarte(karte karte)
        {
            EFController eFController = new EFController();
            eFController.Entry(karte).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            eFController.SaveChanges();
        }

        internal static void UpdateThema(thema t)
        {
            EFController eFController = new EFController();
            eFController.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            eFController.SaveChanges();
        }

        internal static void DeleteThemaWithKarte(thema t)
        {
            EFController eFController = new EFController();

            List<karte> kartes = GetAllKarte().Where(x => x.themaid == t.id).ToList();
            kartes.ForEach(k => DeleteKarte(k));
            eFController.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            eFController.SaveChanges(true);
        }
    }
}
