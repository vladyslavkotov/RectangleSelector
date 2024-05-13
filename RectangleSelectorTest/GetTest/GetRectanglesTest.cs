using RectangleSelector.Data;

namespace RectangleSelectorTest.GetTest;

public class GetRectanglesTest
{
   [Theory]
   [MemberData(nameof(GetDataCases.GetTestData), MemberType = typeof(GetDataCases))]
   public async void PositiveCases(GetDataWrapper testData)
   {
      using var context = new RectangleSelectorDBContext();
      //context.Rectangles.Add(new Rectangle(1, 5, 2, 8, 6, 4, 9, 1, 5));
      //context.Rectangles.Add(new Rectangle(2, 10, 10, 15, 13, 13, 16, 8, 13));
      //context.SaveChanges();
      var repository = new RectangleRepository(context);

      var intersectingRectangles = await repository.GetIntersectingRectangles(testData.X1, testData.X2, testData.Y1, testData.Y2);
      Assert.Equal(testData.Result, intersectingRectangles.ToList());
   }
}