using System.Collections.Generic;

public class Hamas
{
      //רשימת מחבלים
    public List<Terorrist> terorrists = new List<Terorrist>();


    




    //הוספת מחבלים לרשימה
    public void AddTerorrist(int id,string name, string weapon, string rank, string status)
    {
    var terorrist = new Terorrist(id, name, weapon, rank, status);
    Terorrists.Add(terorrist);
    }
public void ChengeStatus(Terorrist terrorist)
    {
        foreach(Terorrist terror in terorrists)
        {
            if (terror == terrorist)
            {
                terror.Status = "dead";
            }
        }
    }

}


