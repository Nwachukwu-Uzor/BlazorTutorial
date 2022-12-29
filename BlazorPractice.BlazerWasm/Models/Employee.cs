
using System.ComponentModel.DataAnnotations;
namespace BlazorPractice.BlazerWasm.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        [Required]
        [MinLength(15)]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        public string Title { get; set; }
        public string Department { get; set; }
    }
}
