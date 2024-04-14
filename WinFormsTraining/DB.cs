﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTraining
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;post=3306;username=root;password=root;database=training");

        public void openConnection()
        {
           if(connection.State==System.Data.ConnectionState.Closed) {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
