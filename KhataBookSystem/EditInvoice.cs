using KhataBookSystem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhataBookSystem
{
    public partial class EditInvoice : Form
    {
        string totalAmount;
        string totalInterst;
        string Interst;
        private readonly Form1 frm1;
        public EditInvoice(Form1 form)
        {
            InitializeComponent();
            frm1 = form;
        }

        private void EditInvoice_Load(object sender, EventArgs e)
        {
            getdataForUpdate();
        }
        public void getdataForUpdate()
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            DataTable dt = new DataTable();
            try
            {
                dt = businessLogic.getManageInvoice(userInterface);
                txtbillno.Text = dt.Rows[0][1].ToString();
                txtName.Text = dt.Rows[0][2].ToString();
                txtinterst.Text = dt.Rows[0][3].ToString();
                dpbill.Value = Convert.ToDateTime(dt.Rows[0][4]);
                txtamount.Text = dt.Rows[0][5].ToString();
                dpcredit.Value = Convert.ToDateTime(dt.Rows[0][6]);
                lbltotalinterst.Text = dt.Rows[0][7].ToString();
                lbltotalAmount.Text = dt.Rows[0][8].ToString();
                lblremeningamount.Text = dt.Rows[0][9].ToString();
              
                lblamount.Text = dt.Rows[0][5].ToString();
                lblintrest.Text = dt.Rows[0][3].ToString();
               totalInterst = dt.Rows[0][7].ToString();
               totalAmount = dt.Rows[0][8].ToString();

            }
            catch(Exception e)
            {
                e.ToString();
            }
        }
       

       

        private void txtPaybalAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaybalAmount.Text == string.Empty)
            {
                txtPaybalAmount.Text = "0";
            }

            if(Convert.ToDouble(lblremeningamount.Text)> 0)
            {
                
                if (Convert.ToDouble(lblremeningamount.Text) >= Convert.ToDouble(txtPaybalAmount.Text))
                {
                    string result = (Convert.ToDouble(lblremeningamount.Text) - Convert.ToDouble(txtPaybalAmount.Text)).ToString("N2");
                    lblremaning1.Text = result;
                }
                else
                {
                    MessageBox.Show("Reaming Amount Should be Greater Than Paying Amount");
                    btnmisave.Visible = false;
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Reaming Amount Should be Greater Than Zero");
                btnmisave.Visible = false;
                this.Close();
            }

          


        }

        private void btnmisave_Click(object sender, EventArgs e)
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            try
            {


                if (txtPaybalAmount.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER AMOUNT", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaybalAmount.Focus();

                }
              
                else if (dppayment.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER Date", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dppayment.Focus();
                }
                else
                {
                  
                    userInterface.billno = txtbillno.Text;
                    userInterface.PayableAmount = Convert.ToDouble(txtPaybalAmount.Text);
                    userInterface.DateOfPayment = dppayment.Value.Date;
                  


                    //Int32 duplicat = businessLogic.duplicateUser(userInterface);
                    string msg = businessLogic.AddNewBillDetails(userInterface);
                    if (msg == "0")
                    {
                        MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Somthing Went Wrong...!");
                    }

                    userInterface.ReamingAmount = Convert.ToDouble(lblremaning1.Text);
                    string s = businessLogic.upadatePayment(userInterface);
                    frm1.getdata();

                    this.Close();



                }

            }
            catch (Exception es)
            {
                es.ToString();
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            txtbillno.Enabled = true;
            txtName.Enabled = true;
            txtamount.Enabled = true;
            txtinterst.Enabled = true;
          
            dpbill.Enabled = true;
            dpcredit.Enabled = true;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;

        }

        private void btncheequesave_Click(object sender, EventArgs e)
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            try
            {


                if (txtchequeno.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER CHEQUE NO", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaybalAmount.Focus();

                }

                else if (txtbankName.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER BANK NAME", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dppayment.Focus();
                }
                else if (txtchequeamount.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER AMOUNT", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dppayment.Focus();
                }
                else if (dpchequedate.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER CHEQUE DATE", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dppayment.Focus();
                }
                else
                {

                    userInterface.billno = txtbillno.Text;
                    userInterface.chequeno = Convert.ToInt32(txtPaybalAmount.Text);
                    userInterface.bankname = txtbankName.Text;
                    userInterface.chequeamount=Convert.ToDouble(txtchequeamount.Text);
                    userInterface.chequeDate= dpchequedate.Value.Date;



                    //Int32 duplicat = businessLogic.duplicateUser(userInterface);
                    string msg = businessLogic.AddNewCheque(userInterface);
                    if (msg == "0")
                    {
                        MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Somthing Went Wrong...!");
                    }

                    userInterface.TotalInterstAmount = Convert.ToDouble(lbltotalinterst.Text);

                    userInterface.ReamingAmount = Convert.ToDouble(lblremeningamount.Text);
                    string s = businessLogic.upadatePayment(userInterface);
                    frm1.getdata();

                  



                }

            }
            catch (Exception es)
            {
                es.ToString();
            }
        }

        private void btnprivew_Click(object sender, EventArgs e)
        {
            UserInterface ui = UserInterface.GetInstance;
            ui.billno = txtbillno.Text;
            PaymentDetails pd = new PaymentDetails();
            pd.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            BussinessLogic businessLogic = BussinessLogic.GetInstance;
            UserInterface userInterface = UserInterface.GetInstance;
            try
            {



                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("PLEASE ENTER NAME", "M E S S A G E", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();

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
                   


                    userInterface.Name = txtName.Text;
                    userInterface.billno = txtbillno.Text;
                    userInterface.AmountPriceList = Convert.ToDouble(txtamount.Text);
                    userInterface.intrest = Convert.ToDouble(txtinterst.Text);
                    userInterface.TotalInterstAmount = Convert.ToDouble(totalInterst);
                    userInterface.Totalamount = Convert.ToDouble(totalAmount);
                    userInterface.billdate = dpbill.Value.Date;
                    userInterface.CreditDate = dpcredit.Value.Date;
               


                    //Int32 duplicat = businessLogic.duplicateUser(userInterface);
                    string msg = businessLogic.updatePaymentMaster(userInterface);
                    if (msg == "0")
                    {
                        MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Somthing Went Wrong...!");
                    }

                    frm1.getdata();
                    this.Close();

                }

            }
            catch (Exception es)
            {
                es.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneditcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmicancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            BussinessLogic bl = BussinessLogic.GetInstance;
            UserInterface ui = UserInterface.GetInstance;
            ui.billno = txtbillno.Text;
          string msg =  bl.deletePaymentMaster(ui);
            if (msg == "0")
            {
                MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frm1.getdata();

            }
            else
            {
                MessageBox.Show("Somthing Went Wrong...!");
                frm1.getdata();
            }

        }

        private void dpinterst_ValueChanged(object sender, EventArgs e)
        {
            Double days = (dpinterst.Value.Date - dpbill.Value.Date).TotalDays;
            Double month = (dpcredit.Value.Date - dpbill.Value.Date).TotalDays;
            lblitd.Text = (Convert.ToDouble(lbltotalinterst.Text) * days/month).ToString("N2");
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            if (txtamount.Enabled == true)
            {
                if (txtamount.Text == "")
                {
                    txtamount.Text = "0";
                    calculateInterst();
                }
                else
                {
                    calculateInterst();
                }

            }
            
        }

        private void txtinterst_TextChanged(object sender, EventArgs e)
        {
            if (txtinterst.Enabled == true)
            {
                if (txtinterst.Text == "")
                {
                    txtinterst.Text = "0";
                   
                }
                else
                {
                    calculateInterst();
                }
                
            }
           
        }
        public void calculateInterst()
        {
            String dateofcredit = dpcredit.Value.Date.ToString();
             Interst = (Convert.ToDouble(txtamount.Text) * Convert.ToDouble(txtinterst.Text) / 100).ToString("N2");
            string month = (((Convert.ToDateTime(dateofcredit).Year - dpbill.Value.Year) * 12) + Convert.ToDateTime(dateofcredit).Month - dpbill.Value.Month).ToString();
            totalInterst = (Convert.ToDouble(Interst) * Convert.ToDouble(month)).ToString("N2");
             totalAmount = (Convert.ToDouble(totalInterst) + Convert.ToDouble(txtamount.Text)).ToString("N2");
          
        }
    }
}
