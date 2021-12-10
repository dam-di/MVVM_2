using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_2.Models
{
    public class AtributosModel : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return atributo1;
        }

        private string atributo1;
        public string Atributo1
        {
            get { return this.atributo1; }
            set { this.atributo1 = value; OnPropertyChanged(nameof(Atributo1)); }
        }
        private string atributo2;
        public string Atributo2
        {
            get { return this.atributo2; }
            set { this.atributo2 = value; OnPropertyChanged(nameof(Atributo2)); }
        }
        private string atributo3;
        public string Atributo3
        {
            get { return this.atributo3; }
            set { this.atributo3 = value; OnPropertyChanged(nameof(Atributo3)); }
        }
        private string atributo4;
        public string Atributo4
        {
            get { return this.atributo4; }
            set { this.atributo4 = value; OnPropertyChanged(nameof(Atributo4)); }
        }
        private string atributo5;
        public string Atributo5
        {
            get { return this.atributo5; }
            set { this.atributo5 = value; OnPropertyChanged(nameof(Atributo5)); }
        }
        private string atributo6;
        public string Atributo6
        {
            get { return this.atributo6; }
            set { this.atributo6 = value; OnPropertyChanged(nameof(Atributo6)); }
        }
        public AtributosModel()
        {

        }
    }
}
