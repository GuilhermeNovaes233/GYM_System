using System;

namespace GYM_System.Domain.ValueObjects
{
    public class Address
    {
        public Address(string name_Address, string number_Address, string complement_Address, string neighborhood, string city, string state)
        {
            Name_Address = name_Address;
            Number_Address = number_Address;
            Complement_Address = complement_Address;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }

        public string Name_Address { get; private set; }
        public string Number_Address { get; private set; }
        public string Complement_Address { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
    }
}