namespace Management_Tycoon.Core.Classes.Company
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}
