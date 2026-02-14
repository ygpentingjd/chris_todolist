using System.ComponentModel.DataAnnotations;

namespace chris_todolist.Models {
    public class Todo {
        [Key]
        public Guid Id {get; set;} = Guid.NewGuid();

        [Required]
        public string title {get; set;} = string.Empty;

        public bool IsCompleted {get; set;} = false;

        public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    }
}