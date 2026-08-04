using BusinessLogic.Models;

namespace BusinessLogic
{
    public class ProjectControllerMock : IProjectController
    {
        public Project[] GetAll()
        {
            return [.. Enumerable.Range(0, 10).Select(i => CreateProject(i))];
        }

        public Project GetById(int id)
        {
            return CreateProject(id);
        }

        public Project[] GetByType(ProjectType type)
        {
            return [.. GetAll().Where(c => c.Id % (int)type == 0)];
        }

        private Project CreateProject(int id) => new Project(id, $"Name:{id}", $"Description:{id}", $"ShortDescription:{id}");
    }
}