using CommunityToolkit.Mvvm.ComponentModel;
using DolgozoKezelo.Console.Models;
using DolgozoKezelo.Console.Repos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoKezelo.Desktop.ViewModel
{
    public partial class WorkerViewModel: ObservableObject
    {
        private DolgozoRepo _repo;
        [ObservableProperty]
        public int workerCount = -1;
        [ObservableProperty]
        public int paidWorkerCount = -1;
        [ObservableProperty]
        public int unpaidWorkerCount = -1;
        [ObservableProperty]
        public string mostPaidWorkerName = string.Empty;
        [ObservableProperty]
        public string leastPaidWorkerName = string.Empty;
        [ObservableProperty]
        public decimal avgSalary = -1;
        [ObservableProperty]
        public List<DomainAndCount> domainsAndCounts;
        public WorkerViewModel(DolgozoRepo repo)
        {
            _repo = repo;
            WorkerCount = _repo.GetCount();
            PaidWorkerCount = _repo.GetPaidCount();
            UnpaidWorkerCount= _repo.GetUnpaidCount();
            MostPaidWorkerName = _repo.GetNameWithMostSalary();
            LeastPaidWorkerName= _repo.GetNameWithLeastSalary();
            AvgSalary = _repo.GetAverageSalary();
            DomainsAndCounts = _repo.GetDomainsAndCounts();
        }
    }
}
