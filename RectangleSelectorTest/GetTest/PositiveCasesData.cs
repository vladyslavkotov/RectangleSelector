using Microsoft.AspNetCore.Mvc;
using RectangleSelector.DTOs;

namespace RectangleSelectorTest.GetTest
{
   public class PositiveCasesData
   {
      public static IEnumerable<object[]> GetTestData()
      {
         //intersects on 1 side, 2nd dimension is the same
         yield return new object[] { new GetDataWrapper(6, 8, 3, 8, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(10, 20, 3, 8, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(7, 12, 2, 5, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(7, 12, 6, 14, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         // intersects on 1 side, 2nd dimension is smaller
         yield return new object[] { new GetDataWrapper(6, 8, 4, 7, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(10, 20, 4, 7, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(8, 10, 2, 5, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(8, 10, 6, 14, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         // intersects on 2 sides, goes through
         yield return new object[] { new GetDataWrapper(5, 14, 4, 7, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(9, 11, 2, 10, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         // intersects on 2 sides, goes over
         yield return new object[] { new GetDataWrapper(5, 14, 4, 11, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(5, 14, 2, 7, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(5, 11, 2, 10, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(8, 15, 2, 10, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         // intersects on each corner
         yield return new object[] { new GetDataWrapper(6, 8, 1, 6, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(10, 20, 1, 6, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(6, 8, 5, 10, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
         yield return new object[] { new GetDataWrapper(10, 20, 5, 10, new ActionResult<IEnumerable<RectangleDTO>>(new List<RectangleDTO> { new RectangleDTO(7, 12, 3, 8) })) };
      }
   }
}