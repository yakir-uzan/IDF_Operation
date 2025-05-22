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
            Hamas hamas = new Hamas();
            Terorrist ahmad = new Terorrist(hamas, "Ahmad", "m16", "5", "alive");
        }
    }
}
