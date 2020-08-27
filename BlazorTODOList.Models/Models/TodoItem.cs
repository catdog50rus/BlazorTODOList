using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTODOList.Models.Models
{
    [Table("todos")]
    public class TodoItem
    {
        [Key]
        public int Id { get; private set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
