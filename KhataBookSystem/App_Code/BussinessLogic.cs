using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KhataBookSystem.App_Code;
using System.Configuration;
namespace KhataBookSystem.App_Code
{
    class BussinessLogic
    {
        SqlConnection con;


        // DataSet ds;
        private static BussinessLogic instance = null;

        public static BussinessLogic GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new BussinessLogic();
                return instance;
            }
        }

        public BussinessLogic()
        {


        }

        //delete payment or bill
        public string deletePaymentMaster(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM Payment_Master where BillNo=@billno";
              
                cmd.Parameters.AddWithValue("@billno", obj.billno);



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;
        }


        //delete cutomer

        public string deleteCustomer(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM Customer_Master where Id=@id";

                cmd.Parameters.AddWithValue("@id", obj.CustomerID);



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;
        }

        //update payment or bill
        public string updatePaymentMaster(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Payment_Master SET Name=@name,Interest=@intrest,BillDate=@billingdate,Amount=@amount,CreditDate=@creditdate,TotalInterestAmount=@totalinterst,Totalamount=@totalamount,RemainingAmount=@remainingamount  where BillNo=@billno";
                cmd.Parameters.AddWithValue("@name", obj.CustomerID);
                cmd.Parameters.AddWithValue("@intrest", obj.intrest);
                cmd.Parameters.AddWithValue("@billingdate", obj.billdate);
                cmd.Parameters.AddWithValue("@amount", obj.AmountPriceList);
                cmd.Parameters.AddWithValue("@creditdate", obj.CreditDate);
                cmd.Parameters.AddWithValue("@totalinterst", obj.TotalInterstAmount);
                cmd.Parameters.AddWithValue("@totalamount", obj.Totalamount);
                cmd.Parameters.AddWithValue("@remainingamount", obj.ReamingAmount);
                cmd.Parameters.AddWithValue("@billno", obj.billno);



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;
        }

        public string updateCustomer(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Customer_Master SET Name=@name,ContactNo=@contanctno,Address=@address where Id=@id";
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@contanctno", obj.contactno);
                cmd.Parameters.AddWithValue("@address", obj.address);
                cmd.Parameters.AddWithValue("@id", obj.CustomerID);



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;
        }

        public DataTable GetPaymentDetailsData(UserInterface ui)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select pm.BillNo,pm.BillDate,pm.CreditDate,pm.RemainingAmount,pm.Totalamount,pd.PaybleAmount,pd.DateOfPayment,pm.TotalInterestAmount,cm.Name,cm.ContactNo,cm.Address,cm.Id,pm.Interest from Payment_Master as pm,Payment_Details as pd,Customer_Master as cm  where pm.BillNo = pd.BillNo and pm.Name=cm.Id and pm.BillNo=@billno";
                cmd.Parameters.AddWithValue("@billno", ui.billno);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
         string a =       dt.Rows.Count.ToString();
                da.Dispose();

            }
            catch(Exception e)
            {
                e.ToString();
            }
            return dt;
        }


        public string updateDayliyCredit(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Payment_Master SET Amount=@amount,CreditDate=@creditdate,BillDate=@billingdate,Totalamount=@totalamount  where BillNo=@billno";

                cmd.Parameters.AddWithValue("@creditdate", obj.CreditDate);
                cmd.Parameters.AddWithValue("@billingdate", obj.billdate);
                cmd.Parameters.AddWithValue("@totalamount", obj.Totalamount);
                cmd.Parameters.AddWithValue("@amount", obj.ReamingAmount);
                cmd.Parameters.AddWithValue("@billno", obj.billno);



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;
        }


        public DataTable GetBillDataByCreditDate(UserInterface ui)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select cm.Name,pm.BillNo,pm.Interest,pm.Amount,pm.CreditDate,pm.TotalInterestAmount,pm.Totalamount,pm.RemainingAmount from Payment_Master as pm,Customer_Master as cm where pm.Name = cm.Id and pm.CreditDate=@Creditdate";
                cmd.Parameters.AddWithValue("@Creditdate", ui.CreditDate);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }


        public DataTable GetCustomerData()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Customer_Master";
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
               

                da.Dispose();

            }
            catch (Exception e)
            {
                e.ToString();
            }
            return dt;
        }

        public DataTable GetBillData()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select cm.Name,pm.BillNo,pm.Interest,pm.Amount,pm.CreditDate,pm.TotalInterestAmount,pm.Totalamount,pm.RemainingAmount from Payment_Master as pm,Customer_Master as cm where pm.Name = cm.Id";
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dt.Rows.Count.ToString();

                da.Dispose();

            }
            catch(Exception e)
            {
                e.ToString();
            }
            return dt;
        }


        public DataTable GetBillDataByName(UserInterface ui)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select cm.Name,pm.BillNo,pm.Interest,pm.Amount,pm.CreditDate,pm.TotalInterestAmount,pm.Totalamount,pm.RemainingAmount from Payment_Master as pm,Customer_Master as cm where pm.Name = cm.Id and cm.Id =@Name";
                cmd.Parameters.AddWithValue("@Name", ui.CustomerID);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
              string a =  dt.Rows.Count.ToString();
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }

        public DataTable GetBillDataByBillNo(UserInterface ui)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select cm.Name,pm.BillNo,pm.Interest,pm.Amount,pm.CreditDate,pm.TotalInterestAmount,pm.Totalamount,pm.RemainingAmount from Payment_Master as pm,Customer_Master as cm where  cm.Id=pm.Name and BillNo=@BillNo";
                cmd.Parameters.AddWithValue("@BillNo", ui.billno);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }
        

              public DataTable getManageInvoice(UserInterface ui)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master where BillNo=@BillNo";
                cmd.Parameters.AddWithValue("@BillNo", ui.billno);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }


        public DataTable getManageCustomer(UserInterface ui)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Customer_Master where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", ui.CustomerID);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }

        public DataTable getCustomerDD()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select Id,Name from Customer_Master ";
             

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }

  


        public string AddNewBill(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Payment_Master (BillNo,Name,Interest,BillDate,Amount,CreditDate,TotalInterestAmount,Totalamount,RemainingAmount) values(@billno,@name,@intrest,@billdate,@amount,@creditdate,@totalinterstamount,@totalamount,@remaingamount)";
                cmd.Parameters.AddWithValue("@billno", obj.billno);
                cmd.Parameters.AddWithValue("@name", obj.CustomerID);
                cmd.Parameters.AddWithValue("@intrest", obj.intrest);
                cmd.Parameters.AddWithValue("@billdate", obj.billdate);
                cmd.Parameters.AddWithValue("@amount", obj.AmountPriceList);
                cmd.Parameters.AddWithValue("@creditdate", obj.CreditDate);
                cmd.Parameters.AddWithValue("@totalinterstamount", obj.TotalInterstAmount);
                cmd.Parameters.AddWithValue("@totalamount", obj.Totalamount);
                cmd.Parameters.AddWithValue("@remaingamount", obj.Totalamount);
             
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;

        }

        //add new customer 
        public string AddNewCustomer(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Customer_Master (ID,Name,ContactNo,Address) values(@id,@name,@contact,@address)";
                cmd.Parameters.AddWithValue("@id", obj.CustomerID);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@contact", obj.contactno);
                cmd.Parameters.AddWithValue("@address", obj.address);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;

        }


        public string upadatePayment(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Payment_Master SET RemainingAmount=@reamingamount  where BillNo=@billno";
               
              
                cmd.Parameters.AddWithValue("@reamingamount", obj.ReamingAmount);
                cmd.Parameters.AddWithValue("@billno", obj.billno);



                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;
        }

        public string AddNewBillDetails(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Payment_Details (BillNo,DateOfPayment,PaybleAmount) values(@billno,@dateofpayment,@payableamount)";
                cmd.Parameters.AddWithValue("@billno", obj.billno);
                cmd.Parameters.AddWithValue("@dateofpayment", obj.DateOfPayment);
                cmd.Parameters.AddWithValue("@payableamount", obj.PayableAmount);
               
            

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;

        }

        public string AddNewCheque(UserInterface obj)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Cheque_Master (ChequeNo,BankName,ChequeDate,Amount,BillNo) values(@chequeno,@bankname,@chequedate,@amount,@billno)";
                cmd.Parameters.AddWithValue("@chequeno", obj.chequeno);
                cmd.Parameters.AddWithValue("@bankname", obj.bankname);
                cmd.Parameters.AddWithValue("@chequedate", obj.chequeDate);
                cmd.Parameters.AddWithValue("@amount", obj.chequeamount);
                cmd.Parameters.AddWithValue("@billno", obj.billno);




                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    obj.msg = "0";
                }
                else
                {
                    obj.msg = "1";
                }
                con.Close();

            }
            catch (Exception e)
            {
                e.ToString();

            }
            return obj.msg;

        }


    }
}
