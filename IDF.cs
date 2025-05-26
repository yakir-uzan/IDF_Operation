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
            new Weapons("f16", 0, "Car"),
            new Weapons("m640", 0, "Open space"),
            new Weapons("j689", 0, "Structure")
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

    public void AddedIntel()
    {
        ListIntel.Add();
    }

    //שינוי סטטוס מחבל
    public void ChengeStatus(Terrorist terrorist)
    {
        terrorist.Status = "dead";
    }
    


}