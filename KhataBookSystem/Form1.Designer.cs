namespace KhataBookSystem
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.grdBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dbill = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 641);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.grdBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1139, 553);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btncheck);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1139, 56);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 119;
            this.button1.Text = "Export To Excle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Blue;
            this.btncheck.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.Location = new System.Drawing.Point(12, 15);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(228, 29);
            this.btncheck.TabIndex = 117;
            this.btncheck.Text = "Check Todays Credit";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // grdBill
            // 
            this.grdBill.AllowUserToAddRows = false;
            this.grdBill.AllowUserToDeleteRows = false;
            this.grdBill.AllowUserToResizeColumns = false;
            this.grdBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grdBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.Location = new System.Drawing.Point(0, 0);
            this.grdBill.Name = "grdBill";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.grdBill.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdBill.Size = new System.Drawing.Size(1139, 553);
            this.grdBill.TabIndex = 3;
            this.grdBill.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdBill_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dbill);
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtbillno);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Controls.Add(this.Label8);
            this.panel2.Controls.Add(this.Label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 88);
            this.panel2.TabIndex = 0;
            // 
            // dbill
            // 
            this.dbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbill.Location = new System.Drawing.Point(668, 49);
            this.dbill.Name = "dbill";
            this.dbill.Size = new System.Drawing.Size(200, 26);
            this.dbill.TabIndex = 116;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Blue;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(962, 48);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(163, 29);
            this.btncancel.TabIndex = 115;
            this.btncancel.Text = " NEW INVOICE";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(874, 47);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(82, 29);
            this.btnsave.TabIndex = 114;
            this.btnsave.Text = "Search";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtbillno
            // 
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillno.Location = new System.Drawing.Point(421, 50);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(121, 26);
            this.txtbillno.TabIndex = 110;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(86, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 26);
            this.txtName.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 107;
            this.label5.Text = "Bill No :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(425, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(330, 39);
            this.Label1.TabIndex = 106;
            this.Label1.Text = "Shridatta KSK, Umadi";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(548, 49);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(123, 22);
            this.Label8.TabIndex = 105;
            this.Label8.Text = "Date Of Bill  : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 22);
            this.Label2.TabIndex = 103;
            this.Label2.Text = "Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1139, 641);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khatabook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dbill;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView grdBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button button1;
    }
}

