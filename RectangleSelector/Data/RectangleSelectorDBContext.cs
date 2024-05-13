using Microsoft.EntityFrameworkCore;
using RectangleSelector.Data.Models;

namespace RectangleSelector.Data;

public class RectangleSelectorDBContext : DbContext
{
   public DbSet<Rectangle> Rectangles { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.
         UseInMemoryDatabase("RectangleDatabase").
         LogTo(Console.WriteLine);
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      // seed
      modelBuilder.Entity<Rectangle>().HasData(
      new Rectangle(1, 5, 2, 8, 6, 4, 9, 1, 5),
      new Rectangle(2, 10, 10, 15, 13, 13, 16, 8, 13)
      );
   }

   public RectangleSelectorDBContext()
   {
      Database.EnsureCreated();
   }
}