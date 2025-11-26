namespace Vragen_stellen;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalyspe?");
        Console.WriteLine("Have you ever tried talking to a animal?");
        Console.WriteLine("Which species would be the rudest if all animals could talk?");
        Console.WriteLine("What would you do if you won a million dollars?");
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
    }

    internal void vraag1()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalyspe?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void vraag2()
    {
        Console.WriteLine("Have you ever tried talking to a animal?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }
    internal void vraag3()
    {
        Console.WriteLine("Which species would be the rudest if all animals could talk?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }
    internal void vraag4()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }
    internal void vraag5()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }
    internal void vraag6()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }
}
