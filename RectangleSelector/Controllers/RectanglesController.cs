using Microsoft.AspNetCore.Mvc;
using RectangleSelector.Data;
using RectangleSelector.Data.DTOs;

namespace RectangleSelector.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RectanglesController : ControllerBase
{
   private readonly IRectangleRepository _rectangleRepository;

   public RectanglesController(IRectangleRepository repository)
   {
      _rectangleRepository = repository;
   }

   [HttpGet]
   public async Task<ActionResult<IEnumerable<RectangleDTO>>> GetRectangles(double s_x1, double s_y1, double s_x2, double s_y2)
   {
      var rectangles = await _rectangleRepository.GetIntersectingRectangles(s_x1, s_y1, s_x2, s_y2);
      if (!rectangles.Any())
      {
         return NotFound();
      }
      return rectangles.ToList();
   }

   [HttpPost]
   public async Task<ActionResult<RectangleDTO>> CreateRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
   {
      try
      {
         var newRectangle = await _rectangleRepository.CreateNewRectangle(x1, y1, x2, y2, x3, y3, x4, y4);
         return newRectangle;
      }
      catch (Microsoft.EntityFrameworkCore.DbUpdateException)
      {
         return BadRequest("A Rectangle with these coordinates already exists");
      }
   }

   [HttpPost]
   public async Task<ActionResult> DeleteRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
   {
      var isDeleted = await _rectangleRepository.DeleteRectangle(x1, y1, x2, y2, x3, y3, x4, y4);
      if (isDeleted)
      {
         return Ok();
      }
      return NotFound();
   }
}