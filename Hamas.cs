using System;
using System.Collections.Generic;

public class Hamas
{
    //רשימת מחבלים
    public List<Terorrist> ListTerorrists = new List<Terorrist>();

    //הוספת מחבלים לרשימה
    public void AddTerorrist(int id,string name, string weapon, string rank, string status)
    {
    var terorrist = new Terorrist(id, name, weapon, rank, status);
    ListTerorrists.Add(terorrist);
    }
  
    //הפיכת סטטוס המחבל
public void ChengeStatus(Terorrist terrorist)
    {
     terrorist.Status = "dead";
    }      
            

    public void Printstatus(Terorrist terrorist)
    {
        Console.WriteLine($"the{terrorist.Name}is{terrorist.Status }");
    }
  
}


