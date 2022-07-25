using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ems.Models
{
    
    [Table("empDb",Schema="public")]
    public class Employee{
        [Key]
        public int Id { get; set; }
        public String? Name { get; set; }

        public String? City { get; set; }

    }
}