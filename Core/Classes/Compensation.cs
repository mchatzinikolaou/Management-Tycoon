using Management_Tycoon.Core.Enums;

namespace Management_Tycoon.Core.Classes
{
    public abstract class Compensation
    {
        public WageFrequencyEnum WageFrequency { get; set; }
        public decimal Amount { get; set; }
        public BenefitsPlan Benefits { get; set; }
    }
}