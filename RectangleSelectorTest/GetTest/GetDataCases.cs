using RectangleSelector.Data.DTOs;

namespace RectangleSelectorTest.GetTest
{
   public class GetDataCases
   {
      public static IEnumerable<object[]> GetTestData()
      {
         //intersects on 1 side
         yield return new object[] { new GetDataWrapper(8, 2, 5, 5, new List<RectangleDTO> { new RectangleDTO(5, 2, 8, 6, 4, 9, 1, 5) }) };
         yield return new object[] { new GetDataWrapper(5, 5, 2, 8, new List<RectangleDTO> { new RectangleDTO(5, 2, 8, 6, 4, 9, 1, 5) }) };
         yield return new object[] { new GetDataWrapper(4, 6, 7, 10, new List<RectangleDTO> { new RectangleDTO(5, 2, 8, 6, 4, 9, 1, 5) }) };
         yield return new object[] { new GetDataWrapper(4, 6, 2, 3, new List<RectangleDTO> { new RectangleDTO(5, 2, 8, 6, 4, 9, 1, 5) }) };
         //intersects on 2 sides
         yield return new object[] { new GetDataWrapper(2, 3, 7, 10, new List<RectangleDTO> { new RectangleDTO(5, 2, 8, 6, 4, 9, 1, 5) }) };
         yield return new object[] { new GetDataWrapper(7, 2, 1, 8, new List<RectangleDTO> { new RectangleDTO(5, 2, 8, 6, 4, 9, 1, 5) }) };
         // inside
         yield return new object[] { new GetDataWrapper(5, 3, 7, 6, new List<RectangleDTO> { }) };
         yield return new object[] { new GetDataWrapper(3, 5, 5, 7, new List<RectangleDTO> { }) };
         // outside
         yield return new object[] { new GetDataWrapper(8, 2, 9, 5, new List<RectangleDTO> { }) };
         yield return new object[] { new GetDataWrapper(3,1,0,5, new List<RectangleDTO> { }) };
      }
   }
}