using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using KhataBookSystem.App_Code;
using System.Configuration;
namespace KhataBookSystem.App_Code
{
    class BussinessLogic
    {
        OleDbConnection con;


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

        public string deletePaymentMaster(UserInterface obj)
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
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
        public string updatePaymentMaster(UserInterface obj)
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Payment_Master SET Name=@name,Interest=@intrest,BillDate=@billingdate,Amount=@amount,CreditDate=@creditdate,TotalInterestAmount=@totalinterst,Totalamount=@totalamount where BillNo=@billno";
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@intrest", obj.intrest);
                cmd.Parameters.AddWithValue("@billingdate", obj.billdate);
                cmd.Parameters.AddWithValue("@amount", obj.AmountPriceList);
                cmd.Parameters.AddWithValue("@creditdate", obj.CreditDate);
                cmd.Parameters.AddWithValue("@totalinterst", obj.TotalInterstAmount);
                cmd.Parameters.AddWithValue("@totalamount", obj.Totalamount);
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

        public DataTable GetPaymentDetailsData(UserInterface ui)
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select pm.BillNo,pm.Name,pm.BillDate,pm.CreditDate,pm.RemainingAmount,pm.Totalamount,pd.PayableAmount,pd.DateOfPayment,pm.TotalInterestAmount from Payment_Master as pm,Payment_Details as pd where pm.BillNo = pd.BillNo and pm.BillNo=?";
                cmd.Parameters.AddWithValue("@billno", ui.billno);

                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master where CreditDate=?";
                cmd.Parameters.AddWithValue("@Creditdate", ui.CreditDate);

                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }



        public DataTable GetBillData()
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master";
                da = new OleDbDataAdapter(cmd);
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master where Name=?";
                cmd.Parameters.AddWithValue("@Name", ui.Name);

                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master where BillNo=?";
                cmd.Parameters.AddWithValue("@BillNo", ui.billno);

                da = new OleDbDataAdapter(cmd);
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master where BillNo=?";
                cmd.Parameters.AddWithValue("@BillNo", ui.billno);

                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }

        public DataTable GetBillDataByBillDate(UserInterface ui)
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();

            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from Payment_Master where BillDate=?";
                cmd.Parameters.AddWithValue("@BillDate", ui.billdate);

                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                da.Dispose();

            }
            catch
            {

            }
            return dt;
        }
        //public int duplicateUser(UserInterface obj)
        //{
        //    Int32 _result = 0;

        //    con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    try
        //    {
        //        con.Open();
        //        cmd.CommandText = "Toll_SP";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@StatmatentType", "114");
        //        cmd.Parameters.AddWithValue("@Username", obj.username);
        //        cmd.Parameters.AddWithValue("@Password", obj.password);

        //        _result = Convert.ToInt32(cmd.ExecuteScalar());
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }



        //    return _result;
        //}

        //public string AddOpeatorScheduling(UserInterface obj)
        //{
        //    con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    try
        //    {
        //        con.Open();
        //        cmd.CommandText = "Toll_SP";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@StatmatentType", "115");
        //        cmd.Parameters.AddWithValue("@DateOfScheduling", obj.opretorScheduleDate);
        //        cmd.Parameters.AddWithValue("@shiftid", obj.shiftid);
        //        cmd.Parameters.AddWithValue("@boothid", obj.boothid);
        //        cmd.Parameters.AddWithValue("@Opretor_Id", obj.opretor_Id);

        //        // so on...
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            obj.msg = "0";
        //        }
        //        else
        //        {
        //            obj.msg = "1";
        //        }
        //        con.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        e.ToString();

        //    }
        //    return obj.msg;

        //}


        public string AddNewBill(UserInterface obj)
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Payment_Master (BillNo,Name,Interest,BillDate,Amount,CreditDate,TotalInterestAmount,Totalamount,RemainingAmount) values(?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.AddWithValue("@billno", obj.billno);
                cmd.Parameters.AddWithValue("@name", obj.Name);
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


        public string upadatePayment(UserInterface obj)
        {
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Payment_Details (BillNo,DateOfPayment,PayableAmount) values(?,?,?)";
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
            con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ToString());

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO Cheque_Master (ChequeNo,BankName,ChequeDate,Amount,BillNo) values(?,?,?,?,?)";
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
