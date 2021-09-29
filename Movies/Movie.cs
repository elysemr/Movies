using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movie
    {
        private static int NextId { get; set; } = 1; //this is defined as a property not with the class so it's set to 1 every time created
                                                     //when add static, says this property is different than the ones that aren't marked status, there's only 1

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; } = "PG"; //how you can enter a default value
        public int Released { get; set; } //year only
        public int Runtime { get; set; } //in mintues
        public string Director { get; set; }

        public Movie() { } //default constructor, add now so don't get error later
        public Movie(string title, string genre, string rating,
            int released, int runtime, string director)  //new constructor with properties to initialize a movie with one line
                                                         //id isn't in here because we don't want user generating/inputting
        {
            this.Id = NextId++; //so now user can't set and will increment, other way around would be ++NextId = this.ID (increment and then assign)
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.Runtime = runtime;
            this.Director = director; }

        //example with only time this. *required*
        /* public void SetRating(string Rating) <<confusing because parameter and property are the same name/spelling/capitalization
         * {
         * Rating = Rating; <<would come up with error
         * change to: this.Rating = Rating; clear that left is property and right is parameter
         * } */

        //my code, makes more complicated bc tied to instance
       /* public int RuntimeMins(int hours, int mins) //choice if you want to return something or void
        {
            return (hours * 60) + mins; //this.Runtime would store value into property, so would do public void
        } */
         public static int RuntimeMins(int hours, int mins)
        {
           return hours * 60 + mins;
            }   //<<this works in program because you don't need var or instance, needs class name! 
                    //if not static, will operate on one of the instance properties of the class so need var/instance to run
                    //call using class name instead of instance name so can run before instance created



            //my code, again much more complicated and makes it harder to work with data
           /* public void Print(string title, string genre, string rating,
            int released, int runtime, string director, int Id)
            {
                Console.WriteLine($"Here's everything you need to know about {title}: Genre: {genre}, Rating: {rating}, " +
                    $"Year Released: {released}, Runtime in Minutes: {runtime}, Director: {director} ({Id}).");
            } */

        // how to print string
         public string Print ()
          {
          return $"{Id} | {Title} | {Genre} | {Rating} | {Released} | {Runtime} | {Director}";
         }

            //think about own life and build class for it and add class for it
        }
      
}

