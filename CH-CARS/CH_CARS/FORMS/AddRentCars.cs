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
    public partial class AddRentCars : Form
    {
        public AddRentCars()
        {
            InitializeComponent();
        }

        private void AddRentCars_Load(object sender, EventArgs e)
        {
            databind();
        }
        private void databind()
        {
            guna2DataGridView1.Rows.Clear();
            foreach (var v in RentCarDL.RentCars)
            {
                guna2DataGridView1.Rows.Add(v.GetCarName(), v.GetCarPrice(), v.GetCarModel(), v.GetCarCompany());
            }
            guna2DataGridView1.Refresh();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            RentCar newCar = AddCar();
            if (newCar != null)
            {
                RentCarDL.AddInList(newCar);
                RentCarDL.StoreInFileRent();
                databind();
                ClearForm();
                MessageBox.Show("Car Added", "CH_CARS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ClearForm();
        }
        private RentCar AddCar()
        {
            string name = nameBox.Text;
            int rent = int.Parse(priceBox.Text);
            string model = modelBox.Text;
            string company = companyBox.Text;

            bool validateName = CarDL.AlphabetValidation(name);
            bool validatePrice = CarDL.IntegerValidation(priceBox.Text);
            bool validatemodel = CarDL.AlphabetValidation(model);
            bool validatecompany = CarDL.AlphabetValidation(company);

            if (validateName && validatePrice && validatemodel && validatecompany)
            {
                RentCar newCar = new RentCar(name, rent, model, company);
                return newCar;
            }
            MessageBox.Show("Enter Valid Information", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        private void ClearForm()
        {
            nameBox.Text = string.Empty;
            priceBox.Text = string.Empty;
            modelBox.Text = string.Empty;
            companyBox.Text = string.Empty;
        }
    }
}
