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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            itemsDataGrid.ItemsSource = new List<object>
            {
                new {Id = 1, Name = "Хлеб", Price = 100},
                new {Id = 2, Name = "Булочка", Price = 80},
                new {Id = 3, Name = "Молоко", Price = 240}
            };
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "asasasas";
        }
    }
}
