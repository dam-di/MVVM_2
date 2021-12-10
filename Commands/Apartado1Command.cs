using MVVM_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_2.Commands
{
    class Apartado1Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           
            if (homeViewModel.Habilitar)
            {
                homeViewModel.Habilitar = false;
            }
            else
            {
                homeViewModel.Habilitar = true;
            }
            
        }
        public HomeViewModel homeViewModel { get; set; }
        public Apartado1Command(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
    }
}
