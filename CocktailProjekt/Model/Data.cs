using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Data
    {
        OleDbConnection con;

        public Data()
        {
            con = new OleDbConnection(Properties.Settings.Default.ConString);
        }

        public bool OpenConnection()
        {
            Boolean result = true;
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public DataSet GetAlkohole()
        {
            DataSet dsAlkohole = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Alkohol", con);
            adapter.Fill(dsAlkohole, "Alkohole");
            return dsAlkohole;
        }

        public DataSet GetSaefte()
        {
            DataSet dsSaefte = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Saefte", con);
            adapter.Fill(dsSaefte, "Alkohole");
            return dsSaefte;
        }

        public DataSet GetDekos()
        {
            DataSet dsDekos = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Alkohol", con);
            adapter.Fill(dsDekos, "Alkohole");
            return dsDekos;
        }
    }
}
