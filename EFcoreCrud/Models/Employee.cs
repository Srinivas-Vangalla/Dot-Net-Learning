using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFcoreCrud.Models
{
    [ Table("employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Team { get; set; }

    }
}
