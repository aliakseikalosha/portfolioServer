using BusinessLogic;
using Database;

namespace Endpoints
{
    public static class ImageEndpoints
    {
        public static void Map(WebApplication app)
        {
            var ic = app.Services.GetRequiredService<IImageController>();
            app.MapGet("/image/{projectId:int}", ic.GetImage).WithName(nameof(ic.GetImage));
        }
    }
}