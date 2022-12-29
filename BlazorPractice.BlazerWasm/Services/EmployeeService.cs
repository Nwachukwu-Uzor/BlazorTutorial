using BlazorPractice.BlazerWasm.Contracts;
using BlazorPractice.BlazerWasm.Models;

namespace BlazorPractice.BlazerWasm.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> employees;
        public EmployeeService()
        {
            employees = new List<Employee>
            {
                  new Employee
                {
                    Id = 1,
                    Name = "Jack Howard",
                    Title = "Software Engineer",
                    Department = "IT / Engineering",
                    UserId = Guid.NewGuid(),
                },
                 new Employee
                {
                    Id = 2,
                    Name = "Michelle Brown",
                    Title = "Marketer",
                    Department = "Sales",
                    UserId = Guid.NewGuid(),
                },
                 new Employee
                {
                    Id = 3,
                    Name = "David Orlenna",
                    Title = "HR Manager",
                    Department = "Personnel",
                    UserId = Guid.NewGuid(),
                }
            };
        }
        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(employee => employee.Id == id);
        }
    }
}
