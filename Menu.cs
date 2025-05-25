using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation
{
    public class Menu
    {
        public Menu()
        {
            while (true)
            {
                Console.WriteLine("pleas enter a menu");
                string shose = Console.ReadLine();
                switch (shose)
                {
//לבדוק האם קיים מחבל עם השם הזאת
                    case "a":
                        break;
                        //להוסיף מיקום למחבל הנל
                    case "b":
                        break;
                        //לבדוק האם אפשרי להפעיל תקיפה למחבל הנל
                    case "c":
                        break;
                        //להפעיל תקיפה
                    case "d":
                        break;
                        //לבדוק האם התקיפה אכן בוצעה
                }
            }
        }        
    } 
}
