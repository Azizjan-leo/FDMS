using FDMS.BL.Entities;
using FDMS.Model.Entities;
using FDMS.UI.Commands;
using FDMS.UI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FDMS.UI.ViewModels
{
    public class WorkersViewModel
    {
        public ObservableCollection<Worker> Workers {  get; set; }

        public ICommand ShowAddWorkerWinCmd { get; set; }

        public WorkersViewModel()
        {
            Workers = WorkerManager.Workers;

            ShowAddWorkerWinCmd = new RelayCommand(ShowAddWorkerWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowAddWorkerWindow(object obj)
        {
            var addWorkerView = new AddWorkerView();
            addWorkerView.Show();
        }
    }
}
