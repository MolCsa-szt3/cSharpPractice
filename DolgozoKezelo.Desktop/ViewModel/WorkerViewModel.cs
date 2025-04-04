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
        public ObservableCollection<DomainAndCount> domainsAndCounts;
        public WorkerViewModel(DolgozoRepo repo)
        {
            _repo = repo;
            workerCount = _repo.GetCount();
            paidWorkerCount = _repo.GetPaidCount()
        }
    }
}
