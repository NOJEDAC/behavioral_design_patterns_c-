using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memento;

namespace memento
{
    public class EmployeeMemento
    {
        private String name;
        private String phone;

        public EmployeeMemento(String name, String phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public String getName()
        {
            return name;
        }

        public String getPhone()
        {
            return phone;
        }

    }
}
