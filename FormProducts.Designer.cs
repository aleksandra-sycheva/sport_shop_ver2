using System;
using System.Windows.Forms;

namespace sport_shop_ver2
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            btnFormsOrder = new Button();
            lblUserName = new Label();
            btnLogut = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblSupplierFilter = new Label();
            cmbSupplierFilter = new ComboBox();
            lblSort = new Label();
            cboSortStock = new ComboBox();
            dgvProducts = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnDelete);
            panelTop.Controls.Add(lblSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSupplierFilter);
            panelTop.Controls.Add(cmbSupplierFilter);
            panelTop.Controls.Add(lblSort);
            panelTop.Controls.Add(cboSortStock);
            panelTop.Controls.Add(btnUpdate);
            panelTop.Controls.Add(btnCreate);
            panelTop.Controls.Add(btnFormsOrder);
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogut);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(1162, 100);
            panelTop.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(67, 97, 238);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(531, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 43);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(67, 97, 238);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(355, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 43);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Редактировать";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(67, 97, 238);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(179, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 43);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Добавить";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnFormsOrder
            // 
            btnFormsOrder.BackColor = Color.FromArgb(67, 97, 238);
            btnFormsOrder.FlatAppearance.BorderSize = 0;
            btnFormsOrder.FlatStyle = FlatStyle.Flat;
            btnFormsOrder.ForeColor = Color.White;
            btnFormsOrder.Location = new Point(3, 4);
            btnFormsOrder.Name = "btnFormsOrder";
            btnFormsOrder.Size = new Size(170, 43);
            btnFormsOrder.TabIndex = 7;
            btnFormsOrder.Text = "Заказы";
            btnFormsOrder.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(932, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(60, 22);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogut
            // 
            btnLogut.BackColor = Color.FromArgb(233, 245, 255);
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Location = new Point(992, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(170, 43);
            btnLogut.TabIndex = 5;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogout_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 55);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(46, 22);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Поиск:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 30);
            txtSearch.TabIndex = 12;
            // 
            // lblSupplierFilter
            // 
            lblSupplierFilter.AutoSize = true;
            lblSupplierFilter.Location = new Point(290, 55);
            lblSupplierFilter.Name = "lblSupplierFilter";
            lblSupplierFilter.Size = new Size(80, 22);
            lblSupplierFilter.TabIndex = 13;
            lblSupplierFilter.Text = "Поставщик:";
            // 
            // cmbSupplierFilter
            // 
            cmbSupplierFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplierFilter.FormattingEnabled = true;
            cmbSupplierFilter.Location = new Point(375, 52);
            cmbSupplierFilter.Name = "cmbSupplierFilter";
            cmbSupplierFilter.Size = new Size(200, 30);
            cmbSupplierFilter.TabIndex = 14;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new Point(585, 55);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(40, 22);
            lblSort.TabIndex = 15;
            lblSort.Text = "Сорт:";
            // 
            // cboSortStock
            // 
            cboSortStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSortStock.FormattingEnabled = true;
            cboSortStock.Location = new Point(630, 52);
            cboSortStock.Name = "cboSortStock";
            cboSortStock.Size = new Size(150, 30);
            cboSortStock.TabIndex = 16;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = " ";
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(10, 110);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.ScrollBars = ScrollBars.Vertical;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1162, 590);
            dgvProducts.TabIndex = 1;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 710);
            Controls.Add(dgvProducts);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "FormProducts";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список товаров";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnFormsOrder;
        private Label lblUserName;
        private Button btnLogut;
        private DataGridView dgvProducts;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblSupplierFilter;
        private ComboBox cmbSupplierFilter;
        private Label lblSort;
        private ComboBox cboSortStock;
    }
}

