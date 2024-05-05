namespace RectangleSelector
{
   public class Program
   {
      public static void Main(string[] args)
      {
         // TODO: please run migrations first
         var builder = WebApplication.CreateBuilder(args);

         builder.Services.AddDbContext<RectangleSelectorDBContext>();
         builder.Services.AddControllers();
         builder.Services.AddEndpointsApiExplorer();
         builder.Services.AddSwaggerGen();

         var app = builder.Build();

         if (app.Environment.IsDevelopment())
         {
            app.UseSwagger();
            app.UseSwaggerUI();
         }

         app.UseHttpsRedirection();

         app.UseAuthorization();

         app.MapControllers();

         app.Run();
      }
   }
}