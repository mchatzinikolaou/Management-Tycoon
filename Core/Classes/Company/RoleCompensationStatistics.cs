using Management_Tycoon.Core.Enums;

namespace Management_Tycoon.Core.Classes.Company
{
    //Revisit code
    public class RoleCompensationStatistics
    {
        public static List<RoleEnum> ExistingRoles { get; set; } = []; //load this on boot.

        public RoleEnum Role { get; set; }
        public decimal AverageCompensation { get; set; }
        public decimal MinCompensation { get; set; }
        public decimal MaxCompensation { get; set; }
        public int NumberOfEmployees { get; set; }

        public RoleCompensationStatistics(RoleEnum role, decimal averageCompensation, decimal minCompensation, decimal maxCompensation, int numberOfEmployees)
        {
            if (ExistingRoles.Contains(role)) return;

            ExistingRoles.Add(role);
            Role = role;
            AverageCompensation = averageCompensation;
            MinCompensation = minCompensation;
            MaxCompensation = maxCompensation;
            NumberOfEmployees = numberOfEmployees;
        }
    }
}
