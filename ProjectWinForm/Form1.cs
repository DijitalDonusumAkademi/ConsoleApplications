using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWinForm.Context;

namespace ProjectWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgListe.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbKategori.DataSource = context.Categories.ToList();
                cbKategori.DisplayMember = "CategoryName";
                cbKategori.ValueMember = "CategoryID";
            }
        }
        private void ListProductsByCategory(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgListe.DataSource = context.Products.Where(p => p.CategoryID == id).ToList();
            }
        }

        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgListe.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key)).ToList();
            }
        }

        private void ListProductsByProductNameAndCategoryId(string key, int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgListe.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key) && p.CategoryID == id).ToList();
            }
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbKategori.SelectedValue != null || cbKategori.SelectedValue != "")
                {

                    ListProductsByCategory(Convert.ToInt32(cbKategori.SelectedValue));
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void txtUrun_TextChanged(object sender, EventArgs e)
        {
            // ListProductsByProductName(txtUrun.Text.ToLower());
            string key = txtUrun.Text;
            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    ListProducts();
                }
                else
                {
                    ListProductsByProductNameAndCategoryId(txtUrun.Text, Convert.ToInt32(cbKategori.SelectedValue));

                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
