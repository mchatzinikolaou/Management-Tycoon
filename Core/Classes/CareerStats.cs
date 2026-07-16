namespace Management_Tycoon.Core.Classes
{
    public class CareerStats
    {
        public decimal CurrentBudget { get; set; }
        public DateTime InGameDate { get; set; }
        public Guid ManagerId { get; set; }
        public Guid? CurrentCompanyId { get; set; } //can be unemployed
    }
}
