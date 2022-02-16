using GYM_System.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace GYM_System.Domain.Entities
{
    public class Teacher : Person
    {
        protected Teacher() { }

        public Teacher(
            string name,
            string email,
            string zipCode,
            Address address,
            string cpf,
            string rg,
            DateTime birthDate,
            string phoneNumber,
            string photo,
            string wage, 
            string entry_time, 
            string end_time, 
            string especiality,
            IEnumerable<Student> students) : base(name, email, zipCode, address, cpf, rg, birthDate, phoneNumber, photo) 
        {
            Wage = wage;
            Entry_time = entry_time;
            End_time = end_time;
            Especiality = especiality;
            Students = students;
        }

        public string Wage { get; private set; }
        public string Entry_time { get; private set; }
        public string End_time { get; private set; }
        public string Especiality { get; private set; }
        public IEnumerable<Student> Students { get; private set; }
    }
}