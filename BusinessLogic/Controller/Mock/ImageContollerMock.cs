namespace BusinessLogic
{
    public class ImageContollerMock : IImageController
    {
        public string[] GetImage(int projectId)
        {
            return [.. Enumerable.Range(0, 3).Select(c => "example.png")];
        }
    }
}