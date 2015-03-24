using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using theABC.GUI;
namespace theABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* MySqlCommand cmd;
            //string cs = "Server=localhost;uid=root;Persist Security Info=true; pwd=123; Database=folletitos";
            string cs = "server=localhost;user=root;database=folletitos;port=3306;password=123;";
            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();

            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Truncate table productos";
            cmd.ExecuteNonQuery();
            * */
            productosGUI oProductosGUI = new productosGUI();
            oProductosGUI.Show();
            
            
        }
    }
}
