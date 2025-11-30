namespace RijLeraar;

internal class RijLeraar
{
    internal string naam;
    internal int leeftijd;
    internal bool zzp;
}

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    RijLeraar rijLeraar = new RijLeraar()
    {
        leeftijd = 30,
        naam = "John",
        zzp = false
    };
}