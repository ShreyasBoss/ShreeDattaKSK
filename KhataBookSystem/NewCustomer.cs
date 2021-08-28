using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhataBookSystem.App_Code;

namespace KhataBookSystem
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }
        public static DataGridViewRow SelectedRow { get; set; }
        private void btnsave_Click(object sender, EventArgs e)
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            try
            {



                if (txtid.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER PRN", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Focus();

                }
                else if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER NAME", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();

                }
                else
                {
                    



                    userInterface.CustomerID = Convert.ToInt32(txtid.Text);
                    userInterface.Name = txtName.Text;
                    userInterface.contactno = txtcontact.Text;
                    userInterface.address = txtaddress.Text;
                


                    //Int32 duplicat = businessLogic.duplicateUser(userInterface);
                    string msg = businessLogic.AddNewCustomer(userInterface);
                    if (msg == "0")
                    {
                        MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Somthing Went Wrong...!");
                    }
                  
                    



                }

            }
            catch (Exception es)
            {
                es.ToString();
            }
            getdata();
            cls();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            BussinessLogic bl = BussinessLogic.GetInstance;
            DataTable dt = new DataTable();
            dt = bl.GetCustomerData();
            grdCustomer.DataSource = dt;


        }

        private void grdCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserInterface userInterface = UserInterface.GetInstance;
            if (e.RowIndex >= 0)
            {
                //Set the Selected Row in Property.
                SelectedRow = grdCustomer.Rows[e.RowIndex];
                string id = SelectedRow.Cells["Id"].Value.ToString();
                userInterface.CustomerID = Convert.ToInt32(id);

                getdataForUpdate();
            }
        }

        public void getdataForUpdate()
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            DataTable dt = new DataTable();
            try
            {
                dt = businessLogic.getManageCustomer(userInterface);
                txtid.Text = dt.Rows[0][0].ToString();
                txtName.Text = dt.Rows[0][1].ToString();
                txtcontact.Text = dt.Rows[0][2].ToString();
                txtaddress.Text = dt.Rows[0][3].ToString();
              

            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateData() {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            try
            {



                if (txtid.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER PRN", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Focus();

                }
                else if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER NAME", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();

                }
                else
                {




                    userInterface.CustomerID = Convert.ToInt32(txtid.Text);
                    userInterface.Name = txtName.Text;
                    userInterface.contactno = txtcontact.Text;
                    userInterface.address = txtaddress.Text;



                    //Int32 duplicat = businessLogic.duplicateUser(userInterface);
                    string msg = businessLogic.updateCustomer(userInterface);
                    if (msg == "0")
                    {
                        MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Somthing Went Wrong...!");
                    }





                }

            }
            catch (Exception es)
            {
                es.ToString();
            }
            getdata();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
            cls();
        }
        public void cls()
        {
            txtid.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtName.Text = "";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            BussinessLogic bl = BussinessLogic.GetInstance;
            UserInterface ui = UserInterface.GetInstance;
            ui.CustomerID = Convert.ToInt32(txtid.Text);
            string msg = bl.deleteCustomer(ui);
            if (msg == "0")
            {
                MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                getdata();

            }
            else
            {
                MessageBox.Show("Somthing Went Wrong...!");
               
            }
            cls();
        }
    }
}
