namespace RijFolder;
class RijFolder
{
static void Main(string[] args)
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

    RijLeraar rijLeraar = new RijLeraar
    {
        leeftijd = 30,
        naam = "John",
        zzp = false
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

     
    
       Student student = new Student
    {
      naam = "Cloud",
      leeftijd = 116,
      lespakket = lesPakket,
      theorietest = TheorieTest,
      rijTest = rijTest
    };
       

    LesUur[] LesUrenArray = new LesUur[3];
    LesUrenArray[0] = new LesUur() {tijd = 11, auto = auto2, rijLeraar = rijLeraar, student = student};
    LesUrenArray[1] = new LesUur() {tijd = 13, auto = auto1, rijLeraar = rijLeraar, student = student};
    LesUrenArray[2] = new LesUur() {tijd = 15, auto = auto2, rijLeraar = rijLeraar, student = student};
   

    Dag dag = new Dag
    {
        datum = DateTime.Now,
        LesUren = LesUrenArray
      
    };
    student.dag = dag;
    Console.WriteLine($"student {student.naam}: leeftijd {student.leeftijd}, heeft {student.dag.LesUren.Length} lesuren gepland.");

   
        }

}
