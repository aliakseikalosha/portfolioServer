using Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class ImageContoller : IImageController
    {

        public async Task<string[]> GetImage(int projectId, SQLLiteContex context)
        {
            return await context.Images.Where(c => c.Project.Id == projectId).Select(c => c.ImageURL).ToArrayAsync();
        }
    }
}