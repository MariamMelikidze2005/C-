

using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using taskfinalfor_.db;
using taskfinalforC_.db;

namespace taskfinalforC_
{
    public partial class Orders : Form
    {
        private AppDbContext _context;
        private int currentOrderId = -1;
        private int selectedproduct;
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalPages = 1;

        public Orders()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadCategories();
            LoadProducts();
            LoadOrders();

            numericUpDownforinputquantityofproduct.Minimum = 0;
        }

        private void LoadOrders()
        {
            int totalOrders = _context.Orders.Count();
            totalPages = (int)Math.Ceiling((double)totalOrders / pageSize);

            var orders = _context.Orders
                .OrderBy(o => o.Id)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .Select(o => new
                {
                    o.Id,
                    o.CustomerName,
                    o.OrderDate,
                    ProductName = o.Product.Name,
                    o.Quantity,
                    TotalPrice = o.Product.Price * o.Quantity
                }).ToList();



            forshoworders.DataSource = orders;

            HighlightExpensiveOrders();
            UpdateNavigationButtons();
            labelPageInfo.Text = $"Page {currentPage} of {totalPages}";

            UpdateTotalSum();

            var products = _context.Products.Select(o => new
            {
                o.Name
            })
                .ToList();
            comboBoxforshowproducts.DisplayMember = "Name";
            comboBoxforshowproducts.DataSource = products;
        }

        private void HighlightExpensiveOrders()
        {
            foreach (DataGridViewRow row in forshoworders.Rows)
            {
                if (row.Cells["TotalPrice"].Value is decimal totalPrice && totalPrice > 100)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void UpdateNavigationButtons()
        {
            buttonshowprevious.Enabled = currentPage > 1;
            buttontoshownext.Enabled = currentPage < totalPages;
        }

        private void UpdateTotalSum()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in forshoworders.Rows)
            {
                if (row.Cells["TotalPrice"].Value is decimal value)
                {
                    total += value;
                }
            }
            textBoxforshowsum.Text = $"{total} ₾";
        }

        private void LoadCategories()
        {
            comboBoxforchoosdesiredCAtegory.DisplayMember = "Name";
            comboBoxforchoosdesiredCAtegory.ValueMember = "Id";
            comboBoxforchoosdesiredCAtegory.DataSource = _context.Categories.ToList();
        }

        private void LoadProducts()
        {
            comboBoxforchooseproduct.DisplayMember = "Name";
            comboBoxforchooseproduct.ValueMember = "Id";
            comboBoxforchooseproduct.DataSource = _context.Products.ToList();
        }

