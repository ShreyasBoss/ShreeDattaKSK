using KhataBookSystem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhataBookSystem
{
    public partial class PaymentDetails : Form
    {
        PrintDocument pdoc = null;
        DataTable dt = new DataTable();
        BussinessLogic bl = BussinessLogic.GetInstance;
        UserInterface ui = UserInterface.GetInstance;
        public PaymentDetails()
        {
            InitializeComponent();
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            getdata();
        }

        public void getdata()
        {
          
           
            dt = bl.GetPaymentDetailsData(ui);
            grdBill.DataSource = dt;

        }

       
        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dt.Rows == null)
            {
                MessageBox.Show("No Data For Print...!");
                this.Close();
            }
            else
            {
                print();

            }
        }
        
        
        

        
        
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            ui.Totalamount = 0;
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            graphics.DrawString("Shridatta KSK, Umadi", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("PRN:" + dt.Rows[0][11].ToString(),
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Customer Name:" + dt.Rows[0][8].ToString(),
                  new Font("Courier New", 10),
                  new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Contact No:" + dt.Rows[0][9].ToString(),
                 new Font("Courier New", 10),
                 new SolidBrush(Color.Black), startX, startY + Offset);
           
            Offset = Offset + 20;
            graphics.DrawString("Bill No:" + dt.Rows[0][0].ToString(),
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Billing Date :" + Convert.ToDateTime(dt.Rows[0][1]).ToShortDateString(),
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Credit Date :" + Convert.ToDateTime(dt.Rows[0][2]).ToShortDateString(),
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String amount = "Total Amount : " + dt.Rows[0][4].ToString();

            graphics.DrawString(amount, new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;
            String interst = "Interest Percentage : " + dt.Rows[0][12].ToString();

            graphics.DrawString(interst, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String interstAmount = "Interest Amount : " + dt.Rows[0][7].ToString();

            graphics.DrawString(interstAmount, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;
             underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Date Of Payment",
                    new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + Offset );

            graphics.DrawString("Amount",
                  new Font("Courier New", 10),
                  new SolidBrush(Color.Black), startX + Offset, startY + Offset);

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);


            foreach (DataRow row in dt.Rows)
            {
                Offset = Offset + 20;
                graphics.DrawString(Convert.ToDateTime(row["DateOfPayment"]).ToShortDateString(),
                        new Font("Courier New", 10),
                        new SolidBrush(Color.Black), startX, startY + Offset);

                graphics.DrawString(row["PaybleAmount"].ToString(),
                      new Font("Courier New", 10),
                      new SolidBrush(Color.Black), startX + 200, startY + Offset);
                ui.Totalamount += Convert.ToDouble(row["PaybleAmount"]);
            }

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Total Amount Paid :"+ ui.Totalamount.ToString("N2"),
                  new Font("Courier New", 12),
                  new SolidBrush(Color.Black), startX , startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Remaining Amount :" + dt.Rows[0][3].ToString(),
                 new Font("Courier New", 12),
                 new SolidBrush(Color.Black), startX , startY + Offset);


            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Address:" + dt.Rows[0][10].ToString().Trim(),
                 new Font("Courier New", 10),
                 new SolidBrush(Color.Black), startX, startY + Offset);

        }

    }
}
