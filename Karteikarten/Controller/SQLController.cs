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

        //Karte
    }
}
