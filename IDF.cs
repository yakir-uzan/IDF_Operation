using System;
using System.Collections.Generic;

public class IDF
{
    //מאפיניי הארגון
    public int CreationDate;
    public string Commander;

    //רשימת נשקים

    public List<Weapons> ListWeapons = new List<Weapons>();


    public IDF(int CreationDate = 1948, string Commander = "Eyal Zamir")
    {
        this.CreationDate = CreationDate;
        this.Commander = Commander;



        //אתחול עם 3 כלי נשק
        ListWeapons = new List<Weapons> {
            new Weapons("f16", 0, "car"),
            new Weapons("m640", 0, "open"),
            new Weapons("j689", 5, "hous")
        };
    }


    //הוספת כלי נשק לרשימה
    public void AddWeapon(string name, int numAttacks, string goodAgainst)
    {
        var Weapon = new Weapons(name, numAttacks, goodAgainst);
        ListWeapons.Add(Weapon);
    }
    //הוספת חימוש
    
    //מוריד אחד פחות
    public void Updateless_one(Weapons weapons)
    {
        weapons.NumAttacks -= 1;
    }

    //מדפיס את כמות התחמושת המעודכנת
    public void PrintUpdate(Weapons weapons)
    {
        Console.WriteLine(weapons.NumAttacks);
    }

    //רשימת ידיעות
    public List<Intel> ListIntel = new List<Intel>();

    public void AddedIntel( Terrorist terrorist,string loccatgion, string timestemp)
    {
        var intel = new Intel(terrorist ,loccatgion, timestemp);
        ListIntel.Add(intel);
    }
    public void PrintIntel()
    {
        foreach (Intel a in ListIntel)
        {
            Console.WriteLine($"{a.Name} {a.Location} {a.TimeStamp}");
        }
    }

    //שינוי סטטוס מחבל
    public void ChengeStatus(Terrorist terrorist)
    {
        terrorist.Status = "dead";
    }
    


}