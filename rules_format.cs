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
    public partial class rules_format : Form
    {
        utilities util = new utilities();
        String status_1 = utilities.status;

        public rules_format()
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
                string statusValue = status.Text; // status comes from label (readonly)

                if (cmd_save.Text == "Save")
                {
                    String insert = util.iud("INSERT INTO all_table (pid,f1, f2,f3,f5,status) values ('0','" + f1.Text + "','" + f2.Text + "','" + f3.Text + "','" + f5.Text + "','" + statusValue + "')");
                    if (insert == "sucess")
                    {
                        MessageBox.Show("Data Inserted Successfully");
                    }
                }
                else
                {
                    String insert = util.iud("UPDATE all_table SET f1='" + f1.Text + "', f2='" + f2.Text + "', f3='" + f3.Text + "', f5='" + f5.Text + "' WHERE id=" + lb1_id.Text + "");
                    if (insert == "sucess")
                    {
                        MessageBox.Show("Data Updated Successfully");
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
            f5.Text = "";

            load_grid();
        }

        private void load_grid()
        {
            grd.Rows.Clear();
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataSet login_ds = util.load_dataset("SELECT * FROM all_table WHERE status='" + status_1 + "'");
            int sno = 0;

            foreach (DataRow drow in login_ds.Tables[0].Rows)
            {
                sno++;
                grd.Rows.Add(
                    drow["id"],     // Hidden internal ID
                    sno,            // Serial number
                    drow["f1"],     // Rule_no
                    drow["f2"],     // Details
                    drow["f3"],     // Description
                    drow["f5"],     // File_path
                    drow["status"]  // Status
                );
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            String insert = util.iud("DELETE FROM all_table WHERE id=" + lb1_id.Text + "");
            if (insert == "sucess")
            {
                MessageBox.Show("Data Deleted Successfully");
            }

            load_grid();
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            clear_form();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.SelectedRows.Count > 0)
            {
                cmd_save.Text = "Update";
                cmd_delete.Enabled = true;

                lb1_id.Text = grd.SelectedRows[0].Cells[0].Value.ToString();  // hidden ID
                f1.Text = grd.SelectedRows[0].Cells[2].Value.ToString();       // Rule_no
                f2.Text = grd.SelectedRows[0].Cells[3].Value.ToString();       // Details
                f3.Text = grd.SelectedRows[0].Cells[4].Value.ToString();       // Description
                f5.Text = grd.SelectedRows[0].Cells[5].Value.ToString();       // File_path
                // status is a label, no need to update
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}