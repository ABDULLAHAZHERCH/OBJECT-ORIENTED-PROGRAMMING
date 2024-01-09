using CH_CARS.BL;
using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class RentACar : Form
    {
        public RentACar()
        {
            InitializeComponent();
        }

        private void RentACar_Load(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;

            RentCar Car = RentCarDL.FindCarinList(name);

            if (Car != null)
            {
                DialogResult result = MessageBox.Show("Car Found Do you want to RENT this car", "CH_CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Bill bill = new Bill(Car.GetCarName(), Car.GetCarPrice().ToString(),Car.GetCarModel(), Car.GetCarCompany());
                    bill.Show();
                    RentCarDL.RemoveFromList(Car);
                    RentCarDL.StoreInFileRent();
                }
            }
            else
                MessageBox.Show("Car NOT Found", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nameBox.Text = string.Empty;
        }
    }
}
