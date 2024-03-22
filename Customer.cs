using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BMG___UML1
{
    internal class Customer
    {
        private string _name;      //Instance Variables/Instance Fields/Attributes.
        private string _address;
        private string _city;
        private string _phoneNumber;
        private string _email;

        //constructor
        public Customer(string name, string address, string city, string phoneNumber, string email) //Method-signature.
        {
            _name = name;                    //assignment.
            _address = address;
            _city = city;
            _phoneNumber = phoneNumber;
            _email = email;

        }
        //property get-return for Name, Address, City, PhoneNumber, Email.
        public string Name { get { return _name; } }
        public string Address { get { return _address; } }
        public string City { get { return _city; } }
        public string PhoneNumber { get { return _phoneNumber; } }
        public string Email { get { return _email;} }

        //ToString Method:
        public override string ToString() {
            return _name + " " + _email;
        }

    }
}
