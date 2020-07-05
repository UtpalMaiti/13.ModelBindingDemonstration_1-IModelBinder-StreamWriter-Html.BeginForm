using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingDemonstration_1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int Salary { get; set; }

        public Address CurrentAddress { get; set; }

        public Address PermanentAddress { get; set; }

        public override string ToString()
        {
            return "Id is : " + Id + ", Name is : " + Name + ", Location is : " + Location +
                " and Salary is : " + Salary +". Current Address : "+CurrentAddress.AddressLine1+", "+CurrentAddress.AddressLine2+
                ", "+CurrentAddress.City+", "+CurrentAddress.State;
        }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public Z CustomZ { get; set; }
    }

    public class Z
    {
        public string X { get; set; }
        public string Y { get; set; }
    }
}