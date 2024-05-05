using Microsoft.EntityFrameworkCore;
using RectangleSelector.Models;

namespace RectangleSelector
{
   public class RectangleSelectorDBContext : DbContext
   {
      public DbSet<Rectangle> Rectangles { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RectangleDatabase");
      }

      public RectangleSelectorDBContext()
      {
         Database.EnsureCreated();
      }
   }
}