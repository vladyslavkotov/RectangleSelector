using Microsoft.AspNetCore.Mvc;

namespace RectangleSelectorTest.GetTest
{
   public class NegativeCasesData
   {
      public static IEnumerable<object[]> GetTestData()
      {
         //completely inside
         yield return new object[] { new GetDataWrapper(8, 10, 4, 5, new NotFoundResult()) };
         //completely outside
         yield return new object[] { new GetDataWrapper(5, 15, 1, 10, new NotFoundResult()) };
         // touches on 1 side
         yield return new object[] { new GetDataWrapper(2, 7, 3, 8, new NotFoundResult()) };
         yield return new object[] { new GetDataWrapper(12, 16, 3, 8, new NotFoundResult()) };
         yield return new object[] { new GetDataWrapper(7, 12, -2, 2, new NotFoundResult()) };
         yield return new object[] { new GetDataWrapper(7, 12, 8, 12, new NotFoundResult()) };
         // does not touch at all
         yield return new object[] { new GetDataWrapper(1, 3, 3, 8, new NotFoundResult()) };
         yield return new object[] { new GetDataWrapper(15, 20, 3, 8, new NotFoundResult()) };
         yield return new object[] { new GetDataWrapper(7, 12, -5, 1, new NotFoundResult()) };
         yield return new object[] { new GetDataWrapper(7, 12, 10, 14, new NotFoundResult()) };
      }
   }
}