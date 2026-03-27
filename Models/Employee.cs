namespace Demo_Jquery.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Department { get; set; }
        public required string Cargo { get; set; }
        public decimal Salario { get; set; }
        public bool IsActive { get; set; }
    }
}