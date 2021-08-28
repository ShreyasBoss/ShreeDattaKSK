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
    public partial class NewInvoice : Form
    {
        private readonly Form1 form;
  
        public NewInvoice(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            try
            {


              
                if (ddcutomer.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER NAME", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ddcutomer.Focus();
                    
                }
                else if (txtbillno.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER BILL NO", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbillno.Focus();
                    
                }
              
                else if (txtamount.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER AMOUNT", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtamount.Focus();
                    
                }
                else
                {
                    if (dpcdate.Text == string.Empty || txtinterst.Text == string.Empty)
                    {
                        
                        txtinterst.Text = "0";
                        lbltotalAmount.Text = txtamount.Text;
                    }
                   
                 

                    userInterface.CustomerID = Convert.ToInt32(ddcutomer.SelectedValue);
                    userInterface.billno = txtbillno.Text;
                    userInterface.AmountPriceList = Convert.ToDouble(txtamount.Text);
                    userInterface.intrest = Convert.ToDouble(txtinterst.Text);
                  
                    userInterface.billdate = dpbill.Value.Date;
                    userInterface.CreditDate = dpcdate.Value;
                    userInterface.TotalInterstAmount = Convert.ToDouble(lbltotalinterst.Text);
                    userInterface.Totalamount = Convert.ToDouble(lbltotalAmount.Text);


                    //Int32 duplicat = businessLogic.duplicateUser(userInterface);
                    string msg = businessLogic.AddNewBill(userInterface);
                    if (msg == "0")
                    {
                        MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      

                    }
                    else
                    {
                        MessageBox.Show("Somthing Went Wrong...!");
                    }
                    form.getdata();
                    this.Close();



                }

            }
            catch (Exception es)
            {
                es.ToString();
            }

        }

       
        

        

        public void calculateInterst()
        {
            
            if (txtamount.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER AMOUNT", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtamount.Focus();

            }
            else if (txtinterst.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER INTERST", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtinterst.Focus();
            }
           
            else
            {
              
                string interst = (Convert.ToDouble(txtamount.Text) * Convert.ToDouble(txtinterst.Text) / 100).ToString("N2");
                string month = (((dpcdate.Value.Year - dpbill.Value.Year) * 12) + dpcdate.Value.Month - dpbill.Value.Month).ToString();

                string totalInterst = (Convert.ToDouble(interst) * Convert.ToDouble(month)).ToString("N2");
                string totalAmount = (Convert.ToDouble(totalInterst) + Convert.ToDouble(txtamount.Text)).ToString("N2");
                lbltotalinterst.Text = totalInterst;
     
                lbltotalAmount.Text = totalAmount;
            }
            
        }

        private void txtbilldate_TextChanged(object sender, EventArgs e)
        {
            calculateInterst();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dpbill_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dpcdate_ValueChanged(object sender, EventArgs e)
        {
            calculateInterst();
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            getCustomerForDD();

        }
        public void getCustomerForDD()
        {
            BussinessLogic bl = BussinessLogic.GetInstance;
            DataTable dt = new DataTable();
            dt = bl.getCustomerDD();
            ddcutomer.DataSource = dt;
            ddcutomer.DisplayMember = "Name";
            ddcutomer.ValueMember = "Id";
        }
    }
}
