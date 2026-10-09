using System.Reflection.Metadata;

public class karaktär
{
    public int hp;
    public string namn;
    public inventory Ryggsäck;

    public karaktär()
    {
        Ryggsäck = new();
        Vapen W = new() { namn = "yxa", vikt = 10f };
        Consumable p = new() { namn = "hälso dryck", vikt = 2f };

        Ryggsäck.objekt.Add(W);
        Ryggsäck.objekt.Add(p);
        hp = 100;
        namn = "";
    }
}