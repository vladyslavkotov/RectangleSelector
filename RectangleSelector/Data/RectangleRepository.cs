using Microsoft.EntityFrameworkCore;
using RectangleSelector.Data.DTOs;
using RectangleSelector.Data.Models;

namespace RectangleSelector.Data;

public class RectangleRepository : IRectangleRepository
{
   private readonly RectangleSelectorDBContext _context;

   public RectangleRepository(RectangleSelectorDBContext context)
   {
      _context = context;
   }

   public async Task<IEnumerable<RectangleDTO>> GetIntersectingRectangles(double s_x1, double s_y1, double s_x2, double s_y2)
   {
      var rectangles = await _context.Rectangles.Where(r =>

      (s_x1 - s_x2) * (r.Y1 - r.Y2) - (s_y1 - s_y2) * (r.X1 - r.X2) != 0 &&

      ((s_x1 - r.X1) * (r.Y1 - r.Y2) - (s_y1 - r.Y1) * (r.X1 - r.X2)) / ((s_x1 - s_x2) * (r.Y1 - r.Y2) - (s_y1 - s_y2) * (r.X1 - r.X2)) <= 1 &&
      ((s_x1 - r.X1) * (r.Y1 - r.Y2) - (s_y1 - r.Y1) * (r.X1 - r.X2)) / ((s_x1 - s_x2) * (r.Y1 - r.Y2) - (s_y1 - s_y2) * (r.X1 - r.X2)) >= 0 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y1) - (s_y1 - s_y2) * (s_x1 - r.X1)) / ((s_x1 - s_x2) * (r.Y1 - r.Y2) - (s_y1 - s_y2) * (r.X1 - r.X2))) <= 1 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y1) - (s_y1 - s_y2) * (s_x1 - r.X1)) / ((s_x1 - s_x2) * (r.Y1 - r.Y2) - (s_y1 - s_y2) * (r.X1 - r.X2))) >= 0

      ||

      (s_x1 - s_x2) * (r.Y2 - r.Y3) - (s_y1 - s_y2) * (r.X2 - r.X3) != 0 &&

      ((s_x1 - r.X2) * (r.Y2 - r.Y3) - (s_y1 - r.Y2) * (r.X2 - r.X3)) / ((s_x1 - s_x2) * (r.Y2 - r.Y3) - (s_y1 - s_y2) * (r.X2 - r.X3)) <= 1 &&
      ((s_x1 - r.X2) * (r.Y2 - r.Y3) - (s_y1 - r.Y2) * (r.X2 - r.X3)) / ((s_x1 - s_x2) * (r.Y2 - r.Y3) - (s_y1 - s_y2) * (r.X2 - r.X3)) >= 0 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y2) - (s_y1 - s_y2) * (s_x1 - r.X2)) / ((s_x1 - s_x2) * (r.Y2 - r.Y3) - (s_y1 - s_y2) * (r.X2 - r.X3))) <= 1 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y2) - (s_y1 - s_y2) * (s_x1 - r.X2)) / ((s_x1 - s_x2) * (r.Y2 - r.Y3) - (s_y1 - s_y2) * (r.X2 - r.X3))) >= 0

      ||

      (s_x1 - s_x2) * (r.Y3 - r.Y4) - (s_y1 - s_y2) * (r.X3 - r.X4) != 0 &&

      ((s_x1 - r.X3) * (r.Y3 - r.Y4) - (s_y1 - r.Y3) * (r.X3 - r.X4)) / ((s_x1 - s_x2) * (r.Y3 - r.Y4) - (s_y1 - s_y2) * (r.X3 - r.X4)) <= 1 &&
      ((s_x1 - r.X3) * (r.Y3 - r.Y4) - (s_y1 - r.Y3) * (r.X3 - r.X4)) / ((s_x1 - s_x2) * (r.Y3 - r.Y4) - (s_y1 - s_y2) * (r.X3 - r.X4)) >= 0 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y3) - (s_y1 - s_y2) * (s_x1 - r.X3)) / ((s_x1 - s_x2) * (r.Y3 - r.Y4) - (s_y1 - s_y2) * (r.X3 - r.X4))) <= 1 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y3) - (s_y1 - s_y2) * (s_x1 - r.X3)) / ((s_x1 - s_x2) * (r.Y3 - r.Y4) - (s_y1 - s_y2) * (r.X3 - r.X4))) >= 0

      ||

      (s_x1 - s_x2) * (r.Y4 - r.Y1) - (s_y1 - s_y2) * (r.X4 - r.X1) != 0 &&

      ((s_x1 - r.X4) * (r.Y4 - r.Y1) - (s_y1 - r.Y4) * (r.X4 - r.X1)) / ((s_x1 - s_x2) * (r.Y4 - r.Y1) - (s_y1 - s_y2) * (r.X4 - r.X1)) <= 1 &&
      ((s_x1 - r.X4) * (r.Y4 - r.Y1) - (s_y1 - r.Y4) * (r.X4 - r.X1)) / ((s_x1 - s_x2) * (r.Y4 - r.Y1) - (s_y1 - s_y2) * (r.X4 - r.X1)) >= 0 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y4) - (s_y1 - s_y2) * (s_x1 - r.X4)) / ((s_x1 - s_x2) * (r.Y4 - r.Y1) - (s_y1 - s_y2) * (r.X4 - r.X1))) <= 1 &&
      -(((s_x1 - s_x2) * (s_y1 - r.Y4) - (s_y1 - s_y2) * (s_x1 - r.X4)) / ((s_x1 - s_x2) * (r.Y4 - r.Y1) - (s_y1 - s_y2) * (r.X4 - r.X1))) >= 0

      ).Select(r => new RectangleDTO(r.X1, r.Y1, r.X2, r.Y2, r.X3, r.Y3, r.X4, r.Y4)).ToListAsync();
      return rectangles;
   }

   public async Task<RectangleDTO> CreateNewRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
   {
      var r = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);
      _context.Rectangles.Add(r);
      await _context.SaveChangesAsync();
      return new RectangleDTO(r.X1, r.Y1, r.X2, r.Y2, r.X3, r.Y3, r.X4, r.Y4);
   }

   public async Task<bool> DeleteRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
   {
      var rect = await _context.Rectangles.SingleOrDefaultAsync(r => r.X1 == x1 && r.Y1 == y1 && r.X2 == x2 && r.Y2 == y2 && r.X3 == x3 && r.Y3 == y3 && r.X4 == x4 && r.Y4 == y4);
      if (rect is not null)
      {
         _context.Rectangles.Remove(rect);
         await _context.SaveChangesAsync();
         return true;
      }
      return false;
   }
}