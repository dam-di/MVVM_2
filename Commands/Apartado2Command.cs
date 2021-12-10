using MVVM_2.Models;
using MVVM_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_2.Commands
{
    class Apartado2Command: ICommand
    {
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            homeViewModel.AtributosModel = new AtributosModel();
        }

        public HomeViewModel homeViewModel { get; set; }
        public Apartado2Command(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
    }
}
