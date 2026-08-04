using BusinessLogic.Models;

namespace Database.Model
{
    /// <summary>
    /// Model describe type of a project 
    /// </summary>
    public class TypeItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<ProjectItem> Project { get; } = null!;
    }
}