using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RectangleSelector.DTOs;
using RectangleSelector.Models;

namespace RectangleSelector.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class RectanglesController : ControllerBase
   {
      private readonly RectangleSelectorDBContext _context;

      public RectanglesController(RectangleSelectorDBContext context)
      {
         _context = context;
      }

      [HttpGet]
      public async Task<ActionResult<IEnumerable<RectangleDTO>>> GetRectangles(double x1, double x2, double y1, double y2)
      {
         if (x2 > x1 && y2 > y1)
         {
            // as per your request to design the controller for a large number of rows, query readability is sacrificed for complete server-side evaluation
            // I focused on intersecting edges, not overlapping i.e. a larger rectangle completely covering a smaller rectangle does not count as intersecting
            var rectangles = await _context.Rectangles.Where(r => (x1 < r.X1 || x2 > r.X2 || y1 < r.Y1 || y2 > r.Y2)).
                                                                              Where(r => (x1 > r.X1 && x1 < r.X2) || (x2 > r.X1 && x2 < r.X2) || (y1 > r.Y1 && y1 < r.Y2) || (y2 > r.Y1 && y2 < r.Y2)).
                                                                              Select(r => new RectangleDTO(r.X1, r.X2, r.Y1, r.Y2)).ToListAsync();
            if (rectangles.Count == 0)
            {
               return NotFound();
            }
            return rectangles;
         }
         else
         {
            return BadRequest("Please enter coordinates in ascending order i.e. X1, X2, Y1, Y2 where X2 > X1 and Y2 > Y1");
         }
      }

      [HttpPost]
      public async Task<ActionResult<RectangleDTO>> CreateRectangle(double x1, double x2, double y1, double y2)
      {
         if (x2 > x1 && y2 > y1)
         {
            try
            {
               var r = new Rectangle(x1, x2, y1, y2);
               _context.Rectangles.Add(r);
               await _context.SaveChangesAsync();

               return new RectangleDTO(r.X1, r.X2, r.Y1, r.Y2);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
               return BadRequest("A Rectangle with these coordinates already exists");
            }
         }
         else
         {
            return BadRequest("Please enter coordinates in ascending order i.e. X1, X2, Y1, Y2 where X2 > X1 and Y2 > Y1");
         }
      }
   }
}