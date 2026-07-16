namespace Management_Tycoon.Core.Classes
{
    public class Manager : Employee
    {
        public bool IsPlayer { get; set; } = true;
        public decimal Savings { get; set; }
        public Expenditure Expenditure { get; set; }

    }

    public class Expenditure
    {
        public decimal MonthlyExpenditure { get; set; }
        public decimal AnnualExpenditure { get; set; }
    }
}
