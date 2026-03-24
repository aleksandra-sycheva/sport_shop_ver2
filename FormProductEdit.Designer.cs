namespace sport_shop_ver2
{
    partial class FormProductEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            txtArt = new TextBox();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            cmbManufacturer = new ComboBox();
            cmbSupplier = new ComboBox();
            txtPrice = new TextBox();
            cmbMeasure = new ComboBox();
            txtDiscount = new TextBox();
            txtCount = new TextBox();
            txtDescription = new TextBox();
            txtPhotoPath = new TextBox();
            picturePreview = new PictureBox();
            btnBrowsePhoto = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)picturePreview).BeginInit();
            SuspendLayout();
            // 
            // txtArt
            // 
            txtArt.Location = new Point(275, 34);
            txtArt.Margin = new Padding(6);
            txtArt.Name = "txtArt";
            txtArt.Size = new Size(478, 30);
            txtArt.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(275, 85);
            txtProductName.Margin = new Padding(6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(478, 30);
            txtProductName.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(275, 135);
            cmbCategory.Margin = new Padding(6);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(478, 30);
            cmbCategory.TabIndex = 2;
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(275, 186);
            cmbManufacturer.Margin = new Padding(6);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(478, 30);
            cmbManufacturer.TabIndex = 3;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(275, 236);
            cmbSupplier.Margin = new Padding(6);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(478, 30);
            cmbSupplier.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(275, 288);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(478, 30);
            txtPrice.TabIndex = 5;
            // 
            // cmbMeasure
            // 
            cmbMeasure.FormattingEnabled = true;
            cmbMeasure.Location = new Point(275, 339);
            cmbMeasure.Margin = new Padding(6);
            cmbMeasure.Name = "cmbMeasure";
            cmbMeasure.Size = new Size(478, 30);
            cmbMeasure.TabIndex = 6;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(275, 389);
            txtDiscount.Margin = new Padding(6);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(478, 30);
            txtDiscount.TabIndex = 7;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(275, 440);
            txtCount.Margin = new Padding(6);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(478, 30);
            txtCount.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(275, 491);
            txtDescription.Margin = new Padding(6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(478, 99);
            txtDescription.TabIndex = 9;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(275, 609);
            txtPhotoPath.Margin = new Padding(6);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(547, 30);
            txtPhotoPath.TabIndex = 10;
            txtPhotoPath.TextChanged += txtPhotoPath_TextChanged;
            // 
            // picturePreview
            // 
            picturePreview.Location = new Point(275, 660);
            picturePreview.Margin = new Padding(6);
            picturePreview.Name = "picturePreview";
            picturePreview.Size = new Size(359, 201);
            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
            picturePreview.TabIndex = 11;
            picturePreview.TabStop = false;
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.BackColor = Color.FromArgb(233, 245, 255);
            btnBrowsePhoto.FlatStyle = FlatStyle.Flat;
            btnBrowsePhoto.Location = new Point(840, 602);
            btnBrowsePhoto.Margin = new Padding(6);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(183, 42);
            btnBrowsePhoto.TabIndex = 12;
            btnBrowsePhoto.Text = "Выбрать фото";
            btnBrowsePhoto.UseVisualStyleBackColor = false;
            btnBrowsePhoto.Click += btnBrowsePhoto_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(67, 97, 238);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(753, 882);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(241, 51);
            btnSave.TabIndex = 13;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(233, 245, 255);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(37, 882);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(225, 51);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 15;
            label1.Text = "Артикул:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 90);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 22);
            label2.TabIndex = 16;
            label2.Text = "Название товара:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 141);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 17;
            label3.Text = "Категория:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 191);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 22);
            label4.TabIndex = 18;
            label4.Text = "Производитель:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 242);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 22);
            label5.TabIndex = 19;
            label5.Text = "Поставщик:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 293);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 22);
            label6.TabIndex = 20;
            label6.Text = "Цена:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 343);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 21;
            label7.Text = "Ед.изм.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 394);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 22);
            label8.TabIndex = 22;
            label8.Text = "Скидка:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 446);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(202, 22);
            label9.TabIndex = 23;
            label9.Text = "Количество на складе:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 508);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 22);
            label10.TabIndex = 24;
            label10.Text = "Описание:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 618);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 22);
            label11.TabIndex = 25;
            label11.Text = "Фото:";
            // 
            // FormProductEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 942);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnBrowsePhoto);
            Controls.Add(picturePreview);
            Controls.Add(txtPhotoPath);
            Controls.Add(txtDescription);
            Controls.Add(txtCount);
            Controls.Add(txtDiscount);
            Controls.Add(cmbMeasure);
            Controls.Add(txtPrice);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbManufacturer);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtArt);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            MinimizeBox = false;
            Name = "FormProductEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать товар";
            ((System.ComponentModel.ISupportInitialize)picturePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbMeasure;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPhotoPath;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

