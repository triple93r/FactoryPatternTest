using ClassLibrary1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories.Implements
{
    public class Employee : Iempstud
    {
        public string GetFirstName()
        {
            return "Employee FirstName";
        }
        public string GetLastName()
        {
            return "Employee LastName";
        }
    }
}
