using System.ComponentModel.DataAnnotations;

namespace TodoApp_part_1.Models
{
    public class TodoListModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}