        private void comboBoxforchoosdesiredCAtegory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxforchoosdesiredCAtegory.SelectedValue is int selectedCategoryId)
            {
                var filteredProducts = _context.Products
                    .Where(p => p.CategoryId == selectedCategoryId)
                    .ToList();
                comboBoxforchooseproduct.DataSource = filteredProducts;
            }
        }

        private void buttontoshoworders_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void forshoworders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = forshoworders.Rows[e.RowIndex];
                currentOrderId = (int)selectedRow.Cells["Id"].Value;

                var order = _context.Orders.FirstOrDefault(o => o.Id == currentOrderId);
                if (order != null)
                {
                    comboBoxforchooseproduct.SelectedValue = order.ProductId;
                    numericUpDownforinputquantityofproduct.Value = order.Quantity;
                }
            }
        }

        private void toeditorders_Click(object sender, EventArgs e)
        {
            if (currentOrderId == -1)
            {
                MessageBox.Show("გთხოვთ, აირჩიოთ ჩასასწორებელი შეკვეთა ცხრილიდან.");
                return;
            }

            int quantity = (int)numericUpDownforinputquantityofproduct.Value;
            if (quantity < 0)
            {
                MessageBox.Show("რაოდენობა არ შეიძლება იყოს უარყოფითი.");
                return;
            }

            var order = _context.Orders.FirstOrDefault(o => o.Id == currentOrderId);
            if (order != null)
            {
                order.ProductId = (int)comboBoxforchooseproduct.SelectedValue;
                order.Quantity = quantity;
                _context.SaveChanges();
                MessageBox.Show("შეკვეთა წარმატებით შეიცვალა!");
                LoadOrders();
                currentOrderId = -1;
            }
        }

        private void todeleteorders_Click(object sender, EventArgs e)
        {
            if (currentOrderId == -1)
            {
                MessageBox.Show("გთხოვთ, აირჩიოთ წასაშლელი შეკვეთა ცხრილიდან.");
                return;
            }

            var order = _context.Orders.FirstOrDefault(o => o.Id == currentOrderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
                MessageBox.Show("შეკვეთა წარმატებით წაიშალა!");
                LoadOrders();
                currentOrderId = -1;
            }
        }

        private void numericUpDownforinputquantityofproduct_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxforchooseproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonfornavigeitotherpage_Click(object sender, EventArgs e)
        {
            // personalorders personal = new personalorders();
            // personal.Show();
        }

        private void buttonshowprevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadOrders();
            }
        }

        private void buttontoshownext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadOrders();
            }
        }

        private void textBoxforshowsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownforenterquantityforaddorders_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBoxtoentercustomername_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttontosumproductprice_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePickerfrom_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickertosomedate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonforfilterbydate_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerfrom.Value.Date;
            DateTime to = dateTimePickertosomedate.Value.Date.AddDays(1);

            var filteredOrders = _context.Orders
                .Where(o => o.OrderDate >= from && o.OrderDate < to)
                .Select(o => new
                {
                    o.Id,
                    o.CustomerName,
                    o.OrderDate,
                    ProductName = o.Product.Name,
                    o.Quantity,
                    TotalPrice = o.Product.Price * o.Quantity
                }).ToList();

            forshoworders.DataSource = filteredOrders;
            HighlightExpensiveOrders();
            UpdateTotalSum();
            labelPageInfo.Text = $"Filtered {filteredOrders.Count} Orders";
        }

        private void buttonforfilterbydate_Click_1(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerfrom.Value.Date;
            DateTime to = dateTimePickertosomedate.Value.Date.AddDays(1);

            var filteredOrders = _context.Orders
                .Where(o => o.OrderDate >= from && o.OrderDate < to)
                .Select(o => new
                {
                    o.Id,
                    o.CustomerName,
                    o.OrderDate,
                    ProductName = o.Product.Name,
                    o.Quantity,
                    TotalPrice = o.Product.Price * o.Quantity
                }).ToList();

            forshoworders.DataSource = filteredOrders;

            HighlightExpensiveOrders();
            UpdateTotalSum();

            labelPageInfo.Text = $"Filtered {filteredOrders.Count} Orders from {from:yyyy-MM-dd} to {to.AddDays(-1):yyyy-MM-dd}";
        }



        private void comboBoxforshowproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                var product = _context.Products.FirstOrDefault(p => p.Name == comboBoxforshowproducts.Text);
                if (product != null)
                {
                    selectedproduct = product.Id;

                }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerforneworders_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonforaddorders_Click(object sender, EventArgs e)
        {
            string customerName = textBoxtoentercustomername.Text.Trim();
            DateTime orderDate = dateTimePickerforneworders.Value;
            int quantity;

            if (comboBoxforshowproducts.SelectedValue == null ||
                !int.TryParse(textBoxforquantity.Text, out quantity) ||
                string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("შეავსეთ ყველა ველი სწორად.");
                return;
            }

            //int productId = (int)comboBoxforshowproducts.SelectedValue;

            var newOrder = new Order
            {
                CustomerName = customerName,
                OrderDate = orderDate,
                ProductId = selectedproduct,
                Quantity = quantity
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            MessageBox.Show("შეკვეთა წარმატებით დაემატა.");

            textBoxtoentercustomername.Clear();
            textBoxforquantity.Clear();
            comboBoxforshowproducts.SelectedIndex = -1;
            dateTimePickerforneworders.Value = DateTime.Today;

            LoadOrders(); 
        }

    }
}
