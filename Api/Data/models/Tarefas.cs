using System.ComponentModel.DataAnnotations;

namespace Crud.Api.Models
{
    public class Tarefas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Tarefa { get; set; }

    }


}