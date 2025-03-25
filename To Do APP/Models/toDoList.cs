using System.ComponentModel.DataAnnotations;
namespace To_Do_APP.Models
{
    public class toDoList
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
