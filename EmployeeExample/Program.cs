using EmployeeExample;
using EmployeeExample.Models;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/employees/{id}", (int id) =>
{
    var employee = EmployeeManager.Get(id);
    return Results.Ok(employee);
});
app.MapPost("/employees", (Employee employee) =>
{
    EmployeeManager.Create(employee);
    return Results.Created();
});
app.MapPut("/employees", (Employee employee) =>
{
    EmployeeManager.Update(employee);
    return Results.Ok();
});
app.MapPatch("/updateEmployeeName", (Employee employee) =>
{
    EmployeeManager.ChangeName(employee.Id, employee.Name);
    return Results.Ok();
});

app.MapDelete("/employees/{id}", (int id) =>
{
    EmployeeManager.Delete(id);
    return Results.Ok();
});

app.Run();
