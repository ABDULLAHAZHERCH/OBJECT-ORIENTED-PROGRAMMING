using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class RentCars : Form
    {
        public RentCars()
        {
            InitializeComponent();
        }
        private void RentCars_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = null;
            foreach (var v in RentCarDL.RentCars)
            {
                guna2DataGridView1.Rows.Add(v.GetCarName(), v.GetCarPrice(), v.GetCarModel(), v.GetCarCompany());
            }
            guna2DataGridView1.Refresh();
        }

    }
}
