using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoKezelo.Console.Models
{
    public class DolgozoAdatok
    {
        private string _email;
        private decimal _salary;
        public string Name { get; set; }
        public string Email { get => _email; set =>_email = value; }
        public decimal Salary { get => _salary; set => _salary = value; } //bad name I know

        public DolgozoAdatok(string email, string name)
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

        public override string ToString()
        {
            return $"{Name} {_email} {_salary:c0}";
        }

    }
}
