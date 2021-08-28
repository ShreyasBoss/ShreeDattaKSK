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
    public partial class Form1 : Form
    {
        public static DataGridViewRow SelectedRow { get; set; }
        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getdata();
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


        private void btncancel_Click(object sender, EventArgs e)
        {
            NewInvoice newInvoice = new NewInvoice(this);
            newInvoice.Show();
            getdata();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbillno.Text != string.Empty)
            {
                try
                {
                    BussinessLogic bl = BussinessLogic.GetInstance;
                    UserInterface ui = UserInterface.GetInstance;
                    DataTable dt = new DataTable();
                    ui.billno = txtbillno.Text;
                    dt = bl.GetBillDataByBillNo(ui);
                    grdBill.DataSource = dt;
                }
                catch (Exception a)
                {
                    a.ToString();
                }
            }
            else if (ddcutomer.Text != string.Empty)
            {
                try
                {
                    BussinessLogic bl = BussinessLogic.GetInstance;
                    UserInterface ui = UserInterface.GetInstance;
                    DataTable dt = new DataTable();
                    ui.CustomerID = Convert.ToInt32(ddcutomer.SelectedValue);
                    dt = bl.GetBillDataByName(ui);
                    grdBill.DataSource = dt;
                }
                catch (Exception a)
                {
                    a.ToString();
                }
            }
         
         
        }

        public void getdata()
        {
            BussinessLogic bl = BussinessLogic.GetInstance;
            DataTable dt = new DataTable();
            dt = bl.GetBillData();
            grdBill.DataSource = dt;
            

        }

        private void grdBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserInterface userInterface = UserInterface.GetInstance;
            if (e.RowIndex >= 0)
            {
                //Set the Selected Row in Property.
                SelectedRow = grdBill.Rows[e.RowIndex];
                string BillNo = SelectedRow.Cells["BillNo"].Value.ToString();
                userInterface.billno = BillNo;
                EditInvoice editInvoice = new EditInvoice(this);
                editInvoice.Show();
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            TableForm tf = new TableForm(this);
            tf.Show();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            grdBill.SelectAll();
            DataObject dataObj = grdBill.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.Show();
        }

      
    }
}
