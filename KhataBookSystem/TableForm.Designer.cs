namespace KhataBookSystem
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.grdBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.grdBill.Size = new System.Drawing.Size(1213, 545);
            this.grdBill.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 51);
            this.panel1.TabIndex = 5;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Blue;
            this.btncheck.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.Location = new System.Drawing.Point(521, 10);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(228, 29);
            this.btncheck.TabIndex = 118;
            this.btncheck.Text = "Update All Credit ";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1213, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdBill);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncheck;
    }
}