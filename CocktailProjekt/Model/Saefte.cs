using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Saefte
    {
        private Data data = new Data();
        private ObservableCollection<Saefte> listSaefte;

        public ObservableCollection<Saefte> ListSaefte { get => listSaefte; set => listSaefte = value; }

        public Saefte()
        {
            ListSaefte = new ObservableCollection<Saefte>();
            DataSet ds = data.GetAlkohole();
            DataTable dt = ds.Tables[0];
            DataTableReader reader = dt.CreateDataReader();
            while (reader.Read())
            {
                Saft s = mkSaefte(reader);
                listSaefte.Add(s);
            }
            reader.Close();
        }

        private Saft mkSaefte(DataTableReader reader)
        {
            Saft s = new Saft();

            s.Id = reader.GetInt32(0);
            s.Bezeichnung = reader.GetString(1);
            s.Preis = reader.GetDecimal(3);

            return s;
        }
    }
}
