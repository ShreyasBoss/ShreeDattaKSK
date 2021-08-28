namespace KhataBookSystem
{
    partial class NewInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInvoice));
            this.dpbill = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinterst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddcutomer = new System.Windows.Forms.ComboBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dpcdate = new System.Windows.Forms.DateTimePicker();
            this.lbltotalinterst = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbltotalAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpbill
            // 
            this.dpbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpbill.Location = new System.Drawing.Point(209, 202);
            this.dpbill.Name = "dpbill";
            this.dpbill.Size = new System.Drawing.Size(200, 26);
            this.dpbill.TabIndex = 4;
            this.dpbill.ValueChanged += new System.EventHandler(this.dpbill_ValueChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(138, 562);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(82, 29);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtbillno
            // 
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillno.Location = new System.Drawing.Point(206, 74);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(121, 26);
            this.txtbillno.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Bill No :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(83, 199);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(123, 22);
            this.Label8.TabIndex = 118;
            this.Label8.Text = "Date Of Bill  : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(132, 106);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 22);
            this.Label2.TabIndex = 117;
            this.Label2.Text = "Name :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(157, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(170, 39);
            this.Label1.TabIndex = 124;
            this.Label1.Text = " NEW BILL";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(206, 138);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(121, 26);
            this.txtamount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 125;
            this.label3.Text = "Amount :";
            // 
            // txtinterst
            // 
            this.txtinterst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinterst.Location = new System.Drawing.Point(206, 170);
            this.txtinterst.Name = "txtinterst";
            this.txtinterst.Size = new System.Drawing.Size(121, 26);
            this.txtinterst.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 127;
            this.label4.Text = "Interest:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddcutomer);
            this.panel1.Controls.Add(this.btncancle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtinterst);
            this.panel1.Controls.Add(this.txtbillno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.dpbill);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 603);
            this.panel1.TabIndex = 133;
            // 
            // ddcutomer
            // 
            this.ddcutomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddcutomer.FormattingEnabled = true;
            this.ddcutomer.Location = new System.Drawing.Point(206, 106);
            this.ddcutomer.Name = "ddcutomer";
            this.ddcutomer.Size = new System.Drawing.Size(233, 28);
            this.ddcutomer.TabIndex = 135;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btncancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(245, 562);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(82, 29);
            this.btncancle.TabIndex = 7;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dpcdate);
            this.panel2.Controls.Add(this.lbltotalinterst);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.lbltotalAmount);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 299);
            this.panel2.TabIndex = 134;
            // 
            // dpcdate
            // 
            this.dpcdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpcdate.Location = new System.Drawing.Point(251, 105);
            this.dpcdate.Name = "dpcdate";
            this.dpcdate.Size = new System.Drawing.Size(200, 26);
            this.dpcdate.TabIndex = 179;
            this.dpcdate.ValueChanged += new System.EventHandler(this.dpcdate_ValueChanged);
            // 
            // lbltotalinterst
            // 
            this.lbltotalinterst.AutoSize = true;
            this.lbltotalinterst.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalinterst.Location = new System.Drawing.Point(247, 149);
            this.lbltotalinterst.Name = "lbltotalinterst";
            this.lbltotalinterst.Size = new System.Drawing.Size(20, 22);
            this.lbltotalinterst.TabIndex = 178;
            this.lbltotalinterst.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(41, 149);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(200, 22);
            this.label22.TabIndex = 177;
            this.label22.Text = "Total Interest Amount :";
            // 
            // lbltotalAmount
            // 
            this.lbltotalAmount.AutoSize = true;
            this.lbltotalAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalAmount.Location = new System.Drawing.Point(247, 192);
            this.lbltotalAmount.Name = "lbltotalAmount";
            this.lbltotalAmount.Size = new System.Drawing.Size(20, 22);
            this.lbltotalAmount.TabIndex = 176;
            this.lbltotalAmount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(108, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 22);
            this.label14.TabIndex = 175;
            this.label14.Text = "Total Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 22);
            this.label10.TabIndex = 133;
            this.label10.Text = "Credit Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 39);
            this.label9.TabIndex = 166;
            this.label9.Text = "Credit Details";
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 603);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewInvoice";
            this.Text = "NewInvoice";
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpbill;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtbillno;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtamount;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinterst;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label lbltotalinterst;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label lbltotalAmount;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.DateTimePicker dpcdate;
        private System.Windows.Forms.ComboBox ddcutomer;
    }
}