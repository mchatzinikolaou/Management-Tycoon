using Management_Tycoon.Core.Enums;

namespace Management_Tycoon.Core.Classes.Employee
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Compensation Compensation { get; set; }
        public List<RoleEnum> Roles { get; set; }
        public Dictionary<RoleEnum, int> YoE { get; set; }
        public float Productivity { get; set; }
    }
}
