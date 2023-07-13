using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Model_View_ViewModel.Models;

namespace WpfApp_Model_View_ViewModel.ViewModels
{
    public class CursosViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Curso> cursos;

        public ObservableCollection<Curso> Cursos
        {
            get { return cursos; }
            set
            {
                cursos = value;
                RaisePropertyChanged();
            }

        }

        public CursosViewModel()
        {
            Cursos = new ObservableCollection<Curso>();
            Cursos.Add(new Curso()
            {
                Nombre = ".Net Esencial",
                Autor = "Rodrigo Diaz Concha"
            });
            Cursos.Add(new Curso()
            {
                Nombre = ".Net Core Esencial",
                Autor = "Rodrigo Diaz Concha"
            });
            Cursos.Add(new Curso()
            {
                Nombre = "ASP.Net Core Esencial",
                Autor = "Rodrigo Diaz Concha"
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
