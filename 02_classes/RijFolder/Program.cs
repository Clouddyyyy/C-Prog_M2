namespace RijFolder;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
     Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AA824H",
        kilometerStand = 20567,
        merk = "volkswagen"

    };

    Auto auto2 = new Auto()
    {
        automaat = false,
        kenteken = "KU786G",
        kilometerStand = 65739,
        merk = "volvo"
    };
    Dag dag = new Dag()
    {
      student = student,
      lesUur = lesUur,
      dag = dag  
    }; 
     LesUur lesUur = new LesUur()
    {
        auto = auto1,
        rijLeraar = rijLeraar,

        tijd = 1130
    };
 Student student = new Student()
    {
      naam = "Cloud",
      leeftijd = 116,
      lespakket = lespakket,
      theorietest = theorietest,
      rijTest = rijTest,
      lesUur = lesUur
    };
}