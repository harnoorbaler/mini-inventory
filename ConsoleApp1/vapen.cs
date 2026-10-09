public class Vapen : objekt
{
    public int minskada = 10;
    public int maxskada = 20;

    public int Attack()
    {
        return Random.Shared.Next(minskada, maxskada);
    }
}