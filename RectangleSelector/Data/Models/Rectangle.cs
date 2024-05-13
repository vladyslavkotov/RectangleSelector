using Microsoft.EntityFrameworkCore;

namespace RectangleSelector.Data.Models
{
   [Index(nameof(X1), nameof(Y1), nameof(X2), nameof(Y2), nameof(X3), nameof(Y3), nameof(X4), nameof(Y4), IsUnique = true)]
   public record Rectangle
   {
      public int Id { get; set; }
      public double X1 { get; set; }
      public double Y1 { get; set; }
      public double X2 { get; set; }
      public double Y2 { get; set; }
      public double X3 { get; set; }
      public double Y3 { get; set; }
      public double X4 { get; set; }
      public double Y4 { get; set; }

      public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
      {
         X1 = x1;
         Y1 = y1;
         X2 = x2;
         Y2 = y2;
         X3 = x3;
         Y3 = y3;
         X4 = x4;
         Y4 = y4;
      }

      //for seeding purposes
      public Rectangle(int id, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
      {
         Id = id;
         X1 = x1;
         Y1 = y1;
         X2 = x2;
         Y2 = y2;
         X3 = x3;
         Y3 = y3;
         X4 = x4;
         Y4 = y4;
      }
   }
}