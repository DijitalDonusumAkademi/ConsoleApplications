using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFrameworkWin.Context;
using EFrameworkWin.Dal;
using EFrameworkWin.Entities;

namespace EFrameworkWin
{
    public partial class Form1 : Form
    {
        ProductDal _productDal=new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillLoad();
        }

        private void FillLoad()
        {
            dataGridView.DataSource = _productDal.GetProducts();
            
        }

        private void Search(string key)
        {
            dataGridView.DataSource =
                _productDal.GetProducts().Where(a => a.Name.ToLower().Contains(key)).ToList();

        }

        private void Search2(string key)
        {
            dataGridView.DataSource =
                _productDal.GetByNameProducts(key.ToLower());

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = name.Text,
                Price = Convert.ToDecimal(price.Text),
                StockAmount = Convert.ToInt32(stockAmount.Text)
            };
            _productDal.Add(product);
            FillLoad();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Product updateProduct = new Product
            {
                Name = txtName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                StockAmount = Convert.ToInt32(txtStock.Text),
                Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString()),
            };

            _productDal.Update(updateProduct); FillLoad();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView.CurrentRow.Cells["Name"].Value.ToString();
            txtPrice.Text = dataGridView.CurrentRow.Cells["Price"].Value.ToString();
            txtStock.Text = dataGridView.CurrentRow.Cells["StockAmount"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Product deletedProduct = new Product
            {
                Name = txtName.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                StockAmount = Convert.ToInt32(txtStock.Text),
                Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString()),
            };

            _productDal.Delete(deletedProduct);
            FillLoad();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // Search(textBox1.Text.ToLower());
            Search2(textBox1.Text.ToLower());
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            //dataGridView.DataSource= _productDal.GetByNameProducts(txtAramaName.Text.ToString().ToLower());
            dataGridView.DataSource = _productDal.GetByPriceBetween(Convert.ToDecimal(txtAramaMin.Text.ToString()), Convert.ToDecimal(txtAramaMax.Text.ToString()));


        }
    }
}
