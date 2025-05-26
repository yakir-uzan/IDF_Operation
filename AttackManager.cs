using System;
using System.Collections.Generic;
   
public class AttackManager
{

    //פונקציה לפעולות תקיפה
    public void cheack(IDF idf, string cheackname)
    //{מחפש האם קיים מחבל עם מידע על השם הזה
    {
        foreach (Intel i in idf.ListIntel)
        {
            if (i.Terrorist.Name == cheackname)
            {
                if (i.TimeStamp == "11")
                {
                    foreach (Weapons w in idf.ListWeapons)
                    {
                        if (w.GoodAgainst == i.Location && w.NumAttacks > 0)
                        {
                            Console.WriteLine("התקיפה בוצעה בהצלחה");
                            i.Terrorist.Status = "dade";
                            w.NumAttacks -= 1;
                            Console.WriteLine($"פירוט נתוני התקיפה המחבל בשם {i.Terrorist.Name} במצב {i.Terrorist.Status} על ידי כלי תקיפה מסוג {w.Name} כמות החימוש שנשאר הוא {w.NumAttacks}");
                            return;
                        }
                    }
                     Console.WriteLine("אין נשק מתאים לתקיפה הנוכחית");
                            
                        
                    

                }
                else
                {
                    Console.WriteLine("המידע המודיעני לא מעודכן");
                    return;
                }

            }
            else
            {
                Console.WriteLine("אין מידע מודיעני על המחבל");
                return;
            }

        }

            Console.WriteLine("pringgggg");







    }
}
                        
                    
                

                
                
                    
                

           
        


            
       
    

