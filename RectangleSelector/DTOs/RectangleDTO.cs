namespace RectangleSelector.DTOs
{
   public record RectangleDTO
   {
      public double X1 { get; private set; }
      public double X2 { get; private set; }
      public double Y1 { get; private set; }
      public double Y2 { get; private set; }

      public RectangleDTO(double x1, double x2, double y1, double y2)
      {
         X1 = x1;
         X2 = x2;
         Y1 = y1;
         Y2 = y2;
      }
   }
}