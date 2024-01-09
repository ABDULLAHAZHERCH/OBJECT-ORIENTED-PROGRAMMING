using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class SaleCars : Form
    {
        public SaleCars()
        {
            InitializeComponent();
        }

        private void SaleCars_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = null;
            foreach (var v in SaleCarDL.SaleCars)
            {
                guna2DataGridView1.Rows.Add(v.GetCarName(), v.GetCarPrice(), v.GetCarModel(), v.GetCarCompany());
            }
            guna2DataGridView1.Refresh();
        }
    }
}
