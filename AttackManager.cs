using System;
using System.Collections.Generic;

public class AttackManager
{


    public void cheack( IDF idf,string cheackname)
    {
        foreach (Intel i in idf.ListIntel)
        if (i.Terorrist.Name == cheackname)
            {
                if (i.TimeStamp == "-1")

                    foreach (Weapons w in idf.ListWeapons)
                    {
                        if (w.GoodAgainst == i.Location && w.NumAttacks > 0)
                        {
                            Console.WriteLine("התקיפה בוצעה בהצלחה");
                            i.Terorrist.Status = "dade";
                            w.NumAttacks -= 1;
                            Console.WriteLine($"פירוט נתוני התקיפה המחבל בשם {i.Terorrist.Name} במצב {i.Terorrist.Status} על ידי כלי תקיפה מסוג {w.Name} כמות החימוש שנשאר הוא {w.NumAttacks}");
                        }
        }           }
    }
}

