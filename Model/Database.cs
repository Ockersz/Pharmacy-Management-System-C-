using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Coursework.MessageBox;

namespace Coursework
{
    class Database
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter da;

        public Database()
        {
            try
            {
                Con = new SqlConnection("Data Source=LAPTOP-0S8DH0AS;Initial Catalog=Pharmacy;Integrated Security=True");
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
            }
        }

        public int insertQuery(String query)
        {
            try
            {
                Con.Close();
                Con.Open();
                Cmd = new SqlCommand(query, Con);
                int i = Cmd.ExecuteNonQuery();
                Con.Close();
                return i;
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
                return 0;
            }
            catch(NullReferenceException)
            {
                CustomMessageBox.ShowBox("selection error", "Error", "Error");
                return 0;
            }
            catch(Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return 0;
            }
        }

        public DataTable ListData(string query)
        {
            try
            {
                Con.Close();
                Con.Open();
                da = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
                return null;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return null;
            }

        }

        public int ReadDataInt(string query)
        {
            try
            {
                Con.Close();
                Con.Open();
                Cmd = new SqlCommand(query, Con);
                SqlDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    int data = dr.GetInt32(0);
                    return data;
                }
                Con.Close();
                Cmd.Dispose();
                return 0;
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
                return 0;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return 0;
            }

        }

        public string ReadDataString(string query)
        {
            try
            {
                Con.Close();
                Con.Open();
                Cmd = new SqlCommand(query, Con);
                SqlDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    string data = dr.GetString(0);
                    return data;
                }
                Con.Close();
                Cmd.Dispose();
                return null;
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
                return null;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return null;
            }

        }
        public DateTime ReadDataDate(string query)
        {
            try {
                Con.Close();
                Con.Open();
                Cmd = new SqlCommand(query, Con);
                SqlDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    DateTime data = dr.GetDateTime(0);
                    return data;
                }
                Con.Close();
                Cmd.Dispose();
                return DateTime.Today;

            }
            catch(Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return DateTime.Today;
            }
        }

        public object ReadDataValue(string query)
        {
            try
            {
                Con.Close();
                Con.Open();
                Cmd = new SqlCommand(query, Con);
                SqlDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    object data = dr.GetValue(0);
                    return data;
                }
                Con.Close();
                Cmd.Dispose();
                return 0;
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
                return null;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return null;
            }
        }

        public int GetRowCount(string query)
        {
            try
            {
                Con.Close();
                Con.Open();
                Cmd = new SqlCommand(query, Con);
                SqlDataAdapter adpt = new SqlDataAdapter(Cmd);
                DataTable ds = new DataTable();
                adpt.Fill(ds);
                Cmd.Dispose();
                Con.Close();
                return ds.Rows.Count;
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowBox("Database Eror", "Error", "Error");
                return 0;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowBox("Unknown Error", "Error", "Error");
                return 0;
            }

        }
        
    }
}