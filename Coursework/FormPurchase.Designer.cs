namespace Coursework
{
    partial class FormPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchase));
            ButtonConfirm = new Button();
            ComboBoxCity = new ComboBox();
            PictureBoxLocation = new PictureBox();
            ComboBoxLocation = new ComboBox();
            LabelCity = new Label();
            LabelLocation = new Label();
            LabelDelivery = new Label();
            ListBoxProduct2 = new ListBox();
            LabelPayment = new Label();
            ListBoxPrice2 = new ListBox();
            LabelProduct = new Label();
            LabelListPrice = new Label();
            LabelPrice = new Label();
            ButtonCancel = new Button();
            LabelRecipient = new Label();
            TextBoxUser = new TextBox();
            CheckBoxPayment = new CheckBox();
            LabelPayMethod = new Label();
            LabelName = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLocation).BeginInit();
            SuspendLayout();
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.BackColor = Color.MediumSlateBlue;
            ButtonConfirm.FlatStyle = FlatStyle.Flat;
            ButtonConfirm.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonConfirm.Location = new Point(2, 427);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.Size = new Size(623, 35);
            ButtonConfirm.TabIndex = 169;
            ButtonConfirm.Text = "Замовлення підтверджую";
            ButtonConfirm.UseVisualStyleBackColor = false;
            ButtonConfirm.Click += ButtonConfirm_Click;
            // 
            // ComboBoxCity
            // 
            ComboBoxCity.BackColor = Color.White;
            ComboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCity.FormattingEnabled = true;
            ComboBoxCity.Items.AddRange(new object[] { "Київ обл.", "Житомир обл." });
            ComboBoxCity.Location = new Point(291, 24);
            ComboBoxCity.Name = "ComboBoxCity";
            ComboBoxCity.Size = new Size(284, 23);
            ComboBoxCity.TabIndex = 170;
            ComboBoxCity.SelectedIndexChanged += ComboBoxCity_SelectedIndexChanged;
            // 
            // PictureBoxLocation
            // 
            PictureBoxLocation.BackColor = Color.Transparent;
            PictureBoxLocation.Image = (Image)resources.GetObject("PictureBoxLocation.Image");
            PictureBoxLocation.Location = new Point(245, 27);
            PictureBoxLocation.Name = "PictureBoxLocation";
            PictureBoxLocation.Size = new Size(40, 40);
            PictureBoxLocation.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLocation.TabIndex = 171;
            PictureBoxLocation.TabStop = false;
            // 
            // ComboBoxLocation
            // 
            ComboBoxLocation.BackColor = Color.White;
            ComboBoxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLocation.FormattingEnabled = true;
            ComboBoxLocation.Location = new Point(291, 48);
            ComboBoxLocation.Name = "ComboBoxLocation";
            ComboBoxLocation.Size = new Size(284, 23);
            ComboBoxLocation.TabIndex = 172;
            // 
            // LabelCity
            // 
            LabelCity.AutoSize = true;
            LabelCity.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCity.ForeColor = Color.Black;
            LabelCity.Location = new Point(581, 26);
            LabelCity.Name = "LabelCity";
            LabelCity.Size = new Size(45, 17);
            LabelCity.TabIndex = 173;
            LabelCity.Text = "Місто";
            // 
            // LabelLocation
            // 
            LabelLocation.AutoSize = true;
            LabelLocation.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLocation.ForeColor = Color.Black;
            LabelLocation.Location = new Point(581, 50);
            LabelLocation.Name = "LabelLocation";
            LabelLocation.Size = new Size(171, 17);
            LabelLocation.TabIndex = 174;
            LabelLocation.Text = "Відділення Нової Пошти";
            // 
            // LabelDelivery
            // 
            LabelDelivery.AutoSize = true;
            LabelDelivery.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDelivery.ForeColor = Color.Black;
            LabelDelivery.Location = new Point(245, 3);
            LabelDelivery.Name = "LabelDelivery";
            LabelDelivery.Size = new Size(75, 18);
            LabelDelivery.TabIndex = 175;
            LabelDelivery.Text = "Доставка";
            // 
            // ListBoxProduct2
            // 
            ListBoxProduct2.BackColor = Color.White;
            ListBoxProduct2.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxProduct2.FormattingEnabled = true;
            ListBoxProduct2.ItemHeight = 19;
            ListBoxProduct2.Location = new Point(2, 170);
            ListBoxProduct2.Name = "ListBoxProduct2";
            ListBoxProduct2.Size = new Size(623, 251);
            ListBoxProduct2.TabIndex = 176;
            // 
            // LabelPayment
            // 
            LabelPayment.AutoSize = true;
            LabelPayment.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPayment.ForeColor = Color.Black;
            LabelPayment.Location = new Point(12, 3);
            LabelPayment.Name = "LabelPayment";
            LabelPayment.Size = new Size(184, 18);
            LabelPayment.TabIndex = 178;
            LabelPayment.Text = "Сума замовлення (UAH)";
            // 
            // ListBoxPrice2
            // 
            ListBoxPrice2.BackColor = Color.White;
            ListBoxPrice2.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxPrice2.FormattingEnabled = true;
            ListBoxPrice2.ItemHeight = 19;
            ListBoxPrice2.Location = new Point(624, 170);
            ListBoxPrice2.Name = "ListBoxPrice2";
            ListBoxPrice2.Size = new Size(138, 251);
            ListBoxPrice2.TabIndex = 179;
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelProduct.ForeColor = Color.Black;
            LabelProduct.Location = new Point(12, 149);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(129, 18);
            LabelProduct.TabIndex = 180;
            LabelProduct.Text = "Всі замовлення:";
            // 
            // LabelListPrice
            // 
            LabelListPrice.AutoSize = true;
            LabelListPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelListPrice.ForeColor = Color.Black;
            LabelListPrice.Location = new Point(625, 149);
            LabelListPrice.Name = "LabelListPrice";
            LabelListPrice.Size = new Size(89, 18);
            LabelListPrice.TabIndex = 181;
            LabelListPrice.Text = "Ціна (UAH):";
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize = true;
            LabelPrice.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrice.ForeColor = Color.Red;
            LabelPrice.Location = new Point(12, 27);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new Size(55, 24);
            LabelPrice.TabIndex = 183;
            LabelPrice.Text = "Ціна";
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.MediumSlateBlue;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancel.Location = new Point(624, 427);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(138, 35);
            ButtonCancel.TabIndex = 184;
            ButtonCancel.Text = "Повернутись";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // LabelRecipient
            // 
            LabelRecipient.AutoSize = true;
            LabelRecipient.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRecipient.ForeColor = Color.Black;
            LabelRecipient.Location = new Point(242, 88);
            LabelRecipient.Name = "LabelRecipient";
            LabelRecipient.Size = new Size(88, 18);
            LabelRecipient.TabIndex = 185;
            LabelRecipient.Text = "Отримувач";
            // 
            // TextBoxUser
            // 
            TextBoxUser.BackColor = Color.White;
            TextBoxUser.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUser.Location = new Point(247, 109);
            TextBoxUser.Name = "TextBoxUser";
            TextBoxUser.Size = new Size(325, 24);
            TextBoxUser.TabIndex = 186;
            // 
            // CheckBoxPayment
            // 
            CheckBoxPayment.AutoSize = true;
            CheckBoxPayment.Checked = true;
            CheckBoxPayment.CheckState = CheckState.Checked;
            CheckBoxPayment.Location = new Point(12, 113);
            CheckBoxPayment.Name = "CheckBoxPayment";
            CheckBoxPayment.Size = new Size(173, 19);
            CheckBoxPayment.TabIndex = 187;
            CheckBoxPayment.Text = "Під час отримання товару";
            CheckBoxPayment.UseVisualStyleBackColor = true;
            // 
            // LabelPayMethod
            // 
            LabelPayMethod.AutoSize = true;
            LabelPayMethod.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPayMethod.ForeColor = Color.Black;
            LabelPayMethod.Location = new Point(9, 88);
            LabelPayMethod.Name = "LabelPayMethod";
            LabelPayMethod.Size = new Size(61, 18);
            LabelPayMethod.TabIndex = 188;
            LabelPayMethod.Text = "Оплата";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LabelName.ForeColor = Color.Black;
            LabelName.Location = new Point(578, 112);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(31, 17);
            LabelName.TabIndex = 189;
            LabelName.Text = "ПІБ";
            // 
            // FormPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 471);
            Controls.Add(LabelName);
            Controls.Add(LabelPayMethod);
            Controls.Add(CheckBoxPayment);
            Controls.Add(TextBoxUser);
            Controls.Add(LabelRecipient);
            Controls.Add(ButtonCancel);
            Controls.Add(LabelPrice);
            Controls.Add(LabelListPrice);
            Controls.Add(LabelProduct);
            Controls.Add(ListBoxPrice2);
            Controls.Add(LabelPayment);
            Controls.Add(ListBoxProduct2);
            Controls.Add(LabelDelivery);
            Controls.Add(LabelLocation);
            Controls.Add(LabelCity);
            Controls.Add(ComboBoxLocation);
            Controls.Add(PictureBoxLocation);
            Controls.Add(ComboBoxCity);
            Controls.Add(ButtonConfirm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(780, 510);
            MinimumSize = new Size(780, 420);
            Name = "FormPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blyzo інтернет-магазин";
            FormClosed += FormPurchase_FormClosed;
            Load += FormPurchase_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxLocation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonConfirm;
        private ComboBox ComboBoxCity;
        private PictureBox PictureBoxLocation;
        private ComboBox ComboBoxLocation;
        private Label LabelCity;
        private Label LabelLocation;
        private Label LabelDelivery;
        private ListBox ListBoxProduct2;
        private Label LabelPayment;
        private ListBox ListBoxPrice2;
        private Label LabelProduct;
        private Label LabelListPrice;
        private Label LabelPrice;
        private Button ButtonCancel;
        private Label LabelRecipient;
        private TextBox TextBoxUser;
        private CheckBox CheckBoxPayment;
        private Label LabelPayMethod;
        private Label LabelName;
    }
}