using Microsoft.AspNetCore.Mvc;
using RectangleSelector;
using RectangleSelector.Controllers;
using RectangleSelector.Models;

namespace RectangleSelectorTest.CreateTest
{
   public class CreateRectangleTest
   {
      [Theory]
      [MemberData(nameof(PositiveCasesData.GetTestData), MemberType = typeof(PositiveCasesData))]
      public async void PositiveCases(CreateDataWrapper testData)
      {
         using var context = new TestRectangleSelectorDBContext();
         var controller = new RectanglesController(context);
         var newRectangle = await controller.CreateRectangle(testData.X1, testData.X2, testData.Y1, testData.Y2);
         Assert.Equal(testData.Result.Value, newRectangle.Value);
         //if (newRectangle.Result is CreatedAtActionResult result)
         //{
         //   Assert.Equal(testData.Result.Result, result.Value);
         //}
      }

      [Theory]
      [MemberData(nameof(IncorrectInputCasesData.GetTestData), MemberType = typeof(IncorrectInputCasesData))]
      public async void IncorrectInputCases(CreateDataWrapper testData)
      {
         using var context = new TestRectangleSelectorDBContext();
         var controller = new RectanglesController(context);
         context.Rectangles.Add(new Rectangle(7, 12, 3, 8));
         context.SaveChanges();
         var newRectangle = await controller.CreateRectangle(testData.X1, testData.X2, testData.Y1, testData.Y2);
         Assert.IsType<BadRequestObjectResult>(newRectangle.Result);
      }
   }
}