using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memento;

namespace memento
{
    public class Caretaker
    {
     private  Stack<EmployeeMemento> employeeHistory = new Stack<EmployeeMemento>();

        public void save(EmployeeOriginator employee)
        {
            employeeHistory.Push(employee.createMemento());
        }

        public void revert(EmployeeOriginator employee)
        {
            if (employeeHistory.Count() > 0)
            {
                employee.setMemento(employeeHistory.Pop());
            }


        }
    }
}
