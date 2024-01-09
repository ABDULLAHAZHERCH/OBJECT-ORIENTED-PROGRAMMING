using CH_CARS.BL;
using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class UpdateRentCars : Form
    {
        RentCar car;
        public UpdateRentCars()
        {
            InitializeComponent();
        }

        private void UpdateRentCars_Load(object sender, EventArgs e)
        {
            dataBind();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int price = int.Parse(priceBox.Text);
            string model = modelBox.Text;
            string company = companyBox.Text;

            car.SetCarName(name);
            car.SetCarPrice(price);
            car.SetCarModel(model);
            car.SetCarCompany(company);
            RentCarDL.StoreInFileRent();
            dataBind();
            MessageBox.Show("Info Updated", "CH_CARS");
            ClearForm();
        }
        private void dataBind()
        {
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = RentCarDL.RentCars;
            guna2DataGridView1.Refresh();
        }
        private void ClearForm()
        {
            nameBox.Text = string.Empty;
            priceBox.Text = string.Empty;
            modelBox.Text = string.Empty;
            companyBox.Text = string.Empty;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RentCarDL.RemoveFromList(car);
            RentCarDL.StoreInFileRent();
            dataBind();
            ClearForm();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            car = (RentCar)guna2DataGridView1.CurrentRow.DataBoundItem;
            if (guna2DataGridView1.Columns["Select"].Index == e.ColumnIndex)
            {
                nameBox.Text = car.GetCarName();
                priceBox.Text = (car.GetCarPrice()).ToString();
                modelBox.Text = car.GetCarModel();
                companyBox.Text = car.GetCarCompany();
            }
        }
    }
}
