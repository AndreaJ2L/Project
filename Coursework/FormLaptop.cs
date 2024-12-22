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
    public partial class FormLaptop : Form
    {
        public FormLaptop()
        {
            InitializeComponent();
        }

        private void ButtonMobilephone_Click(object sender, EventArgs e)
        {
            var mobileForm = new FormMobilephone();
            mobileForm.Show();
            base.Close();
        }
        private void ButtonTablet_Click_1(object sender, EventArgs e)
        {
            var tabletForm = new FormTablet();
            tabletForm.Show();
            base.Close();
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            base.Close();
        }

        private void ButtonShopping_Cart_Click(object sender, EventArgs e)
        {
            var Shopping_CartForm = new FormShopping_Cart();
            Shopping_CartForm.Show();
            base.Close();
        }

        private void FormLaptop_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            int? minValue = GetTextBoxValue(TextBoxMin);
            int? maxValue = GetTextBoxValue(TextBoxMax);
            CheckAndHideLabel(LabelLaptop1, minValue, maxValue);
            CheckAndHideLabel(LabelLaptop2, minValue, maxValue);
            CheckAndHideLabel(LabelLaptop3, minValue, maxValue);
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
            if (label == LabelLaptop1)
            {
                SetVisibility(false, PictureBoxLaptop1, ButtonLaptop1, LabelUAH1, ButtonShopping_Cart1);
            }
            else if (label == LabelLaptop2)
            {
                SetVisibility(false, LabelDiscountLaptop, PictureBoxLaptop2, ButtonLaptop2, LabelUAH2, ButtonShopping_Cart2, PictureBoxdiscountLaptop);
            }
            else if (label == LabelLaptop3)
            {
                SetVisibility(false, PictureBoxLaptop3, ButtonLaptop3, LabelUAH3, ButtonShopping_Cart3);
            }
        }

        private void RestoreRelatedElements(Label label)
        {
            if (label == LabelLaptop1)
            {
                SetVisibility(true, PictureBoxLaptop1, ButtonLaptop1, LabelUAH1, ButtonShopping_Cart1);
            }
            else if (label == LabelLaptop2)
            {
                SetVisibility(true, LabelDiscountLaptop, PictureBoxLaptop2, ButtonLaptop2, LabelUAH2, ButtonShopping_Cart2, PictureBoxdiscountLaptop);
            }
            else if (label == LabelLaptop3)
            {
                SetVisibility(true, PictureBoxLaptop3, ButtonLaptop3, LabelUAH3, ButtonShopping_Cart3);
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
            ClassInformation.Items.Add("Ноутбук Acer Nitro 5 AN517-54-72WJ Shale Black");
            ButtonShopping_Cart1.Enabled = false;
        }

        private void ButtonShopping_Cart2_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Ноутбук Acer Aspire 3 A315-58-553J Pure Silver");
            ButtonShopping_Cart2.Enabled = false;
        }

        private void ButtonShopping_Cart3_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Ноутбук ASUS Vivobook Go 15 E510KA-EJ297 Star Black");
            ButtonShopping_Cart3.Enabled = false;
        }

        private void ComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSearch.Text == "Ноутбук Acer Nitro 5 AN517-54-72WJ Shale Black") ButtonLaptop1_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Ноутбук Acer Aspire 3 A315-58-553J Pure Silver") ButtonLaptop2_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Ноутбук ASUS Vivobook Go 15 E510KA-EJ297 Star Black") ButtonLaptop3_Click(null!, EventArgs.Empty);
        }

        private void ButtonLaptop1_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Ноутбук Acer Nitro 5 AN517-54-72WJ Shale Black",
                Price = "37999",
                Description = "Серія\r\n•\tNitro\r\nДіагональ екрану\r\n•\t17.3\"\r\nТип екрану\r\n•\tIPS\r\nЧастота оновлення екрану\r\n•\t144 Гц\r\nРоздільна здатність\r\n•\t1920x1080\r\nПокриття екрану\r\n•\tМатове\r\nВиробник відеокарти\r\n•\tNvidia\r\nДискретна відеокарта\r\n•\tGeForce RTX 3050\r\nОбсяг пам'яті відеокарти\r\n•\t4 ГБ\r\nТип відеокарти\r\n•\tДискретна\r\nОбсяг SSD\r\n•\t512 ГБ\r\nТип накопичувача\r\n•\tSSD\r\nПроцесор\r\n•\tШестиядерний Intel Core i7-11600H (2.5 - 4.6 ГГц)\r\nОпераційна система\r\n•\tБез ОС\r\nПокоління процесора Intel\r\n•\t11-ое Tiger Lake\r\nОбсяг оперативної пам'яті\r\n•\t16 ГБ\r\nТип оперативної пам'яті\r\n•\tDDR4\r\nМожливість апгрейду\r\n•\t2 слоти оперативної пам'яті\r\nХарактеристики оперативної пам'яті\r\n•\tDDR4-3200 МГц\r\nМережеві адаптери\r\n•\tWi-Fi 802.11ax\r\nBluetooth 5.1\r\nGigabit Ethernet\r\nРоз'єми та порти введення-виведення\r\n•\t1 x USB 3.2 Type-C Gen2 (Thunderbolt 4, DisplayPort) / 1 x USB 3.2 Type-A Gen2 / 2 x USB 3.2 Type-A Gen1 / HDMI / LAN (RJ-45) / комбінований аудіороз'єм для навушників / мікрофона\r\nБезпровідний зв'язок\r\n•\tBluetooth 5.1\r\n•\tWi-Fi 6\r\nВага, кг\r\n•\t2.7\r\nЄмність акумулятора\r\n•\t57 Вт*год\r\nКолір\r\n•\tЧорний\r\nМаніпулятори\r\n•\tТачпад\r\nМатеріал корпусу\r\n•\tПластик\r\nГабарити (Ш х Г х В)\r\n•\t403.5 x 280 x 24.9 мм\r\nКороткі характеристики\r\n•\tЕкран 17.3” IPS (1920x1080) Full HD 144 Гц, матовий / Intel Core i7-11600H (2.5 - 4.6 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce RTX 3050, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / вебкамера / без ОС / 2.7 кг / чорний\r\nКраїна-виробник\r\n•\tКитай\r\nДодатково\r\n•\tЗ Українською розкладкою\r\n•\tЗ підсвіткою клавіатури\r\n•\tПорт Thunderbolt\r\nВид\r\n•\tНоутбуки\r\nДодаткові можливості\r\n•\tВебкамера\r\nУбудований мікрофон\r\nУбудовані динаміки\r\nКомплект постачання\r\n•\tНоутбук\r\nАдаптер живлення\r\nДокументація\r\nКраїна реєстрації бренду\r\n•\tКитай (Тайвань)\r\nГаряча лінія виробника\r\n•\tAcer 0-800-301-032 Пн~Пт, 10:00-18:00\r\nГарантія\r\n•\t12 місяців",
                ImagePath = "./Assets/ноутбук1.png",
            };
            var itemForm = new FormItem(itemInfo, new FormLaptop());
            itemForm.Show();
            this.Close();
        }

        private void ButtonLaptop2_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Ноутбук Acer Aspire 3 A315-58-553J Pure Silver",
                Price = "20999",
                Description = "Серія\r\n•\tAspire 3\r\nДіагональ екрану\r\n•\t15.6\"\r\nТип екрану\r\n•\tIPS\r\nЧастота оновлення екрану\r\n•\t60 Гц\r\nРоздільна здатність\r\n•\t1920x1080\r\nПокриття екрану\r\n•\tМатове\r\nВбудована камера\r\n•\tHD веб-камера\r\nВиробник відеокарти\r\n•\tIntel\r\nТип відеокарти\r\n•\tІнтегрована\r\nІнтегрована відеокарта\r\n•\tIris Xe Graphics\r\nОбсяг SSD\r\n•\t1 ТБ\r\nСтандарт інтерфейсу SSD M.2\r\n•\tPCI Express 3.0 x4\r\nКількість відсіків 2.5\" SATA для HDD/SSD\r\n•\t1\r\nТип накопичувача\r\n•\tSSD\r\nПроцесор\r\n•\tЧотириядерний Intel Core i5-1135G7\r\nОпераційна система\r\n•\tБез ОС\r\nПокоління процесора Intel\r\n•\t11-ое Tiger Lake\r\nОбсяг оперативної пам'яті\r\n•\t16 ГБ\r\nТип оперативної пам'яті\r\n•\tDDR4\r\nМожливість апгрейду\r\n•\t1 слот оперативної пам'яті\r\nМережеві адаптери\r\n•\tWi-Fi 802.11ax\r\nBluetooth 5.0\r\nGigabit Ethernet\r\nРоз'єми та порти введення-виведення\r\n•\t2 x USB 3.2 Gen1\r\n•\t1 x USB 2.0\r\n•\tHDMI\r\n•\tLAN (RJ-45)\r\n•\tкомбінований аудіороз'єм для навушників/мікрофону\r\nБезпровідний зв'язок\r\n•\tBluetooth 5.0\r\n•\tWi-Fi 6\r\nВага, кг\r\n•\t1.8\r\nЄмність акумулятора\r\n•\t48 Вт*год\r\nКолір\r\n•\tСріблястий\r\nМаніпулятори\r\n•\tТачпад\r\nМатеріал корпусу\r\n•\tПластик\r\nХарактеристики батареї\r\n•\tЛітій-іонна 2-елементна, 48 Вт*год\r\nГабарити (Ш х Г х В)\r\n•\t363.4 x 238.4 x 19.9 мм\r\nКороткі характеристики\r\n•\tЕкран 15.6\" IPS (1920x1080) Full HD\r\n•\tIntel Core i5-1135G7 (2.4 - 4.2 ГГц)\r\n•\tRAM 16 ГБ\r\n•\tSSD 1 ТБ\r\n•\tIntel Iris Xe Graphics\r\n•\tLAN\r\n•\tWi-Fi\r\n•\tBluetooth\r\n•\tвебкамера\r\n•\t1.8 кг\r\n•\tсріблястий\r\nКраїна-виробник\r\n•\tКитай\r\nДодатково\r\n•\tЗ Українською розкладкою\r\nВид\r\n•\tНоутбуки\r\nДодаткові можливості\r\n•\tВеб-камера\r\nВбудований мікрофон\r\nВбудовані динаміки\r\nКомплект постачання\r\n•\tНоутбук\r\nАдаптер живлення\r\nКраїна реєстрації бренду\r\n•\tКитай (Тайвань)\r\nГаряча лінія виробника\r\n•\tAcer 0-800-301-032 Пн~Пт, 10:00-18:00\r\nГарантія\r\n•\t12 місяців",
                ImagePath = "./Assets/ноутбук2.png",
                Discount = "22104 ₴",
                Discountpng = "./Assets/discount1.png",
            };
            var itemForm = new FormItem(itemInfo, new FormLaptop());
            itemForm.Show();
            base.Close();
        }

        private void ButtonLaptop3_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Ноутбук ASUS Vivobook Go 15 E510KA-EJ297 Star Black",
                Price = "13999",
                Description = "Серія\r\n•\tVivobook Go\r\nДіагональ екрану\r\n•\t15.6\"\r\nЧастота оновлення екрану\r\n•\t60 Гц\r\nРоздільна здатність\r\n•\t1920x1080\r\nПокриття екрану\r\n•\tМатове\r\nВбудована камера\r\n•\tVGA\r\nВиробник відеокарти\r\n•\tIntel\r\nТип відеокарти\r\n•\tІнтегрована\r\nІнтегрована відеокарта\r\n•\tUHD Graphics\r\nОбсяг SSD\r\n•\t256 ГБ\r\nКількість слотів M.2\r\n•\t1\r\nСтандарт інтерфейсу SSD M.2\r\n•\tPCI Express 3.0 x2\r\nТип накопичувача\r\n•\tSSD\r\nПроцесор\r\n•\tДвоядерний Intel Celeron N4500 (1.1-2.8 ГГц)\r\nОпераційна система\r\n•\tБез ОС\r\nОбсяг оперативної пам'яті\r\n•\t8 ГБ\r\nТип оперативної пам'яті\r\n•\tDDR4\r\nМережеві адаптери\r\n•\tWi-Fi 5 (802.11ac)\r\nBluetooth 4.1\r\nРоз'єми та порти введення-виведення\r\n•\t1 x USB 2.0 / 1 x USB 3.2 Gen1 / 1 x USB 3.2 Gen1 Type-C / HDMI / комбінований аудіороз'єм для навушників/мікрофону\r\nБезпровідний зв'язок\r\n•\tBluetooth 4.1\r\n•\tWi-Fi 5\r\nВага, кг\r\n•\t1.57\r\nЄмність акумулятора\r\n•\t42 Вт*год\r\nКолір\r\n•\tЧорний\r\nЗвукова система\r\n•\tSonicMaster\r\nВбудований динамік\r\nВбудований мікрофон\r\nМаніпулятори\r\n•\tТачпад\r\nМатеріал корпусу\r\n•\tПластик\r\nХарактеристики батареї\r\n•\tЛітій-іонна, 3-осередкова, 42 Вт * год\r\nГабарити (Ш х Г х В)\r\n•\t360.2 x 236.4 x 18.1 мм\r\nКороткі характеристики\r\n•\tЕкран 15.6\" (1920x1080) Full HD, матовий / Intel Celeron N4500 (1.1 - 2.8 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel UHD Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.57 кг / чорний\r\nКраїна-виробник\r\n•\tКитай\r\nДодатково\r\n•\tЗ Українською розкладкою\r\nВид\r\n•\tНоутбуки\r\nДодаткові можливості\r\n•\tВеб-камера\r\nВбудовані динаміки\r\nВбудований мікрофон\r\nКомплект постачання\r\n•\tНоутбук\r\nАдаптер живлення\r\nДокументація\r\nКраїна реєстрації бренду\r\n•\tКитай (Тайвань)\r\nГаряча лінія виробника\r\n•\tASUS +38 044 545-77-27 Пн - Пт, 09:00-18:00\r\nГарантія\r\n•\t12 місяців",
                ImagePath = "./Assets/ноутбук3.png",

            };
            var itemForm = new FormItem(itemInfo, new FormLaptop());
            itemForm.Show();
            this.Close();
        }

        private void FormLaptop_Load(object sender, EventArgs e)
        {
            ButtonShopping_Cart1.Enabled = !ClassInformation.Items.Contains("Ноутбук Acer Nitro 5 AN517-54-72WJ Shale Black");
            ButtonShopping_Cart2.Enabled = !ClassInformation.Items.Contains("Ноутбук Acer Aspire 3 A315-58-553J Pure Silver");
            ButtonShopping_Cart3.Enabled = !ClassInformation.Items.Contains("Ноутбук ASUS Vivobook Go 15 E510KA-EJ297 Star Black");
        }

        private void PictureBoxLaptop3_Click(object sender, EventArgs e)
        {

        }
    }
}