namespace Database.Model
{
    /// <summary>
    /// Model to describe all progect data
    /// </summary>
    public class PojectItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ThumbnailURL { get; set; }
        public required string Description { get; set; }
        public required string ShortDescription { get; set; }
        public required int TypeId { get; set; }
    }
}