using Microsoft.AspNetCore.Mvc;

namespace RectangleSelectorTest.GetTest
{
   public class IncorrectInputCasesData
   {
      public static IEnumerable<object[]> GetTestData()
      {
         //incorrect input
         yield return new object[] { new GetDataWrapper(10, 2, 4, 5, new BadRequestResult()) };
         yield return new object[] { new GetDataWrapper(2, 5, 8, 3, new BadRequestResult()) };
      }
   }
}