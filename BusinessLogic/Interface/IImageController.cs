using Database;

namespace BusinessLogic
{
    public interface IImageController
    {
        public Task<string[]> GetImage(int projectId, SQLLiteContex context);
    }
}
