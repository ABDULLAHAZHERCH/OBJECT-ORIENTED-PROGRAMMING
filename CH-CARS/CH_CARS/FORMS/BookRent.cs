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
    public partial class BookRent : Form
    {
        public BookRent()
        {
            InitializeComponent();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;

            RentCar Car = RentCarDL.FindCarinList(name);

            if (Car != null)
            {
                DialogResult result = MessageBox.Show("Car Found Do you want to book this car for rent", "CH_CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Bill bill = new Bill(Car.GetCarName(), Car.GetCarPrice().ToString(), Car.GetCarModel(), Car.GetCarCompany());
                    bill.Show();
                    RentCarDL.RemoveFromList(Car);
                    RentCarDL.StoreInFileRent();
                }
            }
            else
                MessageBox.Show("Car NOT Found", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nameBox.Text = string.Empty;
        }

        private void BookRent_Load(object sender, EventArgs e)
        {

        }
    }
}
