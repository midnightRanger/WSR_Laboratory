using Laboratory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.ViewModels
{
    public class MainWindowViewModel: BaseViewModel
    {
        private string _showValueText;
        public string ShowValueText { get => _showValueText; 
            set 
            { 
                _showValueText = value;
                OnPropertyChanged(nameof(ShowValueText));
            }
        }

        private ObservableCollection<Order> _orders; 
        public ObservableCollection<Order> Orders { get => _orders; }
    }
}
