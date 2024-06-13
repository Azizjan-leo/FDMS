using FDMS.BL.Entities;
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
    /// Interaction logic for PositionsView.xaml
    /// </summary>
    public partial class PositionsView : Window
    {
        public PositionsView()
        {
            InitializeComponent();
            var viewModel = new PositionsViewModel();
            this.DataContext = viewModel;
        }

        private void FilterTxtChanged(object sender, TextChangedEventArgs e)
        {
            PositionsList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var position = obj as Position;

            return position.Name.ToLower().Contains(FilterTxt.Text.ToLower());
        }
    }
}
