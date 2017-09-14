using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    class pocol
    {

        string connS = @"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True";
        public void ListAccounts(DataGridView dgv)
        {
            DataTable data = new DataTable();

            data.Columns.Add("IdAccount", typeof(int));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Surname", typeof(string));
            data.Columns.Add("CNP", typeof(string));
            data.Columns.Add("Curency", typeof(string));
            data.Columns.Add("Balance", typeof(int));
            data.Columns.Add("Account Type", typeof(string));

            using (SqlConnection connection = new SqlConnection(connS))
            {
                using (SqlCommand command = new SqlCommand("SELECT a.IdAccount,c.Name,c.Surname,c.CNP,a.Currency,a.Balance,a.[Account Type] FROM Account a, Client c WHERE a.IDClient=c.IdClient", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id, ba;
                            string na, sn, cnp, cu, at;
                            id = reader.GetInt32(0);
                            na = reader.GetString(1);
                            sn = reader.GetString(2);
                            cnp = reader.GetString(3);
                            cu = reader.GetString(4);
                            ba = reader.GetInt32(5);
                            at = reader.GetString(6);
                            data.Rows.Add(id, na, sn, cnp, cu, ba, at);
                        }
                    }
                }
            }

            dgv.DataSource = data;
            dgv.Columns[0].Visible = false;
        }

        public void AddBalance(int id, int sum)
        {
            using (SqlConnection connection = new SqlConnection(connS))
            {
                using (SqlCommand command = new SqlCommand("UPDATE Account SET Balance=Balance+@sum WHERE IdAccount=@id", connection))
                {
                    command.Parameters.AddWithValue("@sum", sum);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void RemoveBalance(int id, int summ)
        {
            using (SqlConnection connection = new SqlConnection(connS))
            {
                using (SqlCommand command = new SqlCommand("UPDATE Account SET Balance=Balance-@summ WHERE IdAccount=@id", connection))
                {
                    command.Parameters.AddWithValue("@summ", summ);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void ListClients(DataGridView dgv)
        {
            DataTable data = new DataTable();

            data.Columns.Add("IdClient", typeof(int));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Surname", typeof(string));
            data.Columns.Add("CNP", typeof(string));
            data.Columns.Add("Age", typeof(string));
            data.Columns.Add("Address", typeof(string));
            data.Columns.Add("User", typeof(string));
            data.Columns.Add("Password", typeof(string));
            data.Columns.Add("Income", typeof(Int16));
            data.Columns.Add("Client Type", typeof(string));
            data.Columns.Add("Gender", typeof(string));

            using (SqlConnection connection = new SqlConnection(connS))
            {
                using (SqlCommand command = new SqlCommand("SELECT IdClient,Name,Surname,CNP,Age,Adress,[User],[Password],Income,[Client Type],Sex FROM Client", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id;
                            Int16 inc;
                            string na, sn, cnp, age, addr, user, pwd, ct, gndr;
                            id = reader.GetInt32(0);
                            na = reader.GetString(1);
                            sn = reader.GetString(2);
                            cnp = reader.GetString(3);
                            age = reader.GetString(4);
                            addr = reader.GetString(5);
                            user = reader.GetString(6);
                            pwd = reader.GetString(7);
                            inc = reader.GetInt16(8);
                            ct = reader.GetString(9);
                            gndr = reader.GetString(10);
                            data.Rows.Add(id, na, sn, cnp, age, addr, user, pwd, inc, ct, gndr);
                        }
                    }
                }
            }

            dgv.DataSource = data;
            dgv.Columns[0].Visible = false;
        }
        public void UpdatePassword(int id, string pwd)
        {
            using (SqlConnection connection = new SqlConnection(connS))
            {
                using (SqlCommand command = new SqlCommand("UPDATE Client SET Password=@pass WHERE IdClient=@id", connection))
                {
                    command.Parameters.AddWithValue("@pass", pwd);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
