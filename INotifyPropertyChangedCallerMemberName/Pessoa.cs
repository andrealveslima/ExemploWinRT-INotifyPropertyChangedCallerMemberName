using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChangedCallerMemberName
{
    public class Pessoa : System.ComponentModel.INotifyPropertyChanged
    {
        private string _nome;
        public string Nome 
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                RaisePropertyChanged();
            }
        }
        private string _sobrenome;
        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
                RaisePropertyChanged();
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
