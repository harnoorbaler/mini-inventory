using System.Reflection.Metadata;

public class Consumable : objekt
{
    public int Usesmax = 3;
    public int Usescurrent = 3;

    public void Use(karaktär target)
    {
        if (Usescurrent > 0)
        {
            target.hp += 10;
            Usescurrent--;
        }
    }
}