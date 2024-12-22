using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormPurchase : Form
    {
        public FormPurchase()
        {
            InitializeComponent();
        }

        private void FormPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            bool citySelected = ComboBoxCity.SelectedIndex != -1;
            bool locationSelected = ComboBoxLocation.SelectedIndex != -1;
            bool paymentChecked = CheckBoxPayment.Checked;
            string text = TextBoxUser.Text;

            if (!citySelected && !locationSelected) { MessageBox.Show("Будь ласка, виберіть місто та відділення Нової Пошти"); }
            else if (!citySelected) { MessageBox.Show("Будь ласка, виберіть місто"); }
            else if (!locationSelected) { MessageBox.Show("Будь ласка, виберіть відділення Нової Пошти"); }
            else if (!HasAtLeastTwoSpaces(text)) { MessageBox.Show("Будь ласка, введіть ПІБ"); }
            else if (!paymentChecked) { MessageBox.Show("Будь ласка, виберіть спосіб оплати"); }
            else
            {
                ClassInformation.Processing = true;
                var Shopping_CartForm = new FormShopping_Cart();
                Shopping_CartForm.Show();
                base.Close();
            }
        }

        private static bool HasAtLeastTwoSpaces(string input)
        {
            int spaceCount = 0;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    spaceCount++;
                    if (spaceCount >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            var Shopping_CartForm = new FormShopping_Cart();
            Shopping_CartForm.Show();
            base.Close();
        }

        private void ComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCity.SelectedItem.ToString() == "Київ обл.")
            {
                ComboBoxLocation.Items.Clear();
                ComboBoxLocation.Items.Add("№252, вул. Вишгородська, 21");
                ComboBoxLocation.Items.Add("№260, просп. Академіка Заболотного, 1А");
                ComboBoxLocation.Items.Add("№297, просп. Перемоги, 131-А, (прим. 130)");
                ComboBoxLocation.Items.Add("№955, вул. Хрещатик, 21А");
                ComboBoxLocation.Items.Add("№50029, просп. Романа Шухевича, 16");
                ComboBoxLocation.Items.Add("№50049, просп. Павла Тичини, 1в");
            }
            else if (ComboBoxCity.SelectedItem.ToString() == "Житомир обл.")
            {
                ComboBoxLocation.Items.Clear();
                ComboBoxLocation.Items.Add("№16, вул. Рихліка Євгена, 11А");
                ComboBoxLocation.Items.Add("№19, вул. Чуднівська (ран. Черняховського), 92");
                ComboBoxLocation.Items.Add("№27, вул. Лятошинського Бориса, 18");
                ComboBoxLocation.Items.Add("№10139, вул. Велика Бердичівська, 95");
            }
            else
            {
                ComboBoxLocation.Items.Clear();
            }
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            foreach (var item in ClassInformation.Items)
            {
                ListBoxProduct2.Items.Add(item);
            }
            CalculateTotalPrice();
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

        private void CalculateTotalPrice()
        {
            int total = 0;

            foreach (string item in ListBoxProduct2.Items)
            {
                if (prices.ContainsKey(item))
                {
                    total += prices[item];
                }
            }

            LabelPrice.Text = $"{total}";

            foreach (string item in ListBoxProduct2.Items)
            {
                if (prices.ContainsKey(item))
                {
                    ListBoxPrice2.Items.Add(prices[item]);
                }
            }
        }

        private void ListBoxProduct2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}