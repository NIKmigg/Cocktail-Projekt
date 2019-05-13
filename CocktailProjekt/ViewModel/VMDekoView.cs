using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class VMDekoView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ICommand buttonHinzufuegen;
        private ICommand buttonEntfernen;
        private ICommand buttonUebernehmen;

        private Dekos dekoliste;

        public IEnumerable<Deko> Dekoliste { get => dekoliste.ListDekos; }
        public ICommand ButtonHinzufuegen { get => buttonHinzufuegen; set => buttonHinzufuegen = value; }
        public ICommand ButtonEntfernen { get => buttonEntfernen; set => buttonEntfernen = value; }
        public ICommand ButtonUebernehmen { get => buttonUebernehmen; set => buttonUebernehmen = value; }

        public VMDekoView()
        {
            this.ButtonHinzufuegen = new UserCommand(Hinzufuegen);
            this.ButtonEntfernen = new UserCommand(Entfernen);
            this.ButtonUebernehmen = new UserCommand(Uebernehmen);
            dekoliste = new Dekos();
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
