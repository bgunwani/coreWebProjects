using coreMvcApp.Models;

namespace coreMvcApp.Repositories
{
    public static class EmployeeRepository
    {
        private static List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "King Kochhar", Salary = 12000 },
            new Employee { Id = 2, Name = "John Smith", Salary = 10000 },
            new Employee { Id = 3, Name = "Sarah Bowling", Salary = 30000 }
        };

        public static List<Employee> GetAll() => _employees;

        public static Employee? GetById(int id) => _employees.FirstOrDefault(x => x.Id == id);

        public static void Add(Employee employee)
        {
            employee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(employee);
        }
        public static void Update(Employee employee)
        {
            var existingEmployee = GetById(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Salary = employee.Salary;
            }
        }

    }
}
