using FDMS.Model.Entities;
using FDMS.UI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FDMS.UI.ViewModels
{
    public class AddWorkerViewModel
    {
        public ICommand AddWorkerCmd { get; set; }
        public event EventHandler OnRequestClose;

        public string Name { get; set; }
        public string Email { get; set; }

        public AddWorkerViewModel(EventHandler onRequestClose)
        {
            AddWorkerCmd = new RelayCommand(AddWorker, CanAddUser);
            OnRequestClose = onRequestClose;
        }

        private bool CanAddUser(object obj) => true;

        private void AddWorker(object obj)
        {
            WorkerManager.AddWorker(Name, Email);
            OnRequestClose(this, new EventArgs());
        }
    }
}
