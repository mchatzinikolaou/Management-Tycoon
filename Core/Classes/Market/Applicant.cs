namespace Management_Tycoon.Core.Classes.Market
{
    public class Applicant : Employee.Employee
    {
        public Guid CurrentCompanyId { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string CV { get; set; }
    }
}