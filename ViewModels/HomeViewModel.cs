using MVVM_2.Commands;
using MVVM_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_2.ViewModels
{
    class HomeViewModel:ViewModelBase
    {
        private bool habilitar;
        public bool Habilitar
        {
            get { return habilitar; }
            set { habilitar = value; OnPropertyChanged(nameof(Habilitar)); }
        }
        private AtributosModel atributosModel;
        public AtributosModel AtributosModel { 
            get { return atributosModel; } set { atributosModel = value;OnPropertyChanged(nameof(AtributosModel)); } }
        public ICommand Apartado1Command { get; set; }
        public ICommand Apartado2Command { get; set; }
        public ICommand Apartado3Command { get; set; }
        public ICommand Apartado4Command { get; set; }
        public HomeViewModel()
        {
            Apartado1Command = new Apartado1Command(this);
            Apartado2Command = new Apartado2Command(this);
            Apartado3Command = new Apartado3Command();
            Apartado4Command = new Apartado4Command();
            Habilitar = true;
        }
    }
}
