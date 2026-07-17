using Management_Tycoon.Core.Enums;

namespace Management_Tycoon.Core.Classes.Project
{
    public class Project
    {
        public Guid Id { get; set; }
        public DateTime Deadline { get; set; }
        public string Name { get; set; }
        public decimal InitialBudget { get; set; }
        public decimal CurrentBudget { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ManagerId { get; set; }
        public List<Employee> Employees { get; set; }
        public Dictionary<Guid, RoleEnum> EmployeeRoleAssignments { get; set; }
        public List<Effort> TotalWorkEffort { get; set; }
        public List<Effort> CurrentWorkEffort { get; set; }
        public ProjectStateEnum State { get; set; }
    }
}