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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LH
{
    public partial class Advocate_case_court : Form
    {
        utilities util = new utilities();
        String status_1 = utilities.status;

        public Advocate_case_court()
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
            if (string.IsNullOrWhiteSpace(f1.Text))
            {
                MessageBox.Show("Please enter the username");
                return;
            }
            if (string.IsNullOrWhiteSpace(f2.Text))
            {
                MessageBox.Show("Please enter the password");
                return;
            }

            try
            {
                string Escape(string input) => input.Replace("'", "''");

                if (cmd_save.Text == "Save")
                {
                    string query = $"INSERT INTO all_table (pid, f1, f2, f3, f4, f5, f6, status) VALUES ('0', '{Escape(f1.Text)}', '{Escape(f2.Text)}', '{Escape(f3.Text)}', '{Escape(f4.Text)}', '{Escape(f5.Text)}', '{Escape(f6.Text)}', '{Escape(status.Text)}')";
                    string insert = util.iud(query);
                    if (insert == "sucess")
                    {
                        MessageBox.Show("Data Inserted Successfully");
                    }
                }
                else
                {
                    string query = $"UPDATE all_table SET f1='{Escape(f1.Text)}', f2='{Escape(f2.Text)}', f3='{Escape(f3.Text)}', f4='{Escape(f4.Text)}', f5='{Escape(f5.Text)}', f6='{Escape(f6.Text)}' WHERE id={lb1_id.Text}";
                    string update = util.iud(query);
                    if (update == "sucess")
                    {
                        MessageBox.Show("Data Updated Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
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
            f4.Text = "";
            f5.Text = "";
            f6.Text = "";

            load_grid();
        }
        private void load_grid()
        {
            grd.Rows.Clear();
            DataSet login_ds = new DataSet();
            login_ds = util.load_dataset("select * from all_table where status='" + status_1 + "'");
            int sno = 0;
            foreach (DataRow drow in login_ds.Tables[0].Rows)
            {
                sno = sno + 1;
                grd.Rows.Add(drow["id"], sno, drow[2], drow[3], drow[4], drow[5], drow[6], drow[7]);
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM all_table WHERE id={lb1_id.Text}";
                string result = util.iud(query);
                if (result == "sucess")
                {
                    MessageBox.Show("Data deleted Successfully");
                }
                load_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            clear_form();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= grd.Rows.Count) return;

            var row = grd.Rows[e.RowIndex];
            cmd_save.Text = "Update";
            cmd_delete.Enabled = true;
            lb1_id.Text = row.Cells[0].Value?.ToString() ?? "";
            f1.Text = row.Cells[2].Value?.ToString() ?? "";
            f2.Text = row.Cells[3].Value?.ToString() ?? "";
            f3.Text = row.Cells[4].Value?.ToString() ?? "";
            f4.Text = row.Cells[5].Value?.ToString() ?? "";
            f5.Text = row.Cells[6].Value?.ToString() ?? "";
            f6.Text = row.Cells[7].Value?.ToString() ?? "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}