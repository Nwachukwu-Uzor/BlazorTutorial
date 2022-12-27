using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BlazorPractice.BlazerWasm.Models
{
    public class User
    {
        [Required(ErrorMessage = "Fullname is required")]
        [MinLength(10, ErrorMessage = "Fullname must be at least 10 cha")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Employee Number field is required")]
        [Range(20, 50, ErrorMessage = "Employee Number should be between 20 and 50")]
        public int EmployeeNumber { get; set; }
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address")]
        public string Email { get; set; }
    }
}
