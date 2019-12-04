using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memento;

namespace memento
{
    class Client
    {
        static void Main(string[] args)
        {

            Caretaker caretaker = new Caretaker();

            EmployeeOriginator employee = new EmployeeOriginator();
            employee.setName("John Wick");
            employee.setAddress("111 Main Street");
            employee.setPhone("888-555-1212");
            Console.WriteLine("Employee before save: " + employee.getName() + " " +  employee.getAddress() + "  " + employee.getPhone());
            caretaker.save(employee);
                       
            
            employee.setPhone("444-555-6666");
            caretaker.save(employee);
            Console.WriteLine("Employee after changed phone number save: " + employee.getName() + "  " + employee.getAddress() + "  " + employee.getPhone());

            employee.setPhone("333-999-6666"); // <--- we haven't called save!
            caretaker.revert(employee);
            Console.WriteLine("Reverts to last save point: " + employee.getName() + "  " + employee.getAddress() + "  " + employee.getPhone());

            //caretaker.revert(employee);
            //Console.WriteLine("Reverted to original: " + employee.getName() + "  " + employee.getAddress() + "  " + employee.getPhone());

            //caretaker.revert(employee);
            //Console.WriteLine("Reverted to original: " + employee.getName() + "  " + employee.getAddress() + "  " +employee.getPhone());

            Console.Read();
        }

    
    }
}
