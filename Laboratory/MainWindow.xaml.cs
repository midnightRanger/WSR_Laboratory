using Laboratory.Models;
using Laboratory.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Laboratory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        private readonly ApplicationContext _db;
        private MainWindowViewModel _mainWindowView;
        private ObservableCollection<Order> _ordersOC; 
        public MainWindow()
        {
            InitializeComponent();
            _db = new ApplicationContext();
            _mainWindowView = new();
            _ordersOC = new();
            this.DataContext = _mainWindowView;

            var orders = _db.Order.ToList();

            foreach (var order in orders) { 
                _ordersOC.Add(order);
            }
            ordersDG.ItemsSource = _ordersOC; 

            
            
        }
    }
}
