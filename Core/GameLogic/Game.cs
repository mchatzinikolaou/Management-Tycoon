using Management_Tycoon.Core.Classes;

namespace Management_Tycoon.Core.GameLogic
{
    public static class Game
    {
        public static Manager Manager { get; set; }
        public static Company Company { get; set; }
        public static List<Employee> Employees { get; set; }
        public static List<RoleCompensationStatistics> RoleCompensationStatistics { get; set; }
        public static DateTime CurrentDate { get; set; }



        public static async Task InitializeGame()
        {
            await Game.InitializeDate();
            await Game.InitializeManager();
            await Game.InitializeCompany();
            await Game.InitializeEmployees();
        }

        public static async Task InitializeDate()
        {
            CurrentDate = config.CustomStartDate ?? new DateTime(DateTime.Now.Year, 1, 1);
        }
    }
}
