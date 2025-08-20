using FH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LH
{
    public partial class Form1 : Form
    {
        OleDbConnection myconnection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (myconnection.State == ConnectionState.Open)
                {
                    myconnection.Close();
                }
                 
                myconnection.Open();
                
                string query = "Select * From all_table Where f1 = '" + f1.Text + "' And f2 = '" +f2.Text + "' and status='admin_user'";
                OleDbCommand cmd = new OleDbCommand(query, myconnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    utilities.status= "Rules";
                    Rules au = new Rules();
                        au.Show();
                 
                }
                else
                {
                    MessageBox.Show("Sorry Invalid User Attempt !!");
                }
                cmd.Dispose();
                myconnection.Close();
            }
            catch (Exception ex)
            {
                myconnection.Close();
                MessageBox.Show("Incorrect Credentials");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            strPath = strPath.Substring(6, strPath.Length - 6);
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string datafile = strPath + "\\Database.accdb";
            myconnection.ConnectionString = provider + datafile;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
