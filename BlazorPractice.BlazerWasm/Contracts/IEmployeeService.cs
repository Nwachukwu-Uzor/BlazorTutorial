using BlazorPractice.BlazerWasm.Models;

namespace BlazorPractice.BlazerWasm.Contracts
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(int id);
    }
}
