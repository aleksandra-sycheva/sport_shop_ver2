using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using sport_shop_ver2.Models;

namespace sport_shop_ver2
{
    public partial class FormProductEdit : Form
    {
        private SportingProduct _product;
        private bool _isEditMode;

        public FormProductEdit(SportingProduct product = null)
        {
            InitializeComponent();
            _product = product;
            _isEditMode = product != null;
            this.Text = _isEditMode ? "Редактировать товар" : "Добавить товар";
            LoadDropdowns();
            if (_isEditMode)
            {
                LoadProductData();
            }
        }

        private void LoadDropdowns()
        {
            using (var db = new SportShopContext())
            {
                cmbCategory.DataSource = db.Categories.ToList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";

                cmbManufacturer.DataSource = db.Manufacturers.ToList();
                cmbManufacturer.DisplayMember = "ManufacturerName";
                cmbManufacturer.ValueMember = "Id";

                cmbSupplier.DataSource = db.Suppliers.ToList();
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";

                cmbMeasure.DataSource = db.Measures.ToList();
                cmbMeasure.DisplayMember = "MeasureName";
                cmbMeasure.ValueMember = "Id";
            }
        }

        private void LoadProductData()
        {
            txtArt.Text = _product.Art;
            txtProductName.Text = _product.ProductName;
            cmbCategory.SelectedValue = _product.IdCategory;
            cmbManufacturer.SelectedValue = _product.IdManufacturer;
            cmbSupplier.SelectedValue = _product.IdSupplier;
            txtPrice.Text = _product.Price;
            cmbMeasure.SelectedValue = _product.IdMeasure;
            txtDiscount.Text = _product.Discount.ToString();
            txtCount.Text = _product.CointInStok.ToString();
            txtDescription.Text = _product.Description;
            txtPhotoPath.Text = _product.Photo;
            UpdatePhotoPreview();
        }

        private void UpdatePhotoPreview()
        {
            if (!string.IsNullOrEmpty(txtPhotoPath.Text) && File.Exists(txtPhotoPath.Text))
            {
                try
                {
                    picturePreview.Image = Image.FromFile(txtPhotoPath.Text);
                }
                catch
                {
                    picturePreview.Image = null;
                }
            }
            else
            {
                picturePreview.Image = null;
            }
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtPhotoPath.Text = ofd.FileName;
                    UpdatePhotoPreview();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (var db = new SportShopContext())
                {
                    if (_isEditMode)
                    {
                        // Update
                        _product.Art = txtArt.Text;
                        _product.ProductName = txtProductName.Text;
                        _product.IdCategory = (int)cmbCategory.SelectedValue;
                        _product.IdManufacturer = (int)cmbManufacturer.SelectedValue;
                        _product.IdSupplier = (int)cmbSupplier.SelectedValue;
                        _product.Price = txtPrice.Text;
                        _product.IdMeasure = (int)cmbMeasure.SelectedValue;
                        _product.Discount = int.Parse(txtDiscount.Text);
                        _product.CointInStok = int.Parse(txtCount.Text);
                        _product.Description = txtDescription.Text;
                        _product.Photo = txtPhotoPath.Text;

                        db.SportingProducts.Update(_product);
                    }
                    else
                    {
                        // Create new
                        var newProduct = new SportingProduct
                        {
                            Art = txtArt.Text,
                            ProductName = txtProductName.Text,
                            IdCategory = (int)cmbCategory.SelectedValue,
                            IdManufacturer = (int)cmbManufacturer.SelectedValue,
                            IdSupplier = (int)cmbSupplier.SelectedValue,
                            Price = txtPrice.Text,
                            IdMeasure = (int)cmbMeasure.SelectedValue,
                            Discount = int.Parse(txtDiscount.Text),
                            CointInStok = int.Parse(txtCount.Text),
                            Description = txtDescription.Text,
                            Photo = txtPhotoPath.Text
                        };
                        db.SportingProducts.Add(newProduct);
                        _product = newProduct;
                    }

                    db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Название товара обязательно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtPrice.Text.Replace(',', '.'), out _))
            {
                MessageBox.Show("Неверный формат цены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtDiscount.Text, out int discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Скидка должна быть числом 0-100!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtCount.Text, out int count) || count < 0)
            {
                MessageBox.Show("Количество на складе должно быть неотрицательным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCategory.SelectedValue == null || cmbManufacturer.SelectedValue == null || cmbSupplier.SelectedValue == null || cmbMeasure.SelectedValue == null)
            {
                MessageBox.Show("Выберите все категории/производителя/поставщика/ед.изм.!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPhotoPath_TextChanged(object sender, EventArgs e)
        {
            UpdatePhotoPreview();
        }
    }
}

