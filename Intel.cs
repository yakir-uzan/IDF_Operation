using System.Data.Common;

public class Intel
{
    public Terrorist Terorrist;
    public string Location;
    public string TimeStamp;

    public Intel(Terrorist terorrist, string location, string timeStamp)
    {
        this.Terorrist = terorrist;
        this.Location = location;
        this.TimeStamp = timeStamp;
    }

}