namespace Management_Tycoon.Core.Classes.Market
{
    public class Applicant : Employee
    {
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string CV { get; set; }
    }
}