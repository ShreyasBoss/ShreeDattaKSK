using KhataBookSystem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhataBookSystem
{
    public partial class TableForm : Form
    {
        DataTable dt = new DataTable();
        Double days;
        SqlCommand cmd = new SqlCommand();
        SqlConnection con;
        BussinessLogic bl = BussinessLogic.GetInstance;
        UserInterface ui = UserInterface.GetInstance;
        DataSet ds = new DataSet();
        private readonly Form1 form;
        public TableForm(Form1 frm)
        {
            form = frm;
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            getdata();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());
            cmd.Connection = con;
          


        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            updateall();
            form.getdata();
        }
        public void updateall()
        {
            if (ds.Tables != null)
            {
                con.Open();
                try
                {
                    ui.CreditDate = DateTime.Now.Date;
                    cmd.CommandText = "select cm.Name,pm.BillDate,pm.BillNo,pm.Interest,pm.Amount,pm.CreditDate,pm.TotalInterestAmount,pm.Totalamount,pm.RemainingAmount from Payment_Master as pm,Customer_Master as cm where pm.Name = cm.Id and pm.CreditDate=@Creditdate";
                    cmd.Parameters.AddWithValue("@Creditdate", ui.CreditDate);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ui.ReamingAmount = Convert.ToDouble(row["RemainingAmount"].ToString());
                        ui.Totalamount = Convert.ToDouble(row["Totalamount"].ToString());
                        ui.CreditDate = Convert.ToDateTime(row["CreditDate"].ToString()).Date;
                        ui.billdate = Convert.ToDateTime(row["BillDate"].ToString()).Date;
                        ui.TotalInterstAmount = Convert.ToDouble(row["TotalInterestAmount"].ToString());
                        ui.billno = row["BillNo"].ToString();
                        Double paidamount = ui.Totalamount - ui.ReamingAmount;
                        ui.Totalamount = ui.ReamingAmount + ui.TotalInterstAmount;
                        ui.ReamingAmount = ui.Totalamount - paidamount;

                        days = (ui.CreditDate - ui.billdate).TotalDays;
                        ui.CreditDate = ui.CreditDate.AddDays(days).Date;
                        ui.billdate = DateTime.Now.Date;
                        SqlCommand cmd2 = new SqlCommand("UPDATE Payment_Master SET Amount = @amount, CreditDate = @creditdate, BillDate = @billingdate, Totalamount = @amount, RemainingAmount=@reamingamount  where BillNo = @billno", con);
                        cmd2.Parameters.AddWithValue("@amount", ui.Totalamount);
                        cmd2.Parameters.AddWithValue("@creditdate", ui.CreditDate);
                        cmd2.Parameters.AddWithValue("@billingdate", ui.billdate);
                        cmd2.Parameters.AddWithValue("@reamingamount", ui.ReamingAmount);
                        cmd2.Parameters.AddWithValue("@billno", ui.billno);

                        int a = cmd2.ExecuteNonQuery();
                    }
                    form.getdata();
                    MessageBox.Show("Data Updated....!!!");
                    this.Close();

                }
                catch (Exception e)
                {
                    e.ToString();
                }
                finally
                {

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("No Data For Update...!!!");
                this.Close();
            }
           

        }
        public void getdata()
        {
            BussinessLogic bl = BussinessLogic.GetInstance;
            UserInterface ui = UserInterface.GetInstance;
          
            ui.CreditDate = DateTime.Now.Date;
            dt = bl.GetBillDataByCreditDate(ui);
            grdBill.DataSource = dt;

        }
    }
}
