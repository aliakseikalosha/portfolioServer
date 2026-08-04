using BusinessLogic.Models;

namespace BusinessLogic
{
    public interface IProjectController
    {
        public Project[] GetAll();
        public Project[] GetByType(ProjectType type);
        public Project GetById(int id);
    }
}
