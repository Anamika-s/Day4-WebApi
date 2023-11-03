using WebAppDemo.Models;

namespace WebAppWithLayers.IRepository
{
    public interface IEmplyeeRepo
    {
       void CreateEmployee (Employee employee);
        int DeleteEmployee(int id);
        int EditEmployee(int id, Employee employee);
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
