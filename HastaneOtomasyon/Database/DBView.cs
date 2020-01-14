using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HastaneOtomasyon
{
    class DBView
    {
        private  DBView view = null;

        private  SqlConnection con;
        private SqlCommand cmd;
        public static Boolean state;
        public SqlConnection Connection
        {
            get
            {
                return con;
            }
        }
        public DBView()
        {

        }
        
        private DBView(string ConnectionString)
        {
            con = new SqlConnection(ConnectionString);
        }
        
        public DBView Create(string ConnectionString)
        {
            con = new SqlConnection(ConnectionString);
            if (view==null)
            {
                view = new DBView(ConnectionString);
            }
            return view;
        }

        private bool Connect()
        {
            bool durum = true;
            if (con.State == ConnectionState.Closed)
            {
                try 
                { 
                    con.Open();
                    durum = true;
                }
                catch
                {
                    durum = false;
                }
            }
            return durum;
        }
        private bool Disconnect()
        {
            bool durum = true;
            if (con.State == ConnectionState.Open)
            {
                try
                {
                    con.Close();
                    durum = true;
                }
                catch
                {
                    durum = false;
                }
            }
            return durum;
        }

        public void Exec(string query)
        {
            try
            {
                Connect();
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Disconnect();
                state = true;
            }catch(Exception e)
            {
                state = false;
            }
        }

        public DataTable GetTable(string query, params SqlParameter[] prms)
        {
            Connect();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            for (int i = 0; i < prms.Length; i++)
            {
                cmd.Parameters.Add(prms[i]);
            }
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            Disconnect();
            return t;
        }
    }
}
