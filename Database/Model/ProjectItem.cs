namespace Database.Model
{
    /// <summary>
    /// Model to describe all progect data
    /// </summary>
    public class ProjectItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ThumbnailURL { get; set; }
        public required string Description { get; set; }
        public required string ShortDescription { get; set; }
        public required TypeItem Type { get; set; }
        public ICollection<ImageItem> Images { get; } = null!;
    }
}