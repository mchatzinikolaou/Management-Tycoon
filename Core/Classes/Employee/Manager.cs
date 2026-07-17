namespace Management_Tycoon.Core.Classes.Employee
{
    public class Manager : Employee
    {
        public bool IsPlayer { get; set; } = true;
        public decimal Budget { get; set; }
        public Expenditure Expenditure { get; set; }

    }

    public class Expenditure
    {
        public decimal MonthlyExpenditure { get; set; }
        public decimal AnnualExpenditure { get; set; }
    }
}
