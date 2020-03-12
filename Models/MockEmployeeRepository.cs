using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employssList;

        public MockEmployeeRepository()
        {
            _employssList = new List<Employee>
            {
                new Employee() { Id=1, Name="Ammad", Email="ammadmughal567@gmail.com", Department="IT" },
                new Employee() { Id=2, Name="Hannan", Email="ammadmughal567@gmail.com", Department="IT" },
                new Employee() { Id=3, Name="Nadir", Email="ammadmughal567@gmail.com", Department="IT" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employssList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employssList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
