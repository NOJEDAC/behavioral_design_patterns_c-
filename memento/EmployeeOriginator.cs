﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memento;

namespace memento
{
    public class EmployeeOriginator
    {
        private String name;
        private String address;
        private String phone;

        public String getAddress()
        {
            return address;
        }

        public String getName()
        {
            return name;
        }

        public String getPhone()
        {
            return phone;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public String toString()
        {
            return name + " : " + phone;
        }

        public EmployeeMemento createMemento()
        { // save
            return new EmployeeMemento(name, phone);
        }

        public void setMemento(EmployeeMemento employee)
        { // revert
            this.name = employee.getName();
            this.phone = employee.getPhone();
        }


    }
}
