using System;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
  public class Movie
  {
    public int ID {get;set;}
    public string Title {get;set;}
    public DateTime ReleaseDate {get;set;}
    public string Genre {get;set;}
    public decimal Price {get;set;}
  }

  public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            :base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie {get;set;}
    }
}
