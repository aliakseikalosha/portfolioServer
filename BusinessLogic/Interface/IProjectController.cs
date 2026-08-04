using BusinessLogic.Models;
using Database;

namespace BusinessLogic
{
    public interface IProjectController
    {
        public Task<Project[]> GetAll(SQLLiteContex context);
        public Task<Project[]> GetByType(ProjectType type, SQLLiteContex context);
        public Task<Project?> GetById(int id, SQLLiteContex context);
    }
}
