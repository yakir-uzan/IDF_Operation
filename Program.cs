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

            //Hamas hamas = new Hamas();
            //Terorrist ahmad = new Terorrist(hamas, "Ahmad", "m16", "5", "alive");
            
         Hamas objHamas = new Hamas();
         objHamas.AddTerorrist(1, "Ahmad", "m16", "5", "alive");
         objHamas.AddTerorrist(2, "Ahmad", "m16", "4", "alive");
         objHamas.AddTerorrist(3, "Ahmad", "m16", "3", "alive");
         objHamas.AddTerorrist(4, "Ahmad", "m16", "2", "alive");

        Intel inform = new Intel("gaza", "20:00");
        }
    }
}
