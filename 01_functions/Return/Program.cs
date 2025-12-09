namespace Return;

internal class Program
{
    string[] vragen = new string[]
    {
        "What 1997 N64 video game features James Bond and is named after the 1996 film?",
        "What arcade game was called Puckman in Japan?",
        "Which spooky 2001 GameCube game starring Mario's brother got a reboot for Nintendo Switch in 2019?",
        "Which video game console released in 2006 pioneered the use of motion controls in its gameplay?"

    };
    
    
    internal string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }


    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        program.vraag1();
        program.vraag2();
        program.vraag3();
        program.vraag4();
        program.vraag5();
        program.vraag6();
        program.vraag7();
    }
    internal void Run()
    {
        string rndvraag = GetRandomVraag();
        Console.WriteLine(rndvraag);
        string vraag0 = GetVraag(0);
        string vraag1 = GetVraag(1);
        string vraag2 = GetVraag(2);
        string vraag3 = GetVraag(3);
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
    internal string vraag7()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();
        Console.WriteLine("antwoord");
        return antwoord;
    }    
    internal string GetRandomVraag()
    {
       
       Random dice = new Random(); //maak random
      
        int GetRandomVraag= dice.Next(vragen.Length);
        Console.WriteLine("we pakkene" + GetRandomVraag);
        return GetVraag(GetRandomVraag); //pak vraag;
    }
}