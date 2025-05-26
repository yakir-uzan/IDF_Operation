using System;
using System.Collections.Generic;

public class Hamas
{
    //רשימת מחבלים
    public List<Terrorist> ListTerorrists = new List<Terrorist>();

    //הוספת מחבלים לרשימה
    public void AddTerorrist(int id,string name, string weapon, string rank, string status)
    {
    var terrorist = new Terrorist(id, name, weapon, rank, status);
    ListTerorrists.Add(terrorist);
    }
  
    //הפיכת סטטוס המחבל
public void ChengeStatus(Terrorist terrorist)
    {
     terrorist.Status = "dead";
    }      
            

    public void Printstatus(Terrorist terrorist)
    {
        Console.WriteLine($"the{terrorist.Name}is{terrorist.Status }");
    }
  
}


