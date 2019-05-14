using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Model;

namespace ViewModel
{
    public class VMAlkoholView:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ICommand buttonHinzufuegen;
        private ICommand buttonEntfernen;
        private ICommand buttonUebernehmen;

        private Alkohole alkoholliste;

        public IEnumerable<Alkohol> Alkoholliste { get => alkoholliste.ListAlkohol; }
        public ICommand ButtonHinzufuegen { get => buttonHinzufuegen; set => buttonHinzufuegen = value; }
        public ICommand ButtonEntfernen { get => buttonEntfernen; set => buttonEntfernen = value; }
        public ICommand ButtonUebernehmen { get => buttonUebernehmen; set => buttonUebernehmen = value; }

        public VMAlkoholView()
        {
            this.ButtonHinzufuegen = new UserCommand(Hinzufuegen);
            this.ButtonEntfernen = new UserCommand(Entfernen);
            this.ButtonUebernehmen = new UserCommand(Uebernehmen);
            alkoholliste = new Alkohole();
        }

        private void Uebernehmen(object obj)
        {
            throw new NotImplementedException();
        }

        public void Hinzufuegen(Object o)
        {

        }

        public void Entfernen(Object o)
        {

        }
    }
}
