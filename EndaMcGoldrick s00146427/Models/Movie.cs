using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EndaMcGoldrick_s00146427.Models
{
    public class Movie
    {
        public int ID { get; set; }     //Primary Key
        [Display(Name = "Title of Movie")]
        public string Title { get; set; }
        [Display(Name = "Movie Genre")]
        public string Genre { get; set; }

        public virtual ICollection<Actor> actor { get; set; }
    }


    public class Actor
    {
        public int ID { get; set; }     //Primary Key
        public string Name { get; set; }
        public virtual Movie movie { get; set; }
    }

    public class MovieDb:DbContext
    {
        public MovieDb():base("MovieDb")
        { }
        public DbSet<Movie> Blogs { get; set; }
        public DbSet<Actor> Posts { get; set; }
    }
}