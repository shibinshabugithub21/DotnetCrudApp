using CRUD.Data;
using CRUD.Models;
using CRUD.Models.Entities;
using Microsoft.AspNetCore.Http;    
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        // Connect the Database

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // endpoint /opertion

        //Read

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allemployees = dbContext.Employees.ToList();

            return Ok(allemployees);
        }


        // get a specific employee by using Id

        [HttpGet]
        [Route("{id:guid}")]  // used fo 
        public IActionResult GetEmployeeById(Guid id)
        {
          var employee =  dbContext.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {

            // used the dto file to asa parametre for add the empolyee details 
            var employeeEnity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary,
            };
            dbContext.Employees.Add(employeeEnity);
            dbContext.SaveChanges();
            return Ok(employeeEnity);
            
        }

        // update employee
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var updateEmployee= dbContext.Employees.Find(id);  
            if (updateEmployee == null)
            {
                return NotFound();
            }
           updateEmployee.Name= updateEmployeeDto.Name;
            updateEmployee.Email= updateEmployeeDto.Email;
            updateEmployee.Phone= updateEmployeeDto.Phone;
            updateEmployee.Salary= updateEmployeeDto.Salary;

            dbContext.SaveChanges();
            return Ok(updateEmployee);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteEmployee(Guid id)
        {
            var deleteEmployee = dbContext.Employees.Find(id);

            if(deleteEmployee == null)
            {
                return NoContent();
            }
            dbContext.Employees.Remove(deleteEmployee);
            return Ok();
        }

    }
}
