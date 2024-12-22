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
    public partial class FormTablet : Form
    {
        public FormTablet()
        {
            InitializeComponent();
        }

        private void ButtonShopping_Cart_Click(object sender, EventArgs e)
        {
            var Shopping_CartForm = new FormShopping_Cart();
            Shopping_CartForm.Show();
            base.Close();
        }

        private void FormTablet_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }
        private void ButtonLaptop_Click_1(object sender, EventArgs e)
        {
            var LaptopForm = new FormLaptop();
            LaptopForm.Show();
            base.Close();
        }

        private void ButtonMobilephone_Click(object sender, EventArgs e)
        {
            var mobileForm = new FormMobilephone();
            mobileForm.Show();
            base.Close();
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            base.Close();
        }

        private void ButtonShopping_Cart_Click_1(object sender, EventArgs e)
        {
            var Shopping_CartForm = new FormShopping_Cart();
            Shopping_CartForm.Show();
            base.Close();
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            int? minValue = GetTextBoxValue(TextBoxMin);
            int? maxValue = GetTextBoxValue(TextBoxMax);
            CheckAndHideLabel(LabelPriceTablet1, minValue, maxValue);
            CheckAndHideLabel(LabelPriceTablet2, minValue, maxValue);
            CheckAndHideLabel(LabelPriceTablet3, minValue, maxValue);
        }

        private static int? GetTextBoxValue(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return null;
            }

            if (int.TryParse(textBox.Text, out var value))
            {
                return value;
            }

            MessageBox.Show($"Невірний формат числа в {textBox.Name}");
            return null;
        }

        private void CheckAndHideLabel(Label label, int? minValue, int? maxValue)
        {
            if (int.TryParse(label.Text, out var value))
            {
                bool isVisible = (!minValue.HasValue || value >= minValue) && (!maxValue.HasValue || value <= maxValue);
                label.Visible = isVisible;

                if (!isVisible)
                {
                    HideRelatedElements(label);
                }
                else
                {
                    RestoreRelatedElements(label);
                }
            }
            else
            {
                MessageBox.Show($"Невірний формат числа в {label.Name}");
            }
        }


        private void HideRelatedElements(Label label)
        {
            if (label == LabelPriceTablet1)
            {
                SetVisibility(false, PictureBoxTablet1, ButtonTablet1, LabelUAHTablet1, ButtonShopping_Cart1);
            }
            else if (label == LabelPriceTablet2)
            {
                SetVisibility(false, LabelDiscountTablet, PictureBoxTablet2, ButtonTablet2, LabelUAHTablet2, ButtonShopping_Cart2, PictureBoxdiscountTablet);
            }
            else if (label == LabelPriceTablet3)
            {
                SetVisibility(false, PictureBoxTablet3, ButtonTablet3, LabelUAHTablet3, ButtonShopping_Cart3);
            }
        }

        private void RestoreRelatedElements(Label label)
        {
            if (label == LabelPriceTablet1)
            {
                SetVisibility(true, PictureBoxTablet1, ButtonTablet1, LabelUAHTablet1, ButtonShopping_Cart1);
            }
            else if (label == LabelPriceTablet2)
            {
                SetVisibility(true, LabelDiscountTablet, PictureBoxTablet2, ButtonTablet2, LabelUAHTablet2, ButtonShopping_Cart2, PictureBoxdiscountTablet);
            }
            else if (label == LabelPriceTablet3)
            {
                SetVisibility(true, PictureBoxTablet3, ButtonTablet3, LabelUAHTablet3, ButtonShopping_Cart3);
            }
        }

        private static void SetVisibility(bool isVisible, params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control != null)
                {
                    control.Visible = isVisible;
                }
            }
        }

        private void ButtonShopping_Cart1_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Планшет Samsung Galaxy Tab S9 FE 5G 8/256GB Gray");
            ButtonShopping_Cart1.Enabled = false;
        }

        private void ButtonShopping_Cart2_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Планшет Teclast T50 LTE 8/256GB Gray");
            ButtonShopping_Cart2.Enabled = false;
        }

        private void ButtonShopping_Cart3_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Планшет Teclast P40HD LTE 8/128GB Space Gray");
            ButtonShopping_Cart3.Enabled = false;
        }

        private void ComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSearch.Text == "Планшет Samsung Galaxy Tab S9 FE 5G 8/256GB Gray") ButtonTablet1_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Планшет Teclast T50 LTE 8/256GB Gray") ButtonTablet2_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Планшет Teclast P40HD LTE 8/128GB Space Gray") ButtonTablet3_Click(null!, EventArgs.Empty);
        }

        private void ButtonTablet1_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Планшет Samsung Galaxy Tab S9 FE 5G 8/256GB Gray",
                Price = "24999",
                Description = "Серія\r\n•\tGalaxy Tab S\r\nВид екрана\r\n•\tЄмнісний\r\nОперативна пам'ять\r\n•\t8 ГБ\r\nДіагональ екрана\r\n•\t10.9\"\r\nБездротові можливості\r\n•\t3G (UMTS)\r\n•\t4G (LTE)\r\n•\t5G\r\n•\tBluetooth\r\n•\tWi-Fi\r\nВбудована пам'ять\r\n•\t256 ГБ\r\nКількість SIM-карт\r\n•\t1\r\nОпераційна система\r\n•\tAndroid\r\nКраїна-виробник\r\n•\tВ'єтнам\r\nЧастота процесора\r\n•\tпонад 1.2 ГГц\r\nРоз'єми\r\n•\tUSB Type-C\r\nПроцесор\r\n•\tSamsung Exynos 1380 (2.4 ГГц)\r\nКількість ядер процесора\r\n•\t8\r\nВерсія ОС Android\r\n•\tAndroid 13\r\nТип матриці\r\n•\tLTPS\r\nРоздільна здатність екрана\r\n•\t2304x1440\r\nНавігаційна система\r\n•\tBDS\r\n•\tGPS\r\n•\tGalileo\r\n•\tГЛОНАСС\r\nПідтримка карт пам'яті\r\n•\tmicroSD\r\nМаксимальний обсяг карт пам'яті\r\n•\t1 ТБ\r\nРозміри СІМ-карти\r\n•\tНано-СІМ\r\nОсновна камера\r\n•\t8 Мп\r\nЧастота оновлення екрана\r\n•\t90 Гц\r\nМатеріал корпусу\r\n•\tАлюміній\r\nКолір\r\n•\tСірий\r\nФронтальна камера\r\n•\t12 Мп\r\nБатарея\r\n•\t8000 мА*год\r\nШирина\r\n•\t165.8 мм\r\nВисота\r\n•\t254.3 мм\r\nГлибина\r\n•\t6.5 мм\r\nВага\r\n•\t523 г\r\nКомплектація\r\n•\tПланшет\r\nСтилус S Pen\r\nГарантійний талон\r\nКраїна реєстрації бренду\r\n•\tРеспубліка Корея (Південна Корея)\r\nГарантія\r\n•\t12 місяців",
                ImagePath = "./Assets/планшет1.png",
            };
            var itemForm = new FormItem(itemInfo, new FormTablet());
            itemForm.Show();
            this.Close();
        }

        private void ButtonTablet2_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Планшет Teclast T50 LTE 8/256GB Gray",
                Price = "8799",
                Description = "Вид екрана\r\n•\tЄмнісний\r\nОперативна пам'ять\r\n•\t8 ГБ\r\nДіагональ екрана\r\n•\t11\"\r\nБездротові можливості\r\n•\t3G (UMTS)\r\n•\t4G (LTE)\r\n•\tBluetooth\r\n•\tWi-Fi\r\nПокриття екрана\r\n•\tОлеофобне покриття\r\nВбудована пам'ять\r\n•\t256 ГБ\r\nКількість SIM-карт\r\n•\t2\r\nОпераційна система\r\n•\tAndroid\r\nКраїна-виробник\r\n•\tКитай\r\nЧастота процесора\r\n•\tпонад 1.2 ГГц\r\nРоз'єми\r\n•\tUSB Type-C\r\n•\tРоз'єм 3.5 мм\r\nПроцесор\r\n•\tUnisoc Tiger T616 (2.0 ГГц + 1.8 ГГц)\r\nКількість ядер процесора\r\n•\t6+2\r\nВерсія ОС Android\r\n•\tAndroid 12\r\nТип матриці\r\n•\tIPS\r\nРоздільна здатність екрана\r\n•\t2000x1200\r\nНавігаційна система\r\n•\tA-GPS\r\n•\tBDS\r\n•\tGPS\r\n•\tGalileo\r\n•\tГЛОНАСС\r\nПідтримка карт пам'яті\r\n•\tmicroSD\r\nМаксимальний обсяг карт пам'яті\r\n•\t1 ТБ\r\nРозміри СІМ-карти\r\n•\tНано-СІМ\r\nОсновна камера\r\n•\t20 Мп\r\nЧастота оновлення екрана\r\n•\t120 Гц\r\nМатеріал корпусу\r\n•\tАлюміній\r\nКолір\r\n•\tСірий\r\nФронтальна камера\r\n•\t8 Мп\r\nДодаткові характеристики\r\n•\tВбудована графіка: Arm Mali G57 1Core @750MHz\r\n•\tДводіапазонний Wi-Fi AC 2.4 + 5.0 GHz\r\n•\tBluetooth 5.0\r\n•\tАкселерометр\r\n•\tДатчик Холла\r\nСвітловий датчик\r\n•\tДатчик наближення\r\n•\tГіроскоп\r\n•\tІмерсивна звукова система\r\n•\t2 мікрофони\r\n•\t4 стерео динаміка\r\n•\tБатьківський контроль\r\n•\tБатарея\r\n•\t7500 мА*год\r\nШирина\r\n•\t260 мм\r\nВисота\r\n•\t164 мм\r\nГлибина\r\n•\t9.7 мм\r\nВага\r\n•\t510 г\r\nКомплектація\r\n•\tПланшет\r\n•\tUSB-кабель\r\n•\tЗарядний пристрій\r\nДокументація\r\n•\tІнструкція\r\n•\tГарантійний талон\r\nКраїна реєстрації бренду\r\n•\tКитай\r\nГарантія\r\n•\t12 місяців",
                ImagePath = "./Assets/планшет2.png",
                Discount = "10999 ₴",
                Discountpng = "./Assets/discount2.png",
            };
            var itemForm = new FormItem(itemInfo, new FormTablet());
            itemForm.Show();
            this.Close();
        }

        private void ButtonTablet3_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Планшет Teclast P40HD LTE 8/128GB Space Gray",
                Price = "10999",
                Description = "Вид екрана\r\n•\tЄмнісний\r\nОперативна пам'ять\r\n•\t8 ГБ\r\nДіагональ екрана\r\n•\t10.1\"\r\nБездротові можливості\r\n•\t3G (UMTS)\r\n•\t4G (LTE)\r\n•\tBluetooth\r\n•\tWi-Fi\r\nПокриття екрана\r\n•\tОлеофобне покриття\r\nВбудована пам'ять\r\n•\t128 ГБ\r\nКількість SIM-карт\r\n•\t2\r\nОпераційна система\r\n•\tAndroid\r\nКраїна-виробник\r\n•\tКитай\r\nЧастота процесора\r\n•\tпонад 1.2 ГГц\r\nРоз'єми\r\n•\tUSB Type-C\r\n•\tРоз'єм 3.5 мм\r\nПроцесор\r\n•\tUnisoc T606 (1.6 ГГц)\r\nКількість ядер процесора\r\n•\t6+2\r\nВерсія ОС Android\r\n•\tAndroid 13\r\nТип матриці\r\n•\tIPS\r\nРоздільна здатність екрана\r\n•\t1920x1200\r\nНавігаційна система\r\n•\tA-GPS\r\n•\tGPS\r\n•\tГЛОНАСС\r\nПідтримка карт пам'яті\r\n•\tmicroSD\r\nМаксимальний обсяг карт пам'яті\r\n•\t1 ТБ\r\nРозміри СІМ-карти\r\n•\tНано-СІМ\r\nОсновна камера\r\n•\t13 Мп\r\nМатеріал корпусу\r\n•\tМетал\r\nКолір\r\n•\tСірий\r\nФронтальна камера\r\n•\t5 Мп\r\nДодаткові характеристики\r\n•\tВбудована графіка: Arm Mali G57\r\nBluetooth 5.0\r\nАкселерометр\r\nДатчик Холла\r\nБатьківський контроль\r\nБатарея\r\n•\t6000 мА*год\r\nШирина\r\n•\t241 мм\r\nВисота\r\n•\t160.1 мм\r\nГлибина\r\n•\t8.4 мм\r\nВага\r\n•\t515 г\r\nКомплектація\r\n•\tПланшет\r\nUSB-кабель\r\nЗарядний пристрій\r\nІнструкція\r\nДокументація\r\nГарантійний талон\r\nКраїна реєстрації бренду\r\n•\tКитай\r\nГарантія\r\n•\t12 місяців",
                ImagePath = "./Assets/планшет3.png",
            };
            var itemForm = new FormItem(itemInfo, new FormTablet());
            itemForm.Show();
            this.Close();
        }

        private void FormTablet_Load(object sender, EventArgs e)
        {
            ButtonShopping_Cart1.Enabled = !ClassInformation.Items.Contains("Планшет Samsung Galaxy Tab S9 FE 5G 8/256GB Gray");
            ButtonShopping_Cart2.Enabled = !ClassInformation.Items.Contains("Планшет Teclast T50 LTE 8/256GB Gray");
            ButtonShopping_Cart3.Enabled = !ClassInformation.Items.Contains("Планшет Teclast P40HD LTE 8/128GB Space Gray");
        }

        private void PictureBoxTablet1_Click(object sender, EventArgs e)
        {

        }
    }
}