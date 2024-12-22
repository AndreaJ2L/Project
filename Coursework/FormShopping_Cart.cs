using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormShopping_Cart : Form
    {
        public FormShopping_Cart()
        {
            InitializeComponent();
            ButtonPurchase.Enabled = ClassInformation.Items.Count > 0;
            LoadProducts();
            foreach (string item in ListBoxProduct.Items)
            {
                if (prices.ContainsKey(item))
                {
                    ListBoxPrice.Items.Add(prices[item]);
                }
            }
            CalculateTotalPrice();
            ListBoxProduct.SelectedIndexChanged += ListBoxProduct_SelectedIndexChanged;
            LabelPrice2 = new Label { Text = "", Dock = DockStyle.Bottom };
            Controls.Add(ListBoxProduct);
            Controls.Add(LabelPrice2);
        }

        private readonly Dictionary<string, int> prices = new()
        {
            {"Мобільний телефон Apple iPhone 15 128GB", 38499},
            {"Мобільний телефон Samsung Galaxy A24 128GB Dark Red", 8499},
            {"Мобільний телефон Infinix Hot 30 Play NFC 8/128 GB Mirage Black", 5299},
            {"Ноутбук Acer Nitro 5 AN517-54-72WJ Shale Black", 37999},
            {"Ноутбук Acer Aspire 3 A315-58-553J Pure Silver", 20999},
            {"Ноутбук ASUS Vivobook Go 15 E510KA-EJ297 Star Black", 13999},
            {"Планшет Samsung Galaxy Tab S9 FE 5G 8/256GB Gray", 24999},
            {"Планшет Teclast T50 LTE 8/256GB Gray", 8799},
            {"Планшет Teclast P40HD LTE 8/128GB Space Gray", 10999},
        };

        private void LoadProducts()
        {
            foreach (var item in ClassInformation.Items)
            {
                ListBoxProduct.Items.Add(item);
            }
        }

        private void CalculateTotalPrice()
        {
            int total = 0;

            foreach (string item in ListBoxProduct.Items)
            {
                if (prices.ContainsKey(item))
                {
                    total += prices[item];
                }
            }
            LabelPrice2.Text = $"{total}";
        }


        private void ListBoxProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Close();
        }

        private void FormShopping_Cart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            if (ClassInformation.Processing)
            {
                MessageBox.Show("Замовлення обробляється");
            }
            else if (ClassInformation.Processing != true)
            {
                var PurchaseForm = new FormPurchase();
                PurchaseForm.Show();
                base.Close();
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (ClassInformation.Processing)
            {
                ClassInformation.Processing = false;
                ButtonReset.Enabled = false;
                MessageBox.Show("Замовлення було скасовано");
                var Shopping_CartForm = new FormShopping_Cart();
                Shopping_CartForm.Show();
                base.Close();
            }
        }

        private void FormShopping_Cart_Load(object sender, EventArgs e)
        {
            if (ClassInformation.Processing)
            {
                ButtonPurchase.BackColor = System.Drawing.Color.MediumSlateBlue;
                ButtonPurchase.Text = "Замовлення обробляється";
                ButtonPurchase.Enabled = false;
            }
            else
            {
                ButtonReset.Enabled = false;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (ListBoxProduct.SelectedIndex == -1)
            {
                return;
            }
            ClassInformation.Items.RemoveAt(ListBoxProduct.SelectedIndex);
            ClassInformation.Processing = false;
            var Shopping_CartForm = new FormShopping_Cart();
            Shopping_CartForm.Show();
            base.Close();
        }
    }
}