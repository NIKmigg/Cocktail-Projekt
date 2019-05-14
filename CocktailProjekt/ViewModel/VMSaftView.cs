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
    public class VMSaftView:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ICommand buttonHinzufuegen;
        private ICommand buttonEntfernen;
        private ICommand buttonUebernehmen;

        private Saefte saftliste;

        public IEnumerable<Saft> Saftliste { get => saftliste.ListSaft; }
        public ICommand ButtonHinzufuegen { get => buttonHinzufuegen; set => buttonHinzufuegen = value; }
        public ICommand ButtonEntfernen { get => buttonEntfernen; set => buttonEntfernen = value; }
        public ICommand ButtonUebernehmen { get => buttonUebernehmen; set => buttonUebernehmen = value; }

        public VMSaftView()
        {
            this.ButtonHinzufuegen = new UserCommand(Hinzufuegen);
            this.ButtonEntfernen = new UserCommand(Entfernen);
            this.ButtonUebernehmen = new UserCommand(Uebernehmen);
            saftliste = new Saefte();
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
