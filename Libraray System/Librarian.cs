using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_System
{
    internal class Librarian
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public Librarian(int employeeID, string name)
        {
            EmployeeID = employeeID;
            Name = name;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, Name: {Name}";
        }
    }
}
