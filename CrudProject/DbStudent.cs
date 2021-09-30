using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CrudProject
{
    class DbStudent
    {

        public static MySqlConnection GetConnection()
        {
            String sql = "server=localhost;user id=root;database=students";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("MySQL Connection! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            return con;
        }
    }
}
