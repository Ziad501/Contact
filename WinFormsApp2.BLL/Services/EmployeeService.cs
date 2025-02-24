using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entities;

namespace WinFormsApp2.BLL.Services
{
	public class EmployeeService
	{
		private readonly ApplicationDbContext _context;

		public EmployeeService(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<Employee> GetAllEmployees()
		{
			return _context.Employees.ToList();
		}

		public void AddEmployee(Employee employee)
		{
			_context.Employees.Add(employee);
			_context.SaveChanges();
		}

		public void UpdateEmployee(Employee employee)
		{
			_context.Employees.Update(employee);
			_context.SaveChanges();
		}

		public void DeleteEmployee(int id)
		{
			var employee = _context.Employees.Find(id);
			if (employee != null)
			{
				_context.Employees.Remove(employee);
				_context.SaveChanges();
			}
		}
	}
}
