using BusinessLogic;

namespace Endpoints
{
    public static class ProjectEndpoints
    {
        private static string GetUrl(string withParams = "") => "/project" + withParams;
        public static void Map(WebApplication app)
        {
            var pc = app.Services.GetRequiredService<IProjectController>();
            app.MapGet(GetUrl(), pc.GetAll).WithName(nameof(pc.GetAll));
            app.MapGet(GetUrl("/{id:int}"), pc.GetById).WithName(nameof(pc.GetById));
            app.MapGet(GetUrl("/{type}"), pc.GetByType).WithName(nameof(pc.GetByType));
        }
    }
}