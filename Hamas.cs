using System.Collections.Generic;

public class Hamas
{
    public List<Terorrist> terorrists = new List<Terorrist>();


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



    public 
}