namespace CRUD.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }  // Guid: Globally Unique Identifier= Guid is a unique identifier. It is commonly used when you want every record to have an ID that is extremely unlikely to be duplicated.
        public required string Name { get; set; } // here the required means if the name will e reuired if not shwos ans erro based on that.
        public required string Email { get; set; }

        public   string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
