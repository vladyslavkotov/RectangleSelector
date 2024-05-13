 using Microsoft.AspNetCore.Mvc;
using RectangleSelector.Data.DTOs;

namespace RectangleSelectorTest.GetTest
{
    public class GetDataWrapper
   {
      public double X1 { get; }
      public double X2 { get; }
      public double Y1 { get; }
      public double Y2 { get; }
      public IEnumerable<RectangleDTO> Result { get; }

      public GetDataWrapper(double x1, double x2, double y1, double y2, IEnumerable<RectangleDTO> result)
      {
         X1 = x1;
         X2 = x2;
         Y1 = y1;
         Y2 = y2;
         Result = result;
      }
   }
}