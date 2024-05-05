using Microsoft.AspNetCore.Mvc;
using RectangleSelector.DTOs;

namespace RectangleSelectorTest.CreateTest
{
   public class CreateDataWrapper
   {
      public double X1 { get; }
      public double X2 { get; }
      public double Y1 { get; }
      public double Y2 { get; }
      public ActionResult<RectangleDTO> Result { get; }

      public CreateDataWrapper(double x1, double x2, double y1, double y2, ActionResult<RectangleDTO> result)
      {
         X1 = x1;
         X2 = x2;
         Y1 = y1;
         Y2 = y2;
         Result = result;
      }
   }
}