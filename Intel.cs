using System.Data.Common;

public class Intel 
{
    public Terrorist Terrorist;
    public string Name;
    public string Location;
    public string TimeStamp;
    

    public Intel (Terrorist terrorist,string location, string timeStamp)
    {
        //this.Terorrist = terorrist;
        //this.Terrorist.Name = name;
        this.Terrorist = terrorist;
        this.Location = location;
        this.TimeStamp = timeStamp;
    }

}