using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            var LegallyBlonde = new Movie();
            LegallyBlonde.Id = 1;
            LegallyBlonde.Title = "Legally Blonde";
            LegallyBlonde.Genre = "Comedy";
            LegallyBlonde.Rating = "PG-13";
            LegallyBlonde.Released = 2001;
            LegallyBlonde.Runtime = LegallyBlonde.RuntimeMins(1, 36);
            LegallyBlonde.Director = "Robert Luketic";
            LegallyBlonde.Print(LegallyBlonde.Id, LegallyBlonde.Title, LegallyBlonde.Genre, LegallyBlonde.Rating,
            LegallyBlonde.Released, LegallyBlonde.Runtime, LegallyBlonde.Director);
            var Clueless = new Movie();
            Clueless.Id = 2;
            Clueless.Title = "Clueless";
            Clueless.Genre = "Comedy";
            Clueless.Rating = "PG-13";
            Clueless.Released = 1995;
            Clueless.Runtime = Clueless.RuntimeMins(1, 37);
            Clueless.Director = "Amy Heckerling";
            Clueless.Print(Clueless.Id, Clueless.Title, Clueless.Genre, Clueless.Rating, Clueless.Released, Clueless.Runtime, Clueless.Director);
            var CenterStage = new Movie();
            CenterStage.Id = 3;
            CenterStage.Title = "Center Stage";
            CenterStage.Genre = "Drama";
            CenterStage.Rating = "PG-13";
            CenterStage.Released = 2000;
            CenterStage.Runtime = CenterStage.RuntimeMins(1, 55);
            CenterStage.Director = "Nicholas Hytner";
            CenterStage.Print(CenterStage.Id, CenterStage.Title, CenterStage.Genre, CenterStage.Rating,
                CenterStage.Released, CenterStage.Runtime, CenterStage.Director);
            var TenThings = new Movie();
            TenThings.Id = 4;
            TenThings.Title = "10 Things I Hate About You";
            TenThings.Genre = "Comedy";
            TenThings.Rating = "PG-13";
            TenThings.Released = 1999;
            TenThings.Runtime = TenThings.RuntimeMins(1, 37);
            TenThings.Director = "Gil Junger";
            TenThings.Print(TenThings.Id, TenThings.Title, TenThings.Genre, TenThings.Rating,
                TenThings.Released, TenThings.Runtime, TenThings.Director);
            var HowToLoseAGuy = new Movie();
            HowToLoseAGuy.Id = 5;
            HowToLoseAGuy.Title = "How To Los a Guy in 10 Days";
            HowToLoseAGuy.Genre = "Romantic Comedy";
            HowToLoseAGuy.Rating = "PG-13";
            HowToLoseAGuy.Released = 2003;
            HowToLoseAGuy.Runtime = HowToLoseAGuy.RuntimeMins(1, 56);
            HowToLoseAGuy.Director = "Donald Petrie";
            HowToLoseAGuy.Print(HowToLoseAGuy.Id, HowToLoseAGuy.Title, HowToLoseAGuy.Genre, HowToLoseAGuy.Rating,
                HowToLoseAGuy.Released, HowToLoseAGuy.Runtime, HowToLoseAGuy.Director);






        }
    }
}
