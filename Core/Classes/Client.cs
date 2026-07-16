using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Tycoon.Core.Classes
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}
