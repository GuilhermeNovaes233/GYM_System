using GYM_System.Domain.Entities;
using GYM_System.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace GYM_System.Application.ViewModels
{
    public class TeacherViewModel
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string ZipCode { get; private set; }
        public Address Address { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Photo { get; private set; }
        public string Wage { get; private set; }
        public string Entry_time { get; private set; }
        public string End_time { get; private set; }
        public string Especiality { get; private set; }
        public IEnumerable<Student> Students { get; private set; }
    }
}