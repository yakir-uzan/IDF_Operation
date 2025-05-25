using System.Data.Common;

public class Intel
{
    public Terorrist Terorrist;
    public string Location;
    public string TimeStamp;

    public Intel(Terorrist terorrist, string location, string timeStamp)
    {
        this.Terorrist = terorrist;
        this.Location = location;
        this.TimeStamp = timeStamp;
    }


}