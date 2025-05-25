using System.Collections.Generic;

public class AttackManager
{
    public List<Weapons> ListWeapons = new List<Weapons>();
    public List<Intel> ListiNTEL = new List<Intel>();





    public void AddedWeapon(Weapons weapons)
    {
        ListWeapons.Add(weapons);
    }



}