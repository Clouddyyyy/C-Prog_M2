namespace _03_constructors;


internal class Program{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        QuizVraag quizVraag = new QuizVraag("Here will be the vraag");
    }
    internal void Run()
    {
        
    }
}


class QuizVraagAntwoord
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Quiz
{
    internal QuizVraag[] vragen;

    internal QuizVraagAntwoord[] ingevuldeAntwoorden;
}

class QuizVraag
{
   internal string vraag;
   internal string antwoord;

   internal QuizVraag(string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }
}
