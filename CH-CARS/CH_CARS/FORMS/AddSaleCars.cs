using CH_CARS.BL;
using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class AddSaleCars : Form
    {
        public AddSaleCars()
        {
            InitializeComponent();
        }

        private void AddSaleCars_Load(object sender, EventArgs e)
        {
            databind();
        }
        private void databind()
        {
            guna2DataGridView1.Rows.Clear();
            foreach (var v in SaleCarDL.SaleCars)
            {
                guna2DataGridView1.Rows.Add(v.GetCarName(), v.GetCarPrice(), v.GetCarModel(), v.GetCarCompany());
            }
            guna2DataGridView1.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SaleCar newCar = AddCar();
            if (newCar != null)
            {
                SaleCarDL.AddInList(newCar);
                SaleCarDL.StoreInFileSale();
                databind();
                ClearForm();
                MessageBox.Show("Car Added", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearForm();
        }
        private SaleCar AddCar()
        {
            string name = nameBox.Text;
            int price = int.Parse(priceBox.Text);
            string model = modelBox.Text;
            string company = companyBox.Text;

            bool validateName = CarDL.AlphabetValidation(name);
            bool validatePrice = CarDL.IntegerValidation(priceBox.Text);
            bool validatemodel = CarDL.AlphabetValidation(model);
            bool validatecompany = CarDL.AlphabetValidation(company);

            if (validateName && validatePrice && validatemodel && validatecompany)
            {
                SaleCar newCar = new SaleCar(name, price, model, company);
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
