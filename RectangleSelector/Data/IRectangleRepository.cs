using RectangleSelector.Data.DTOs;

namespace RectangleSelector.Data;

public interface IRectangleRepository
{
   public Task<IEnumerable<RectangleDTO>> GetIntersectingRectangles(double s_x1, double s_y1, double s_x2, double s_y2);

   public Task<RectangleDTO> CreateNewRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);

   public Task<bool> DeleteRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);
}