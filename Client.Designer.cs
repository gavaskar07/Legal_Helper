namespace LH
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.lb1_id = new System.Windows.Forms.Label();
            this.grd = new System.Windows.Forms.DataGridView();
            this.cmd_clear = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.lb1_id);
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Controls.Add(this.cmd_clear);
            this.groupBox1.Controls.Add(this.cmd_delete);
            this.groupBox1.Controls.Add(this.cmd_save);
            this.groupBox1.Controls.Add(this.f2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.f1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 423);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(518, 113);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 16);
            this.status.TabIndex = 11;
            this.status.Text = "label2";
            this.status.Visible = false;
            // 
            // lb1_id
            // 
            this.lb1_id.AutoSize = true;
            this.lb1_id.Location = new System.Drawing.Point(518, 83);
            this.lb1_id.Name = "lb1_id";
            this.lb1_id.Size = new System.Drawing.Size(44, 16);
            this.lb1_id.TabIndex = 10;
            this.lb1_id.Text = "label2";
            this.lb1_id.Visible = false;
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Sno,
            this.Pass,
            this.Column1,
            this.Column2});
            this.grd.Location = new System.Drawing.Point(16, 203);
            this.grd.Name = "grd";
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(585, 205);
            this.grd.TabIndex = 9;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            // 
            // cmd_clear
            // 
            this.cmd_clear.Location = new System.Drawing.Point(332, 153);
            this.cmd_clear.Name = "cmd_clear";
            this.cmd_clear.Size = new System.Drawing.Size(75, 28);
            this.cmd_clear.TabIndex = 8;
            this.cmd_clear.Text = "Clear";
            this.cmd_clear.UseVisualStyleBackColor = true;
            this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Location = new System.Drawing.Point(229, 153);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(75, 28);
            this.cmd_delete.TabIndex = 7;
            this.cmd_delete.Text = "Delete";
            this.cmd_delete.UseVisualStyleBackColor = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Location = new System.Drawing.Point(119, 153);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(75, 28);
            this.cmd_save.TabIndex = 6;
            this.cmd_save.Text = "Save";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(154, 74);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(241, 22);
            this.f2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(154, 34);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(241, 22);
            this.f1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details";
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(154, 113);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(241, 22);
            this.f3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "file_path";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Sno
            // 
            this.Sno.HeaderText = "Sno";
            this.Sno.Name = "Sno";
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Detail";
            this.Pass.Name = "Pass";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "File Path";
            this.Column2.Name = "Column2";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.administrator_setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button cmd_clear;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Label lb1_id;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox f3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}