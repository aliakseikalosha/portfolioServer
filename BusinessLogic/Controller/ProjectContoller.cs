using BusinessLogic.Models;
using Database;
using Database.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class ProjectController : IProjectController
    {

        public async Task<Project[]> GetAll(SQLLiteContex context)
        {
            return await context.Projects.AsAsyncEnumerable().Select(Convert).ToArrayAsync();
        }

        public async Task<Project?> GetById(int id, SQLLiteContex context)
        {
            var projectItem = await context.Projects.FindAsync(id);
            if (projectItem == null)
            {
                return null;
            }
            return Convert(projectItem);
        }

        public async Task<Project[]> GetByType(ProjectType type, SQLLiteContex context)
        {
            int typeId = (int)type;
            return await context.Projects.Include(c => c.Type).Where(c => c.Type.Id == typeId).AsAsyncEnumerable().Select(Convert).ToArrayAsync();
        }

        private Project Convert(ProjectItem item)
        {
            return new Project(item.Id, item.Name, item.Description, item.ShortDescription, item.ThumbnailURL);
        }
    }
}