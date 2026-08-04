using Database;

namespace BusinessLogic
{
    public class ImageContollerMock : IImageController
    {
        public async Task<string[]> GetImage(int projectId, SQLLiteContex context)
        {
            return [.. Enumerable.Range(0, 3).Select(c => "example.png")];
        }
    }
}