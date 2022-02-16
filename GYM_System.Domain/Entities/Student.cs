using GYM_System.Domain.ValueObjects;
using System;

namespace GYM_System.Domain.Entities
{
    public class Student : Person
    {
        protected Student() { }

        public Student(
            string name, 
            string email, 
            string zipCode, 
            Address address, 
            string cpf, 
            string rg, 
            DateTime birthDate, 
            string phoneNumber, 
            string photo,
            string gymPass) : base(name, email, zipCode, address, cpf, rg, birthDate, phoneNumber, photo) 
        {
            GymPass = gymPass;
        }

        public string GymPass { get; private set; }
    }
}