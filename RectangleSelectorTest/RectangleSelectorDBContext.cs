using Microsoft.EntityFrameworkCore;

namespace RectangleSelector
{
   public class TestRectangleSelectorDBContext : RectangleSelectorDBContext
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
      }

      public TestRectangleSelectorDBContext()
      {
         Database.EnsureDeleted();
         Database.EnsureCreated();
      }
   }
}