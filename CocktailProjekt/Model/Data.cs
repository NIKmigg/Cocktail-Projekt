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
            con = new OleDbConnection(Properties.Settings1.Default.ConString);
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
            adapter.Fill(dsAlkohole, "Alkohol");
            return dsAlkohole;
        }

        public DataSet GetSaefte()
        {
            DataSet dsSaefte = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Saft", con);
            adapter.Fill(dsSaefte, "Saft");
            return dsSaefte;
        }

        public DataSet GetDekos()
        {
            DataSet dsDekos = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Deko", con);
            adapter.Fill(dsDekos, "Deko");
            return dsDekos;
        }
    }
}
