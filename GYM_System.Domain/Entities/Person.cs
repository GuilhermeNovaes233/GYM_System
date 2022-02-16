using GYM_System.Domain.ValueObjects;
using System;

namespace GYM_System.Domain.Entities
{
    public class Person : Entity
    {
        protected Person() { }

        public Person(string name, string email, string zipCode, Address address, string cpf, string rg, DateTime birthDate, string phoneNumber, string photo)
        {
            Name = name;
            Email = email;
            ZipCode = zipCode;
            Address = address;
            CPF = cpf;
            RG = rg;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            Photo = photo;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string ZipCode { get; private set; }
        public Address Address { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Photo { get; private set; }
    }
}