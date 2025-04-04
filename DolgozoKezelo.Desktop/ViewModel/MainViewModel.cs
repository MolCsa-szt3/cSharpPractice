using CommunityToolkit.Mvvm.ComponentModel;
using DolgozoKezelo.Console.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DolgozoKezelo.Desktop.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {
        private DolgozoRepo repo = new();
        public WorkerViewModel workerVM { get; set; }

        public MainViewModel()
        {
            workerVM = new(repo);
        }
    }
}
