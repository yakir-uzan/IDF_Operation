using System.Collections.Generic;

public class Hamas
{
    //רשימת מחבלים
    public List<Terorrist> listTerorrists = new List<Terorrist>();

    //הוספת מחבלים לרשימה
    public void AddTerorrist(int id,string name, string weapon, string rank, string status)
    {
    var terorrist = new Terorrist(id, name, weapon, rank, status);
    listTerorrists.Add(terorrist);
    }
public void ChengeStatus(Terorrist terrorist)
    {
        foreach(Terorrist terror in listTerorrists)
        {
            if (terror == terrorist)
            {
                terror.Status = "dead";
            }
        }
    }

}


