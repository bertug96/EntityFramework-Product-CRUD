using AdoNetDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgv_products.DataSource = productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //dgv_products.DataSource = productDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
            var result = productDal.GetByName(key);
            dgv_products.DataSource = result;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = txt_name.Text,
                UnitPrice = Convert.ToDecimal(txt_unitPrice.Text),  
                StockAmount = Convert.ToInt32(txt_stockAmount.Text)
            });

            LoadProducts();
            MessageBox.Show("Added!");
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgv_products.CurrentRow.Cells[0].Value),
                Name = txt_updateName.Text,
                UnitPrice = Convert.ToDecimal(txt_updateUnitPrice.Text),
                StockAmount = Convert.ToInt32(txt_updateStockAmount.Text)
            });

            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txt_updateName.Text = dgv_products.CurrentRow.Cells[1].Value.ToString();
                txt_updateUnitPrice.Text = dgv_products.CurrentRow.Cells[2].Value.ToString();
                txt_updateStockAmount.Text = dgv_products.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgv_products.CurrentRow.Cells[0].Value)
            });

            LoadProducts();
            MessageBox.Show("Deleted!");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txt_search.Text);
        }
    }
}