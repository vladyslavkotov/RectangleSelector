using Microsoft.EntityFrameworkCore;

namespace RectangleSelector.Models
{
   [Index(nameof(X1), nameof(X2), nameof(Y1), nameof(Y2), IsUnique = true)]
   public record Rectangle
   {
      public int Id { get; private set; }
      public double X1 { get; private set; }
      public double X2 { get; private set; }
      public double Y1 { get; private set; }
      public double Y2 { get; private set; }

      public Rectangle(double x1, double x2, double y1, double y2)
      {
         X1 = x1;
         X2 = x2;
         Y1 = y1;
         Y2 = y2;
      }
   }
}