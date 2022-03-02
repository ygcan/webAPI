namespace webAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }

        public string Department { get; set; }
        public DateTime DateofJoin { get; set; }
        public string PhotoFileName { get; set; }

    }
}
