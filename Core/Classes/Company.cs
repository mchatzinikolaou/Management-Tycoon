
namespace Management_Tycoon.Core.Classes
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public int NumOfEmployees { get; set; }
        public List<Manager> Managers { get; set; }

        public void AssignManager(Manager manager, Project project)
        {

        }
    }
}
