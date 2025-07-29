using FH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LH
{
    public partial class Client : Form
    {
        utilities util = new utilities();
        String status_1 = utilities.status;
        
        public Client()
        {
            InitializeComponent();
        }

        private void administrator_setting_Load(object sender, EventArgs e)
        {
             this.Text = status_1 + " Setting";
            status.Text = utilities.status;
            groupBox1.Text = status.Text + " Setting";
            cmd_delete.Enabled = false;
            load_grid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1.Text == "")
            {
                MessageBox.Show("Please enter the username");
            }
            else if (f2.Text == "")
            {
                MessageBox.Show("Please enter the password");
            }
            else
            {
                if (cmd_save.Text == "Save")
                {
                    String insert = util.iud("INSERT INTO all_table (pid,f1, f2,f3, status ) values ('0','" + f1.Text + "','" +f2.Text + "','" +f3.Text + "','" + status.Text + "')");
                    if (insert == "sucess")
                    {
                        MessageBox.Show("Data Inserted Sucessfully");
                    }
                }
                else
                {
                    String insert = util.iud("update all_table set f1='" + f1.Text + "', f2='" + f2.Text + "', f3='" + f3.Text + "' where id=" + lb1_id.Text + "");
                    if (insert == "sucess")
                    {
                        MessageBox.Show("Data Updated Sucessfully");
                    }
                }
            }
            clear_form();
        }
        private void clear_form()
        {
            cmd_delete.Enabled = false;
            lb1_id.Text = "";
            cmd_save.Text = "Save";
           f1.Text = "";
           f2.Text = "";
            f3.Text = "";

            load_grid();
        }
        private void load_grid()
        {
            grd.Rows.Clear();
            DataSet login_ds = new DataSet();
            login_ds = util.load_dataset("select * from all_table where status='"+ status_1 + "'");
            int sno = 0;
            foreach (DataRow drow in login_ds.Tables[0].Rows)
            {
                sno=sno + 1;
                grd.Rows.Add(drow["id"],sno, drow[2], drow[3], drow[4]);
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            String insert = util.iud("delete from all_table where id=" + lb1_id.Text + "");
            if (insert == "sucess")
            {
                MessageBox.Show("Data deleted Sucessfully");
            }
            load_grid();
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            clear_form();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmd_save.Text = "Update";
            cmd_delete.Enabled = true; 
            lb1_id.Text = grd.SelectedRows[0].Cells[0].Value.ToString();
           f1.Text = grd.SelectedRows[0].Cells[2].Value.ToString();
            f2.Text = grd.SelectedRows[0].Cells[3].Value.ToString();
            f3.Text = grd.SelectedRows[0].Cells[4].Value.ToString();
            //role_cmb.SelectedText = grd_user.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
