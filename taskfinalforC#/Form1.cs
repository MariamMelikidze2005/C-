using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using taskfinalforC_.db;
using taskfinalfor_.db;
using Microsoft.EntityFrameworkCore;

namespace taskfinalforC_
{
    public partial class Form1 : Form
    {
        AppDbContext _context = new AppDbContext();
        int selectedProductId = 0;

        public Form1()
        {
            InitializeComponent();
            LoadCategoriesToComboBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoryName = textBoxforcategorynameinfut.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                _context.Categories.Add(new Category { Name = categoryName });
                _context.SaveChanges();
                MessageBox.Show("კატეგორია დამატებულია");
                textBoxforcategorynameinfut.Clear();
                LoadCategoriesToComboBox();
                LoadCategoriesToGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadCategoriesToGrid();
        }

        private void LoadCategoriesToGrid()
        {
            var Categories  = _context.Categories.Select(c => new
            {
                კატეგორიისID = c.Id,
                კატეგორიისსახელი = c.Name
            }).ToList();

            dataGridViewforshowcategory.DataSource = Categories;
            comboBoxforchooseproductcategoryfromcategorytable.DisplayMember = "კატეგორიისსახელი";
            comboBoxforchooseproductcategoryfromcategorytable.DataSource = Categories;
        
    }

        private void LoadCategoriesToComboBox()
        {
            comboBox1.DataSource = _context.Categories.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void buttontoaddproduct_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text.Trim();
            decimal productPrice = toinputproductprice.Value;
            int categoryId = (int)comboBox1.SelectedValue;

            if (!string.IsNullOrEmpty(productName))
            {
                _context.Products.Add(new Product
                {
                    Name = productName,
                    Price = productPrice,
                    CategoryId = categoryId
                });

                _context.SaveChanges();
                MessageBox.Show("პროდუქტი დამატებულია");
                textBox1.Clear();
                toinputproductprice.Value = 0;
                LoadProductsToGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProductsToGrid();
            LoadCategoriesToGrid();
        }

        private void LoadProductsToGrid()
        {
            dataGridViewtoshowproduct.DataSource = _context.Products
                .Include(p => p.Category)
                .Select(p => new
                {
                    პროდუქტისID = p.Id,
                    დასახელება = p.Name,
                    ფასი = p.Price,
                    კატეგორია = p.Category.Name
                }).ToList();
        }

        private void dataGridViewforshowcategory_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewtoshowproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProductId = Convert.ToInt32(dataGridViewtoshowproduct.Rows[e.RowIndex].Cells["პროდუქტისID"].Value);
                var product = _context.Products.Find(selectedProductId);
                if (product != null)
                {
                    textBox1.Text = product.Name;
                    toinputproductprice.Value = product.Price;
                    comboBox1.SelectedValue = product.CategoryId;
                }
            }
        }

        private void buttontoedit_Click(object sender, EventArgs e)
        {
            if (selectedProductId != 0)
            {
                var product = _context.Products.Find(selectedProductId);
                if (product != null)
                {
                    product.Name = textBox1.Text.Trim();
                    product.Price = toinputproductprice.Value;
                    product.CategoryId = (int)comboBox1.SelectedValue;

                    _context.SaveChanges();
                    MessageBox.Show("პროდუქტი განახლებულია");
                    LoadProductsToGrid();
                    selectedProductId = 0;
                    textBox1.Clear();
                    toinputproductprice.Value = 0;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttontodelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId != 0)
            {
                var product = _context.Products.Find(selectedProductId);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    MessageBox.Show("პროდუქტი წაშლილია");
                    LoadProductsToGrid();
                    selectedProductId = 0;
                    textBox1.Clear();
                    toinputproductprice.Value = 0;
                }
            }
        }
    }
}
