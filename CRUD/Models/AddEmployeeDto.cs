namespace CRUD.Models
{
    public class AddEmployeeDto // the dto is stands  for data transffer object which means for tranfe teh object as a paramaeter
    {
        public required string Name { get; set; } // here the required means if the name will e reuired if not shwos ans erro based on that.
        public required string Email { get; set; }

        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
