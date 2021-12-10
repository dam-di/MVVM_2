using MVVM_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVM_2.Commands
{
    class Apartado3Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is TextBox)
            {
                TextBox textBox = (TextBox)parameter;
                if (textBox.IsVisible)
                {
                    textBox.Visibility = Visibility.Collapsed;
                }
                else
                {
                    textBox.Visibility = Visibility.Visible;
                }
            }
        }

        
        /*
         * En este caso no es necesario pasar el ViewModel
        public HomeViewModel homeViewModel { get; set; }

        public Apartado3Command(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
        */
    }
}
