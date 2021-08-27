using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhataBookSystem.App_Code
{
    class UserInterface
    {
        private static int counter = 0;

        private static UserInterface instance = null;

        public static UserInterface GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new UserInterface();
                return instance;
            }
        }
        private UserInterface()
        {
            counter++;
        }

        public int ID { set; get; }
        public string billno { set; get; }

        public DateTime billdate { set; get; }


        public string msg { set; get; }


        public double intrest { set; get; }



        public double AmountPriceList { set; get; }

        public string Name { set; get; }

        

        public DateTime CreditDate { set; get; }

        public DateTime DateOfPayment { set; get; }

        public double TotalInterstAmount { set; get; }

        public double Totalamount { set; get; }

        public double PayableAmount { set; get; }

        public double ReamingAmount { set; get; }

        public string bankname { set; get; }

        public int chequeno { set; get; }

        public double chequeamount { set; get; }

        public DateTime chequeDate { set; get; }

    }

}
