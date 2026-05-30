using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExcaMetr_Ver_0._0
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server =localhost,port=3306;user=root;password=root;database=excametr_database");



        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            openConnection();
            MySqlCommand command = new MySqlCommand(query, getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            closeConnection();
            return table;
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

        }


        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
