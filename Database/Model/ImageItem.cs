using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Model
{
    /// <summary>
    /// Model describe image url
    /// </summary>
    public class ImageItem
    {
        public int Id { get; set; }
        public required ProjectItem Project { get; set; }
        public required string ImageURL { get; set; }
    }
}