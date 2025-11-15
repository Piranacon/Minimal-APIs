using EmployeeExample.Models;

namespace EmployeeExample;

public static class EmployeeManager
{

    private static List<Employee> _employees = [];

    private static int GetEmployeeIndex(int id)
    {
        var employeeIndex = _employees.FindIndex(x => x.Id == id);


        if (employeeIndex != -1)
            return employeeIndex;

        throw new ArgumentException($"Employee with Id {id} does not exist");

    }

    public static void Create(Employee employee)
    {
        _employees.Add(employee);
    }
    public static void Update(Employee employee)
    {
        _employees[GetEmployeeIndex(employee.Id)] = employee;
    }
    public static void ChangeName(int id, string name)
    {
        _employees[GetEmployeeIndex(id)].Name = name;
    }
    public static void Delete(int id)
    {
        _employees.RemoveAt(GetEmployeeIndex(id));
    }
    public static Employee Get(int id)
    {
        var employee = _employees.FirstOrDefault(x => x.Id == id);

        return employee ?? throw new ArgumentException("Employee Id invalid");
    }
}