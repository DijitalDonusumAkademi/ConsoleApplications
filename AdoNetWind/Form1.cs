using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetWind.Dal;
using AdoNetWind.Entities;

namespace AdoNetWind
{
    public partial class Form1 : Form
    {
        ProductDal productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTheForm();
        }

        private void FillTheForm()
        {
            dataGridView.DataSource = productDal.GetAllList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product=new Product
            {
                Name = name.Text,
                Price = Convert.ToDecimal(price.Text),
                StockAmount =Convert.ToInt32(stockAmount.Text)
            };

            productDal.Add(product);
            MessageBox.Show("Ekleme işlemi yapıldı");
            FillTheForm();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Product updateProduct=new Product
            {
                Name = txtName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                StockAmount = Convert.ToInt32(txtStock.Text),
                Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString()),
            };

            productDal.Update(updateProduct);
            FillTheForm();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView.CurrentRow.Cells["Name"].Value.ToString();
            txtPrice.Text = dataGridView.CurrentRow.Cells["Price"].Value.ToString();
            txtStock.Text = dataGridView.CurrentRow.Cells["StockAmount"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Product deleteProduct = new Product
            {
                Name = txtName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                StockAmount = Convert.ToInt32(txtStock.Text),
                Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString()),
            };

            productDal.Delete(deleteProduct);
            FillTheForm();
        }
    }
}
