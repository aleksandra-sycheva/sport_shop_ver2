using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using sport_shop_ver2.Models;

namespace sport_shop_ver2
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 150;
            colPhoto.FillWeight = 20;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 70;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colPhoto, colInfo, colDiscount });
            dgvProducts.ColumnHeadersVisible = false;
            dgvProducts.CellPainting += DgvProducts_CellPainting;

            CurrentUser = user;
            IsGuest = guest;

            if (IsGuest)
            {
                btnFormsOrder.Visible = false;
                btnCreate.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }



            LoadProducts();

           
            btnCreate.Click += BtnCreate_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvProducts.CellDoubleClick += DgvProducts_CellDoubleClick;
            lblUserName.Text = IsGuest ? "Гость" : $"{CurrentUser.MiddleName} {CurrentUser.FirstName} {CurrentUser.LastName}";
        }

        private void DgvProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns["colInfo"].Index && e.RowIndex >= 0)
            {
                var row = dgvProducts.Rows[e.RowIndex];
                var product = row.Tag as SportingProduct;

                if (product != null && product.Discount > 0)
                {
                    e.Handled = true;
                    e.PaintBackground(e.CellBounds, true);

                    decimal price = GetPrice(product.Price);
                    decimal finalPrice = price * (100 - product.Discount) / 100m;
                    string oldPriceStr = price.ToString("C");
                    string newPriceStr = finalPrice.ToString("C");

                    // Стандартный текст без строки цены
                    string fullText = FormatProductInfo(product).Replace($"Цена: {oldPriceStr}", "").Replace($"Цена: {oldPriceStr} → {newPriceStr}", "");
                    string[] lines = fullText.Split('\n');
                    string textBefore = string.Join("\n", lines.Take(4));
                    string textAfter = string.Join("\n", lines.Skip(5));

                    // Рисуем текст до цены
                    SizeF beforeSize = e.Graphics.MeasureString(textBefore + "\n", e.CellStyle.Font);
                    e.Graphics.DrawString(textBefore, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), e.CellBounds.Left, e.CellBounds.Top);

                    // Строка цены
                    float yPrice = e.CellBounds.Top + beforeSize.Height;
                    e.Graphics.DrawString("Цена: ", e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), e.CellBounds.Left, yPrice);

                    float xPrice = e.CellBounds.Left + e.Graphics.MeasureString("Цена: ", e.CellStyle.Font).Width;

                    // Зачеркнутая старая цена
                    using (Pen strikePen = new Pen(e.CellStyle.ForeColor, 2))
                    {
                        SizeF oldPriceSize = e.Graphics.MeasureString(oldPriceStr, e.CellStyle.Font);
                        float oldPriceY = yPrice + oldPriceSize.Height / 2;
                        e.Graphics.DrawString(oldPriceStr, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), xPrice, yPrice);
                        e.Graphics.DrawLine(strikePen, xPrice, oldPriceY, xPrice + oldPriceSize.Width, oldPriceY);
                        xPrice += oldPriceSize.Width;
                    }

                    // Стрелка
                    SizeF arrowSize = e.Graphics.MeasureString(" → ", e.CellStyle.Font);
                    e.Graphics.DrawString(" → ", e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), xPrice, yPrice);
                    xPrice += arrowSize.Width;

                    // Новая цена
                    e.Graphics.DrawString(newPriceStr, new Font(e.CellStyle.Font, FontStyle.Bold), new SolidBrush(Color.Red), xPrice, yPrice);

                    // Текст после цены
                    float yAfter = yPrice + e.Graphics.MeasureString("Цена: 1000,00 → 800,00", e.CellStyle.Font).Height;
                    e.Graphics.DrawString(textAfter, e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), e.CellBounds.Left, yAfter);
                }
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (var db = new SportShopContext())
                {
                    var products = db.SportingProducts
                        .Include(p => p.IdCategoryNavigation)
                        .Include(p => p.IdManufacturerNavigation)
                        .Include(p => p.IdSupplierNavigation)
                        .Include(p => p.IdMeasureNavigation)
                        .ToList();

                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadProductImage(product);
                        row.Cells["colInfo"].Value = FormatProductInfo(product);
                        row.Cells["colDiscount"].Value = $"{product.Discount}%";

                        row.Tag = product;
                        ApplyRowStyles(row, product);
                    }

                    dgvProducts.ResumeLayout();
                    dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки товаров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, SportingProduct product)
        {
            if (product.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2EC4B6");
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            if (product.CointInStok <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E9F5FF");
                if (product.Discount <= 15)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private string FormatProductInfo(SportingProduct product)
        {
            decimal price = GetPrice(product.Price);
            string priceText = $"Цена: {price:C}";

            if (product.Discount > 0)
            {
                decimal finalPrice = price * (100 - product.Discount) / 100m;
                priceText += $" → {finalPrice:C}";
            }

            return $"{product.IdCategoryNavigation.CategoryName} | {product.ProductName}\n" +
                   $"Описание товара: {product.Description}\n" +
                   $"Производитель: {product.IdManufacturerNavigation.ManufacturerName}\n" +
                   $"Поставщик: {product.IdSupplierNavigation.SupplierName}\n" +
                   $"{priceText}\n" +
                   $"Единица измерения: {product.IdMeasureNavigation.MeasureName}\n" +
                   $"Количество на складе: {product.CointInStok}";
        }

        private Image LoadProductImage(SportingProduct product)
        {
            if (string.IsNullOrEmpty(product.Photo))
            {
                return Properties.Resources.picture ?? SystemIcons.Information.ToBitmap();
            }

            try
            {
                if (System.IO.File.Exists(product.Photo))
                {
                    return Image.FromFile(product.Photo);
                }
            }
            catch
            {
            }
            return Properties.Resources.picture ?? SystemIcons.Information.ToBitmap();
        }

        private decimal GetPrice(string priceStr)
        {
            if (decimal.TryParse(priceStr.Replace(',', '.'), out decimal price))
            {
                return price;
            }
            return 0m;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin();
        }

        /* private void btnFormsOrder_Click(object sender, EventArgs e)
         {
             this.Close();
             using (var formOrders = new FormOrders(CurrentUser, IsGuest))
             {
                 formOrders.ShowDialog();
             }
         }*/

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            using (var formEdit = new FormProductEdit())
            {
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.Tag is SportingProduct product)
            {
                using (var formEdit = new FormProductEdit(product))
                {
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для редактирования!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.Tag is SportingProduct product)
            {
                var result = MessageBox.Show($"Удалить товар '{product.ProductName}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new SportShopContext())
                        {
                            db.SportingProducts.Remove(product);
                            db.SaveChanges();
                            LoadProducts();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnUpdate_Click(sender, EventArgs.Empty);
            }
        }
    }
}

