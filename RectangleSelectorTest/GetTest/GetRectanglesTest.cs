using Microsoft.AspNetCore.Mvc;
using RectangleSelector;
using RectangleSelector.Controllers;
using RectangleSelector.Models;

namespace RectangleSelectorTest.GetTest
{
   public class GetRectanglesTest
   {
      [Theory]
      [MemberData(nameof(PositiveCasesData.GetTestData), MemberType = typeof(PositiveCasesData))]
      public async void PositiveCases(GetDataWrapper testData)
      {
         using var context = new TestRectangleSelectorDBContext();
         var controller = new RectanglesController(context);
         context.Rectangles.Add(new Rectangle(7, 12, 3, 8));
         context.SaveChanges();
         var intersectingRectangles = await controller.GetRectangles(testData.X1, testData.X2, testData.Y1, testData.Y2);
         Assert.Equal(testData.Result.Value, intersectingRectangles.Value.ToList());
      }

      [Theory]
      [MemberData(nameof(NegativeCasesData.GetTestData), MemberType = typeof(NegativeCasesData))]
      public async void NegativeCases(GetDataWrapper testData)
      {
         using var context = new TestRectangleSelectorDBContext();
         var controller = new RectanglesController(context);
         context.Rectangles.Add(new Rectangle(7, 12, 3, 8));
         context.SaveChanges();
         var intersectingRectangles = await controller.GetRectangles(testData.X1, testData.X2, testData.Y1, testData.Y2);
         Assert.IsType<NotFoundResult>(intersectingRectangles.Result);
      }

      [Theory]
      [MemberData(nameof(IncorrectInputCasesData.GetTestData), MemberType = typeof(IncorrectInputCasesData))]
      public async void IncorrectInputCases(GetDataWrapper testData)
      {
         using var context = new TestRectangleSelectorDBContext();
         var controller = new RectanglesController(context);
         context.Rectangles.Add(new Rectangle(7, 12, 3, 8));
         context.SaveChanges();
         var intersectingRectangles = await controller.GetRectangles(testData.X1, testData.X2, testData.Y1, testData.Y2);
         Assert.IsType<BadRequestObjectResult>(intersectingRectangles.Result);
      }
   }
}