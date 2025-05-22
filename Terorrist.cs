public class Terorrist
{
    public string Name;
    public string Weapon;
    public string Rank;
    public string Status;

    public Terorrist(Hamas hamas, string name, string weapon, string rank, string status)
    {
        Name = name;
        Weapon = weapon;
        Rank = rank;
        Status = status;
        hamas.terorrists.Add(this);
    }
}

