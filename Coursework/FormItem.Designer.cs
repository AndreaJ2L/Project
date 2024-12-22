namespace Coursework
{
    partial class FormItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItem));
            PictureBoxItem = new PictureBox();
            PictureBoxdiscount = new PictureBox();
            LabelItem = new Label();
            RichTextBoxItem = new RichTextBox();
            LabelDescription = new Label();
            Labeldiscount = new Label();
            ButtonShopping_Cart = new Button();
            RichTextBoxName = new RichTextBox();
            LabelUAH = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBoxItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxdiscount).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxItem
            // 
            PictureBoxItem.BackColor = Color.Transparent;
            PictureBoxItem.Image = (Image)resources.GetObject("PictureBoxItem.Image");
            PictureBoxItem.Location = new Point(12, 12);
            PictureBoxItem.Name = "PictureBoxItem";
            PictureBoxItem.Size = new Size(250, 333);
            PictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxItem.TabIndex = 103;
            PictureBoxItem.TabStop = false;
            PictureBoxItem.Click += PictureBoxItem_Click;
            // 
            // PictureBoxdiscount
            // 
            PictureBoxdiscount.BackColor = Color.Transparent;
            PictureBoxdiscount.Location = new Point(217, 12);
            PictureBoxdiscount.Name = "PictureBoxdiscount";
            PictureBoxdiscount.Size = new Size(45, 45);
            PictureBoxdiscount.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxdiscount.TabIndex = 138;
            PictureBoxdiscount.TabStop = false;
            // 
            // LabelItem
            // 
            LabelItem.AutoSize = true;
            LabelItem.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelItem.ForeColor = Color.Red;
            LabelItem.Location = new Point(12, 348);
            LabelItem.Name = "LabelItem";
            LabelItem.Size = new Size(47, 21);
            LabelItem.TabIndex = 209;
            LabelItem.Text = "Ціна";
            // 
            // RichTextBoxItem
            // 
            RichTextBoxItem.BackColor = Color.White;
            RichTextBoxItem.BorderStyle = BorderStyle.None;
            RichTextBoxItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RichTextBoxItem.ForeColor = Color.Black;
            RichTextBoxItem.Location = new Point(268, 86);
            RichTextBoxItem.Name = "RichTextBoxItem";
            RichTextBoxItem.ReadOnly = true;
            RichTextBoxItem.Size = new Size(425, 283);
            RichTextBoxItem.TabIndex = 210;
            RichTextBoxItem.Text = "";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDescription.ForeColor = Color.Black;
            LabelDescription.Location = new Point(405, 58);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(174, 25);
            LabelDescription.TabIndex = 211;
            LabelDescription.Text = "Характеристики";
            // 
            // Labeldiscount
            // 
            Labeldiscount.AutoSize = true;
            Labeldiscount.Font = new Font("Arial", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            Labeldiscount.ForeColor = Color.DarkGray;
            Labeldiscount.Location = new Point(122, 351);
            Labeldiscount.Name = "Labeldiscount";
            Labeldiscount.Size = new Size(41, 15);
            Labeldiscount.TabIndex = 214;
            Labeldiscount.Text = "ціна ₴";
            // 
            // ButtonShopping_Cart
            // 
            ButtonShopping_Cart.BackColor = Color.Transparent;
            ButtonShopping_Cart.FlatAppearance.BorderSize = 0;
            ButtonShopping_Cart.FlatStyle = FlatStyle.Flat;
            ButtonShopping_Cart.Image = (Image)resources.GetObject("ButtonShopping_Cart.Image");
            ButtonShopping_Cart.Location = new Point(233, 348);
            ButtonShopping_Cart.Name = "ButtonShopping_Cart";
            ButtonShopping_Cart.Size = new Size(29, 28);
            ButtonShopping_Cart.TabIndex = 215;
            ButtonShopping_Cart.UseVisualStyleBackColor = false;
            ButtonShopping_Cart.Click += ButtonShopping_Cart_Click;
            // 
            // RichTextBoxName
            // 
            RichTextBoxName.BackColor = Color.White;
            RichTextBoxName.BorderStyle = BorderStyle.None;
            RichTextBoxName.Enabled = false;
            RichTextBoxName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RichTextBoxName.ForeColor = Color.Black;
            RichTextBoxName.Location = new Point(268, 12);
            RichTextBoxName.Name = "RichTextBoxName";
            RichTextBoxName.ReadOnly = true;
            RichTextBoxName.Size = new Size(425, 43);
            RichTextBoxName.TabIndex = 216;
            RichTextBoxName.Text = "";
            // 
            // LabelUAH
            // 
            LabelUAH.AutoSize = true;
            LabelUAH.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUAH.ForeColor = Color.Red;
            LabelUAH.Location = new Point(65, 348);
            LabelUAH.Name = "LabelUAH";
            LabelUAH.Size = new Size(20, 21);
            LabelUAH.TabIndex = 217;
            LabelUAH.Text = "₴";
            // 
            // FormItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 381);
            Controls.Add(LabelUAH);
            Controls.Add(RichTextBoxName);
            Controls.Add(ButtonShopping_Cart);
            Controls.Add(Labeldiscount);
            Controls.Add(LabelDescription);
            Controls.Add(RichTextBoxItem);
            Controls.Add(LabelItem);
            Controls.Add(PictureBoxdiscount);
            Controls.Add(PictureBoxItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(720, 420);
            MinimumSize = new Size(720, 420);
            Name = "FormItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blyzo інтернет-магазин";
            FormClosed += ItemForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)PictureBoxItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxdiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox PictureBoxItem;
        private PictureBox PictureBoxdiscount;
        private Label LabelItem;
        private Label LabelDescription;
        private RichTextBox RichTextBoxItem;
        private Label Labeldiscount;
        private Button ButtonShopping_Cart;
        private RichTextBox RichTextBoxName;
        private Label LabelUAH;
    }
}