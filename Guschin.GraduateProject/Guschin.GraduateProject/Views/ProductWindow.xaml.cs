using Guschin.GraduateProject.ViewModels;
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

namespace Guschin.GraduateProject.Views
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private ProductWindowViewModel _viewModel;
        

        public ProductWindow(Guid? productId)
        {
            InitializeComponent();
            _viewModel = new ProductWindowViewModel(productId); 
            DataContext= _viewModel;
          
           
        }

     
    }
}
