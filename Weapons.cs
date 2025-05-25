using System;
using System.Collections.Generic;

public class Weapons
{
    public string Name;
    public int NumAttacks;
    public string GoodAgainst;


    public Weapons(string name, int numAttacks, string goodAgainst)
    {
        Name = name;
        NumAttacks = numAttacks;
        GoodAgainst = goodAgainst;
    }

    //רשימת כלי נשק
    public List<Weapons> ListWeapons = new List<Weapons>();
    public void AddWeapons(string name, int numAttacks, string goodAgainst)
    {
        var Weapon = new Weapons(name, numAttacks, goodAgainst);
         ListWeapons.Add(Weapon);
    }
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

}


