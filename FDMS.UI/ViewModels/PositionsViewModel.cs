using FDMS.BL.Entities;
using FDMS.BL.Managers;
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
    public class PositionsViewModel
    {
        public ObservableCollection<Position> Positions { get; set; }

        public ICommand ShowAddPositionWinCmd { get; set; }

        public PositionsViewModel()
        {
            Positions = PositionManager.Positions;

            ShowAddPositionWinCmd = new RelayCommand(ShowAddWorkerWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowAddWorkerWindow(object obj)
        {
            var addPositionView = new AddPositionView();
            addPositionView.Show();
        }
    }
}
