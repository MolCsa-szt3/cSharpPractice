using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoKezelo.Console.Models
{
    class DolgozoAdatok
    {
        private string _email;
        private decimal _salary;
        public string Name { get; set; }
        public string Email { get => _email; set =>_email = value; }
        public decimal Salary { get => _salary; set => _salary = value; } //bad name I know

        public DolgozoAdatok(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email)) throw new InvalidDataException("Név és Email nem lehet üres!");
            if (!email.Contains('@')) throw new InvalidDataException("Helytelen Email cím!");
            Name = name;
            _email = email;
            _salary = 0;
        }

        public void IncreaseSalary(decimal increase)
        {
            if (increase <= 0) throw new InvalidDataException("Csak pozitív számmal lehet fizetést emelni!");
            _salary += increase;
        }

    }
}
