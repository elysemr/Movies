using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; } = "PG"; //how you can enter a default value
        public int Released { get; set; } //year only
        public int Runtime { get; set; } //in mintues
        public string Director { get; set; }

        public Movie() { } //default constructor, add now so don't get error later
        public Movie(int id, string title, string genre, string rating,
            int released, int runtime, string director)
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.Runtime = runtime;
            this.Director = director; }

            public int RuntimeMins(int hours, int mins) 
        { 
            return (hours * 60) + mins;
        }


            public void Print(int id, string title, string genre, string rating,
            int released, int runtime, string director)
            {
                Console.WriteLine($"Here's everything you need to know about {title}: Genre: {genre}, Rating: {rating}, " +
                    $"Year Released: {released}, Runtime in Minutes: {runtime}, Director: {director}.");
            }

            //think about own life and build class for it and add class for it
        }
      
}

