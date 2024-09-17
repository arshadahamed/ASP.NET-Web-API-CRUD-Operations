namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } /* required = mean Must Enter*/
        public required string Email { get; set; }
        public string? Phone { get; set; } /*string? = mean Nullable*/
        public decimal Salary { get; set; }

    }
}
