using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {

        // יצירת מופעים לטרוריסטים      

         Hamas objHamas = new Hamas();
         objHamas.AddTerorrist(1, "Ahmad", "m16", "5", "alive");
         objHamas.AddTerorrist(2, "Mohamad", "m16", "4", "alive");
         objHamas.AddTerorrist(3, "Dia", "m16", "3", "alive");
         objHamas.AddTerorrist(4, "Adam", "m16", "2", "alive");

        //הוספת ידיעה לרשימה
        Intel inform = new Intel(objHamas.ListTerorrists[0],"gaza", "20:00");
        }
    }
}
