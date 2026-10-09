public class inventory
{
    public List<objekt> objekt = [];

    public void Display()
    {
        for (int i = 0; i < objekt.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {objekt[i].namn}");
        }
    }
}