using System.Collections.Generic;

public class IDF
{
    public int CreationDate;
    public string Commander;

    public IDF(int CreationDate = 1948, string Commander = "Eyal Zamir")
    {
        this.CreationDate = CreationDate;
        this.Commander = Commander;
    }

    //רשימת נשקים
    public List<Weapons> ListWeapons = new List<Weapons>();
    //רשימת ידיעות
    public List<Intel> ListIntel = new List<Intel>();
}