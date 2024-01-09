using CH_CARS.BL;
using CH_CARS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class BookBuy : Form
    {
        public BookBuy()
        {
            InitializeComponent();
        }
        private void BookBuy_Load(object sender, EventArgs e)
        {

        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;

            SaleCar saleCar = SaleCarDL.FindCarinList(name);

            if (saleCar != null)
            {
                DialogResult result = MessageBox.Show("Car Found Do you want to book this car for Buying", "CH_CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Bill bill = new Bill(saleCar.GetCarName(), saleCar.GetCarPrice().ToString(), saleCar.GetCarModel(), saleCar.GetCarCompany());
                    bill.Show();
                    SaleCarDL.RemoveFromList(saleCar);
                    SaleCarDL.StoreInFileSale();
                }
            }
            else
                MessageBox.Show("Car NOT Found", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nameBox.Text = string.Empty;
        }
    }
}
