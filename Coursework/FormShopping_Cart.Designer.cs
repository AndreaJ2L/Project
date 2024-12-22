namespace Coursework
{
    partial class FormShopping_Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShopping_Cart));
            ListBoxProduct = new ListBox();
            ButtonPurchase = new Button();
            LabelPrice2 = new Label();
            LabelPrice1 = new Label();
            ListBoxPrice = new ListBox();
            LabelProduct = new Label();
            LabelPrice = new Label();
            ButtonReset = new Button();
            ButtonMain = new Button();
            PictureBoxShape = new PictureBox();
            ButtonShopping_Cart = new Button();
            ButtonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxShape).BeginInit();
            SuspendLayout();
            // 
            // ListBoxProduct
            // 
            ListBoxProduct.BackColor = Color.White;
            ListBoxProduct.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxProduct.FormattingEnabled = true;
            ListBoxProduct.ItemHeight = 19;
            ListBoxProduct.Location = new Point(2, 98);
            ListBoxProduct.Name = "ListBoxProduct";
            ListBoxProduct.Size = new Size(621, 232);
            ListBoxProduct.TabIndex = 167;
            ListBoxProduct.SelectedIndexChanged += ListBoxProduct_SelectedIndexChanged;
            // 
            // ButtonPurchase
            // 
            ButtonPurchase.BackColor = Color.Transparent;
            ButtonPurchase.FlatStyle = FlatStyle.Flat;
            ButtonPurchase.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPurchase.Location = new Point(1, 336);
            ButtonPurchase.Name = "ButtonPurchase";
            ButtonPurchase.Size = new Size(623, 35);
            ButtonPurchase.TabIndex = 168;
            ButtonPurchase.Text = "Замовити";
            ButtonPurchase.UseVisualStyleBackColor = false;
            ButtonPurchase.Click += ButtonPurchase_Click;
            // 
            // LabelPrice2
            // 
            LabelPrice2.AutoSize = true;
            LabelPrice2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrice2.ForeColor = Color.Red;
            LabelPrice2.Location = new Point(265, 21);
            LabelPrice2.Name = "LabelPrice2";
            LabelPrice2.Size = new Size(0, 24);
            LabelPrice2.TabIndex = 170;
            // 
            // LabelPrice1
            // 
            LabelPrice1.AutoSize = true;
            LabelPrice1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrice1.ForeColor = Color.Red;
            LabelPrice1.Location = new Point(3, 21);
            LabelPrice1.Name = "LabelPrice1";
            LabelPrice1.Size = new Size(265, 24);
            LabelPrice1.TabIndex = 171;
            LabelPrice1.Text = "Сума замовлення (UAH):";
            // 
            // ListBoxPrice
            // 
            ListBoxPrice.BackColor = Color.White;
            ListBoxPrice.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxPrice.FormattingEnabled = true;
            ListBoxPrice.ItemHeight = 19;
            ListBoxPrice.Location = new Point(622, 98);
            ListBoxPrice.Name = "ListBoxPrice";
            ListBoxPrice.Size = new Size(140, 232);
            ListBoxPrice.TabIndex = 172;
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelProduct.ForeColor = Color.Black;
            LabelProduct.Location = new Point(1, 67);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(129, 18);
            LabelProduct.TabIndex = 174;
            LabelProduct.Text = "Всі замовлення:";
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize = true;
            LabelPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrice.ForeColor = Color.Black;
            LabelPrice.Location = new Point(623, 67);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new Size(89, 18);
            LabelPrice.TabIndex = 175;
            LabelPrice.Text = "Ціна (UAH):";
            // 
            // ButtonReset
            // 
            ButtonReset.BackColor = Color.Transparent;
            ButtonReset.FlatStyle = FlatStyle.Flat;
            ButtonReset.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonReset.Location = new Point(622, 336);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(139, 35);
            ButtonReset.TabIndex = 176;
            ButtonReset.Text = "Скасувати";
            ButtonReset.UseVisualStyleBackColor = false;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // ButtonMain
            // 
            ButtonMain.BackColor = Color.MediumSlateBlue;
            ButtonMain.FlatAppearance.BorderSize = 0;
            ButtonMain.FlatStyle = FlatStyle.Flat;
            ButtonMain.Image = (Image)resources.GetObject("ButtonMain.Image");
            ButtonMain.Location = new Point(650, 5);
            ButtonMain.Name = "ButtonMain";
            ButtonMain.Size = new Size(40, 40);
            ButtonMain.TabIndex = 179;
            ButtonMain.UseVisualStyleBackColor = false;
            ButtonMain.Click += ButtonMain_Click;
            // 
            // PictureBoxShape
            // 
            PictureBoxShape.Image = (Image)resources.GetObject("PictureBoxShape.Image");
            PictureBoxShape.Location = new Point(578, 0);
            PictureBoxShape.Name = "PictureBoxShape";
            PictureBoxShape.Size = new Size(186, 50);
            PictureBoxShape.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxShape.TabIndex = 177;
            PictureBoxShape.TabStop = false;
            // 
            // ButtonShopping_Cart
            // 
            ButtonShopping_Cart.BackColor = Color.MediumSlateBlue;
            ButtonShopping_Cart.BackgroundImage = (Image)resources.GetObject("ButtonShopping_Cart.BackgroundImage");
            ButtonShopping_Cart.Enabled = false;
            ButtonShopping_Cart.FlatAppearance.BorderSize = 0;
            ButtonShopping_Cart.FlatStyle = FlatStyle.Flat;
            ButtonShopping_Cart.Location = new Point(705, 10);
            ButtonShopping_Cart.Name = "ButtonShopping_Cart";
            ButtonShopping_Cart.Size = new Size(32, 32);
            ButtonShopping_Cart.TabIndex = 180;
            ButtonShopping_Cart.UseVisualStyleBackColor = false;
            // 
            // ButtonClear
            // 
            ButtonClear.BackColor = Color.MediumSlateBlue;
            ButtonClear.BackgroundImage = (Image)resources.GetObject("ButtonClear.BackgroundImage");
            ButtonClear.FlatAppearance.BorderSize = 0;
            ButtonClear.FlatStyle = FlatStyle.Flat;
            ButtonClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonClear.Location = new Point(603, 9);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(32, 32);
            ButtonClear.TabIndex = 191;
            ButtonClear.UseVisualStyleBackColor = false;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // FormShopping_Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 381);
            Controls.Add(ButtonClear);
            Controls.Add(ButtonShopping_Cart);
            Controls.Add(ButtonMain);
            Controls.Add(PictureBoxShape);
            Controls.Add(ButtonReset);
            Controls.Add(LabelPrice);
            Controls.Add(LabelProduct);
            Controls.Add(ListBoxPrice);
            Controls.Add(LabelPrice1);
            Controls.Add(LabelPrice2);
            Controls.Add(ButtonPurchase);
            Controls.Add(ListBoxProduct);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(780, 420);
            MinimumSize = new Size(780, 420);
            Name = "FormShopping_Cart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blyzo інтернет-магазин";
            FormClosed += FormShopping_Cart_FormClosed;
            Load += FormShopping_Cart_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxShape).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ListBox ListBoxProduct;
        private Button ButtonPurchase;
        private Label LabelPrice2;
        private Label LabelPrice1;
        private ListBox ListBoxPrice;
        private Label LabelProduct;
        private Label LabelPrice;
        private Button ButtonReset;
        private Button ButtonMain;
        private PictureBox PictureBoxShape;
        private Button ButtonShopping_Cart;
        private Button ButtonClear;
    }
}