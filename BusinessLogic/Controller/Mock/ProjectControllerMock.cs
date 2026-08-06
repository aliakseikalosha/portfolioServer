using BusinessLogic.Models;
using Database;

namespace BusinessLogic
{
    public class ProjectControllerMock : IProjectController
    {
        public async Task<Project[]> GetAll(SQLLiteContex context)
        {
            return [.. Enumerable.Range(0, 10).Select(i => CreateProject(i))];
        }

        public async Task<Project?> GetById(int id, SQLLiteContex context)
        {
            return CreateProject(id);
        }

        public async Task<Project[]> GetByType(ProjectType type, SQLLiteContex context)
        {
            return [.. (await GetAll(context)).Where(c => c.Id % (int)type == 0)];
        }

        private Project CreateProject(int id) => new(id, $"Name:{id}", $"Description:{id}", $"ShortDescription:{id}", "example.png");
    }
}