using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FH
{

    public class utilities
    {
        
        public string strPath;
        public static String status;
        OleDbConnection myconnection = new OleDbConnection();
       public utilities()
        {
            strPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            strPath = strPath.Substring(6, strPath.Length - 6);
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string datafile = strPath + "\\Database.accdb";
            myconnection.ConnectionString = provider + datafile;
        }
    
        public void populate_admin(System.Windows.Forms.ComboBox combo)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("0", "Select");
            ldict.Add("Super Administrator", "Super Administrator");
            ldict.Add("Central Administrator", "Central Administrator");
            ldict.Add("State Adminsitrator", "State Adminsitrator");
            combo.DataSource = ldict.ToList();
            combo.ValueMember = "Key";
            combo.DisplayMember = "value";
        }
        public void populate_document(System.Windows.Forms.ComboBox combo,String status)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add("0", "Select");
            DataSet login_ds = new DataSet();
            login_ds =load_dataset("select * from all_table where status='Document Type'");
            int sno = 0;
            foreach (DataRow drow in login_ds.Tables[0].Rows)
            {
                sno = sno + 1;
                // grd.Rows.Add(drow["id"], sno, drow["id"], "*****");
                ldict.Add(drow["id"].ToString(), drow["f1"].ToString());
            }
            //ldict.Add("CS101", "CS101 - Fundamentals of Computing and Programming ");
            //ldict.Add("CS204", "CS204 - Design and Analysis of Algorithm");
            combo.DataSource = ldict.ToList();
            combo.ValueMember = "Key";
            combo.DisplayMember = "value";
        }
       
        public String iud (String query)
            {
           // set_connection_details();
            myconnection.Open();
            string command = query;
            OleDbCommand cmdd = new OleDbCommand(command, myconnection);
            int rowcount = cmdd.ExecuteNonQuery();
            myconnection.Close();
            if (rowcount > 0)
            {
                return "sucess";
                
            }
            else
            {
                return "error";

            }
        }
        public DataSet load_dataset(String query)
        {
            //set_connection_details();
           
            myconnection.Open();
            string queryString =query;
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, myconnection);
            DataSet data = new DataSet();
            adapter.Fill(data, "datatable");
            myconnection.Close();
            return data;
            //dg.DataSource = data.Tables[0];
        }
}
   
}
