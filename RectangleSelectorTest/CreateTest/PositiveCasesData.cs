using Microsoft.AspNetCore.Mvc;
using RectangleSelector.DTOs;

namespace RectangleSelectorTest.CreateTest
{
   public class PositiveCasesData
   {
      public static IEnumerable<object[]> GetTestData()
      {
         yield return new object[] { new CreateDataWrapper(6, 8, 3, 8, new ActionResult<RectangleDTO>(new RectangleDTO(6, 8, 3, 8))) };
         yield return new object[] { new CreateDataWrapper(1, 5, 2, 7, new ActionResult<RectangleDTO>(new RectangleDTO(1, 5, 2, 7))) };
      }
   }
}