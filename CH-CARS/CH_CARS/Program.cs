using CH_CARS.DL;
using CH_CARS.FORMS;
using System;
using System.Windows.Forms;

namespace CH_CARS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool check1 = MUserDL.ReadFromUserFile();
            bool check2 = SaleCarDL.ReadFromSaleFile();
            bool check3 = RentCarDL.ReadFromRentFile();

            if (check1 && check2 && check3) { }
            else
                MessageBox.Show("Data NOT Loaded", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}
