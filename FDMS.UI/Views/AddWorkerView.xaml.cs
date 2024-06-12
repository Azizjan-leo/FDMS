using FDMS.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FDMS.UI.Views
{
    /// <summary>
    /// Interaction logic for AddWorkerView.xaml
    /// </summary>
    public partial class AddWorkerView : Window
    {
        public AddWorkerView()
        {
            InitializeComponent();

            var viewModel = new AddWorkerViewModel((s, e) => this.Close());
            this.DataContext = viewModel;

        }
    }
}
