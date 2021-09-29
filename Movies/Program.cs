using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            var LegallyBlonde = new Movie();
            LegallyBlonde.Title = "Legally Blonde";
            LegallyBlonde.Genre = "Comedy";
            LegallyBlonde.Rating = "PG-13";
            LegallyBlonde.Released = 2001;
            LegallyBlonde.Runtime = Movie.RuntimeMins(1, 36);
            LegallyBlonde.Director = "Robert Luketic";
            
            //the way to actually do this:
                //var LegallyBlonde =
                    //new Movie("Legally Blonde", "Comedy", "PG-13", 2001, LegallyBlonde.RuntimeMines(1, 36), "Luketic");
            var Clueless = new Movie();
            Clueless.Title = "Clueless";
            Clueless.Genre = "Comedy";
            Clueless.Rating = "PG-13";
            Clueless.Released = 1995;
            Clueless.Runtime = Movie.RuntimeMins(1, 37);
            Clueless.Director = "Amy Heckerling";
            var CenterStage = new Movie();
            CenterStage.Title = "Center Stage";
            CenterStage.Genre = "Drama";
            CenterStage.Rating = "PG-13";
            CenterStage.Released = 2000;
            CenterStage.Runtime = Movie.RuntimeMins(1, 55);
            CenterStage.Director = "Nicholas Hytner";
            
            var TenThings = new Movie();
            TenThings.Title = "10 Things I Hate About You";
            TenThings.Genre = "Comedy";
            TenThings.Rating = "PG-13";
            TenThings.Released = 1999;
            TenThings.Runtime = Movie.RuntimeMins(1, 37);
            TenThings.Director = "Gil Junger";
            
            var HowToLoseAGuy = new Movie();
            HowToLoseAGuy.Title = "How To Los a Guy in 10 Days";
            HowToLoseAGuy.Genre = "Romantic Comedy";
            HowToLoseAGuy.Rating = "PG-13";
            HowToLoseAGuy.Released = 2003;
            HowToLoseAGuy.Runtime = Movie.RuntimeMins(1, 56);
            HowToLoseAGuy.Director = "Donald Petrie";


            Console.WriteLine(LegallyBlonde.Print());
            Console.WriteLine(Clueless.Print());
            Console.WriteLine(CenterStage.Print());
            Console.WriteLine(TenThings.Print());
            Console.WriteLine(HowToLoseAGuy.Print());

            //what I did...wrong (even tho it worked)
            /*
            LegallyBlonde.Print(LegallyBlonde.Title, LegallyBlonde.Genre, LegallyBlonde.Rating,
            LegallyBlonde.Released, LegallyBlonde.Runtime, LegallyBlonde.Director, LegallyBlonde.Id);
            Clueless.Print(Clueless.Title, Clueless.Genre, Clueless.Rating, Clueless.Released, Clueless.Runtime, Clueless.Director, Clueless.Id);
            CenterStage.Print(CenterStage.Title, CenterStage.Genre, CenterStage.Rating,
                CenterStage.Released, CenterStage.Runtime, CenterStage.Director, CenterStage.Id);
            TenThings.Print(TenThings.Title, TenThings.Genre, TenThings.Rating,
                TenThings.Released, TenThings.Runtime, TenThings.Director, TenThings.Id);
            HowToLoseAGuy.Print(HowToLoseAGuy.Title, HowToLoseAGuy.Genre, HowToLoseAGuy.Rating,
                HowToLoseAGuy.Released, HowToLoseAGuy.Runtime, HowToLoseAGuy.Director, HowToLoseAGuy.Id); */





        }
    }
}
