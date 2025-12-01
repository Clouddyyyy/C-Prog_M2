using RijSchool;

namespace RijFolder;

internal class Program
{
    internal void Run()
    {
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

    RijLeraar rijLeraar = new RijLeraar()
    {
        leeftijd = 30,
        naam = "John",
        zzp = false
    };
     LesUur lesUur = new LesUur()
    {
        auto = auto1,
        rijLeraar = rijLeraar,
       

        tijd = 1130
    };
     LesPakket lesPakket = new LesPakket
        {
            urenGekocht = 15,
            urenVerbruikt = 7,
            examenPogingen = 2,
            automaat = true
        };
         TheorieTest TheorieTest = new TheorieTest
        {
            aantalFouten = 6,
            gehaald = true,
            afnameDatum = DateTime.Now
        };
        RijTest rijTest = new RijTest
        {
            gehaald = true,
            afnameDatum = DateTime.Now
        };

string[] LesUrenArray = new string[2];
LesUrenArray[0] = ("3 uur");
LesUrenArray[1] = ("4 uur");
LesUrenArray[2] = ("5 uur");


    Dag dag = new Dag
    {
        datum = DateTime.Now,
        lesUur = lesUur
      
    };

 Student student = new Student()
    {
      naam = "Cloud",
      leeftijd = 116,
      lespakket = lesPakket,
      theorietest = TheorieTest,
      rijTest = rijTest,
      lesUur = lesUur,
      dag = dag
      
    };
    }

    static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

   

     
}