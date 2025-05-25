using System.Collections.Generic;

public class Hamas
{
    //רשימת מחבלים
    public List<Terorrist> Terorrists = new List<Terorrist>();

    //הוספת מחבלים לרשימה
    public void AddTerorrist(int id,string name, string weapon, string rank, string status)
    {
    var terorrist = new Terorrist(id, name, weapon, rank, status);
    Terorrists.Add(terorrist);
    }
}

