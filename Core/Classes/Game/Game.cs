using Management_Tycoon.Core.Classes.Company;
using Management_Tycoon.Core.Classes.Employee;

namespace Management_Tycoon.Core.Classes.Game
{
    public static class Game
    {
        public static Manager Manager { get; set; }
        public static Company.Company Company { get; set; }
        public static List<Employee.Employee> Employees { get; set; }
        public static List<RoleCompensationStatistics> RoleCompensationStatistics { get; set; }
        public static DateTime CurrentDate { get; set; }



        public static async Task NewGame()
        {
            await InitializeDate();
            await InitializeManager();
            await Game.InitializeCompany();
            await Game.InitializeEmployees();
        }

        private static async Task InitializeDate()
        {
            CurrentDate = config.CustomStartDate ?? new DateTime(DateTime.Now.Year, 1, 1);
        }

        private static async Task InitializeManager()
        {
            Manager = new()
            {
                Id=Guid.NewGuid(),
                IsPlayer = true,
            };
        }
    }
}
