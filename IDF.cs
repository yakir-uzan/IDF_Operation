using System.Collections.Generic;

public class IDF
{
    //מאפיניי הארגון
    public int CreationDate;
    public string Commander;

    public IDF(int CreationDate = 1948, string Commander = "Eyal Zamir")
    {
        this.CreationDate = CreationDate;
        this.Commander = Commander;
    }

    //רשימת נשקים
    public List<Weapons> ListWeapons = new List<Weapons>();
  
    //הוספת כלי נשק לרשימה
    public void AddWeapon(string name, int numAttacks, string goodAgainst)
    {
        var Weapon = new Weapons(name, numAttacks, goodAgainst);
        ListWeapons.Add(Weapon);
    }

    //רשימת ידיעות
    public List<Intel> ListIntel = new List<Intel>();    
}