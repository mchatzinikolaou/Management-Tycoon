using Management_Tycoon.Core.Classes.Company;
using Management_Tycoon.Core.Enums;

namespace Management_Tycoon.Core.Classes.Employee
{
    public abstract class Compensation
    {
        public WageFrequencyEnum WageFrequency { get; set; }
        public decimal Amount { get; set; }
        public BenefitsPlan Benefits { get; set; }
    }
}