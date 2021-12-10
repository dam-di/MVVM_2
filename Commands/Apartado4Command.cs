using MVVM_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MVVM_2.Commands
{
    class Apartado4Command : ICommand
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
                if (textBox.Text.Equals(""))
                {
                    textBox.Background = Brushes.Red;
                }
                else
                {
                    textBox.Background = Brushes.White;
                }
            }
        }

        /*
        public HomeViewModel homeViewModel { get; set; }
        public Apartado4Command(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
        */
    }
}
