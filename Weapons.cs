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
    //הוספת כלי נשק לרשימה
    public void AddWeapon(string name, int numAttacks, string goodAgainst)
    {
        var Weapon = new Weapons(name, numAttacks, goodAgainst);
         ListWeapons.Add(Weapon);
    }
}


