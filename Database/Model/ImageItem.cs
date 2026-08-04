namespace Database.Model
{
    /// <summary>
    /// Model describe image url
    /// </summary>
    public class ImageItem
    {
        public int Id { get; set; }
        public required int ProjectId { get; set; }
        public required string ImageURL { get; set; }
    }
}