using Microsoft.AspNetCore.Mvc;

namespace RectangleSelectorTest.CreateTest
{
   public class IncorrectInputCasesData
   {
      public static IEnumerable<object[]> GetTestData()
      {
         //incorrect input
         yield return new object[] { new CreateDataWrapper(10, 2, 4, 5, new BadRequestResult()) };
         yield return new object[] { new CreateDataWrapper(2, 5, 8, 3, new BadRequestResult()) };
         // duplicate rectangle violates unique index
         yield return new object[] { new CreateDataWrapper(7, 12, 3, 8, new BadRequestResult()) };
      }
   }
}