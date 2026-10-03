namespace CRUD.Models
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; } // here the required means if the name will e reuired if not shwos ans erro based on that.
        public required string Email { get; set; }

        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
