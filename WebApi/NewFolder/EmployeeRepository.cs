using WebAppDemo.Context;
using WebAppDemo.Models;
using WebAppWithLayers.IRepository;

namespace WebAppWithLayers
{
    public class EmployeeRepository : IEmplyeeRepo
    {
        EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

        }

        public int DeleteEmployee(int id)
        {
            var emp = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
                return 1;
            }
            else
                return 0;
        }
    

        public int EditEmployee(int id, Employee employee)
        {
            var emp = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                emp.Dept = employee.Dept;
                emp.Salary = employee.Salary;
                
                _context.SaveChanges();
                return 1;
            }
            else
                return 0;

        }

        public List<Employee> GetAllEmployees()
        {
           return _context.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
