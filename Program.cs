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
            Hamas hamas = new Hamas();
            hamas.AddTerorrist(00, "ali", "knife", "magad", "live");
            hamas.AddTerorrist(01, "achmad", "knife", "magad", "live");
            hamas.AddTerorrist(02, "muchamd", "knife", "magad", "live");
            hamas.AddTerorrist(03, "yosef", "knife", "magad", "live");
            hamas.AddTerorrist(04, "mustafa", "knife", "magad", "live");

            


            //הוספת ידיעה לרשימה
            IDF idf = new IDF();

            Random run = new Random();
            int i = run.Next(hamas.ListTerorrists.Count);
            idf.AddedIntel(hamas.ListTerorrists[0], "hous", "11" );
            idf.AddedIntel(hamas.ListTerorrists[1], "car", "11" );
            idf.AddedIntel(hamas.ListTerorrists[2], "open", "11" );
            idf.AddedIntel(hamas.ListTerorrists[3], "hous", "11");

            //idf.PrintIntel();
            AttackManager manager = new AttackManager();

            manager.cheack(idf,"ali");


        }
    }
}
