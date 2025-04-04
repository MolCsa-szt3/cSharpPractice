using DolgozoKezelo.Console.DbModels;
using DolgozoKezelo.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoKezelo.Console.Repos
{
    public class DolgozoRepo
    {
        private readonly DolgozodbContext _context = new();

        public int GetCount()
        {
            return _context.Workers.Count();
        }
        public int GetPaidCount()
        {
            return _context.Workers.Count(x => x.Salary > 0);
        }
        public int GetUnpaidCount()
        {
            return _context.Workers.Count(x => x.Salary == 0);
        }
        public decimal GetAverageSalary()
        {
            return _context.Workers.Average(x => x.Salary);
        }
        public string GetNameWithMostSalary()
        {
            decimal max = _context.Workers.Max(x => x.Salary);
            return _context.Workers.Where(x => x.Salary == max).Select(x => x.Name).First();
        }
        public string GetNameWithLeastSalary()
        {
            decimal min = _context.Workers.Min(x => x.Salary);
            return _context.Workers.Where(x => x.Salary == min).Select(x => x.Name).First();
        }
        public class DomainAndCount()
        {
            public string Domain { get; set; }
            public int Count { get; set; }
        }
        public List<DomainAndCount> GetDomainsAndCounts()
        {
            List<string> domains = _context.Workers.Select((x) => x.Email.Substring(x.Email.IndexOfAny(new char[] { '@' }))).ToList();
            domains = domains.Distinct().ToList();
            List<DomainAndCount> returnValue = new();
            foreach (var domain in domains)
            {
                returnValue.Add(new DomainAndCount() { Domain = domain, Count = _context.Workers.Count(x => x.Email.Contains(domain)) });
            }
            return returnValue;
        }
        public void AddSalary(string email, decimal amount)
        {
            DolgozoAdatok? dolgozo = _context.Workers.Where(x => x.Email == email).FirstOrDefault();
            if (dolgozo is null) throw new Exception("Worker not found!");
            dolgozo.IncreaseSalary(amount);
            _context.Update(dolgozo);
            _context.SaveChanges();
        }
        public void RemoveIfWithoutSalary(string email)
        {
            DolgozoAdatok? dolgozo = _context.Workers.Where(x => x.Email == email).FirstOrDefault();
            if (dolgozo is null) throw new Exception("Worker not found!");
            _context.Workers.Remove(dolgozo);
            _context.SaveChanges();
        }
        public void AddWorker(string email, string name)
        {
            DolgozoAdatok? dolgozo = _context.Workers.Where(x => x.Email == email).FirstOrDefault();
            if (dolgozo is not null) throw new Exception("Email Used Already");
            _context.Workers.Add(new DolgozoAdatok(email, name));
            _context.SaveChanges();
        }
        public List<DolgozoAdatok> GetWithPartialName(string partialName)
        {
            return _context.Workers.Where(x => x.Name.Contains(partialName)).ToList();
        }
        public List<DolgozoAdatok> GetWithPartialEmail(string partialEmail)
        {
            return _context.Workers.Where(x => x.Email.Contains(partialEmail)).ToList();
        }
        public List<DolgozoAdatok> GetBetweenSalaries(decimal minSalary, decimal maxSalary)
        {
            return _context.Workers.Where(x => x.Salary >= minSalary && x.Salary < maxSalary).ToList();
        }

    }
}
