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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            int? minValue = GetTextBoxValue(TextBoxMin);
            int? maxValue = GetTextBoxValue(TextBoxMax);
            CheckAndHideLabel(LabelPrice1, minValue, maxValue);
            CheckAndHideLabel(LabelPrice2, minValue, maxValue);
            CheckAndHideLabel(LabelPrice3, minValue, maxValue);
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
            if (label == LabelPrice1)
            {
                SetVisibility(false, LabelDiscount1, PictureBoxProduct1, ButtonProduct1, LabelUAH1, ButtonShopping_Cart1);
                if (PictureBoxdiscount1Exists())
                {
                    PictureBoxdiscountMobilephone.Visible = false;
                }
            }
            else if (label == LabelPrice2)
            {
                SetVisibility(false, LabelDiscount2, PictureBoxProduct2, ButtonProduct2, LabelUAH2, ButtonShopping_Cart2);
                if (PictureBoxdiscount2Exists())
                {
                    PictureBoxdiscountLaptop.Visible = false;
                }
            }
            else if (label == LabelPrice3)
            {
                SetVisibility(false, LabelDiscount3, PictureBoxProduct3, ButtonProduct3, LabelUAH3, ButtonShopping_Cart3);
                if (PictureBoxdiscount3Exists())
                {
                    PictureBoxdiscountTablet.Visible = false;
                }
            }
        }

        private void RestoreRelatedElements(Label label)
        {
            if (label == LabelPrice1)
            {
                SetVisibility(true, LabelDiscount1, PictureBoxProduct1, ButtonProduct1, LabelUAH1, ButtonShopping_Cart1);
                if (PictureBoxdiscount1Exists())
                {
                    PictureBoxdiscountMobilephone.Visible = true;
                }
            }
            else if (label == LabelPrice2)
            {
                SetVisibility(true, LabelDiscount2, PictureBoxProduct2, ButtonProduct2, LabelUAH2, ButtonShopping_Cart2);
                if (PictureBoxdiscount2Exists())
                {
                    PictureBoxdiscountLaptop.Visible = true;
                }
            }
            else if (label == LabelPrice3)
            {
                SetVisibility(true, LabelDiscount3, PictureBoxProduct3, ButtonProduct3, LabelUAH3, ButtonShopping_Cart3);
                if (PictureBoxdiscount3Exists())
                {
                    PictureBoxdiscountTablet.Visible = true;
                }
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

        private bool PictureBoxdiscount1Exists()
        {
            return PictureBoxdiscountMobilephone != null;
        }

        private bool PictureBoxdiscount2Exists()
        {
            return PictureBoxdiscountLaptop != null;
        }

        private bool PictureBoxdiscount3Exists()
        {
            return PictureBoxdiscountTablet != null;
        }

        private void ButtonMobilephone_Click(object sender, EventArgs e)
        {
            var mobileForm = new FormMobilephone();
            mobileForm.Show();
            base.Close();
        }


        private void ButtonTablet_Click(object sender, EventArgs e)
        {
            var tabletForm = new FormTablet();
            tabletForm.Show();
            base.Close();
        }

        private void ButtonLaptop_Click(object sender, EventArgs e)
        {
            var LaptopForm = new FormLaptop();
            LaptopForm.Show();
            base.Close();
        }

        private void ButtonShopping_Cart_Click(object sender, EventArgs e)
        {
            if (ClassInformation.Process != true)
            {
                var Shopping_CartForm = new FormShopping_Cart();
                Shopping_CartForm.Show();
                base.Close();
            }
            else
            {
                ClassInformation.Process = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void ButtonShopping_Cart1_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Мобільний телефон Apple iPhone 15 128GB");
            ButtonShopping_Cart1.Enabled = false;

        }

        private void ButtonShopping_Cart2_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Ноутбук Acer Aspire 3 A315-58-553J Pure Silver");
            ButtonShopping_Cart2.Enabled = false;
        }

        private void ButtonShopping_Cart3_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Планшет Teclast T50 LTE 8/256GB Gray");
            ButtonShopping_Cart3.Enabled = false;
        }

        private void ComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSearch.Text == "Мобільний телефон Apple iPhone 15 128GB") ButtonProduct1_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Ноутбук Acer Aspire 3 A315-58-553J Pure Silver") ButtonProduct2_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Планшет Teclast T50 LTE 8/256GB Gray") ButtonProduct3_Click(null!, EventArgs.Empty);
        }

        private void ButtonProduct1_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Мобільний телефон Apple iPhone 15 128GB",
                Price = "38499",
                Description = "Серія\r\n•\tiPhone 15\r\nСтандарт зв'язку\r\n•\t2G (GPRS/EDGE)\r\n•\t3G (WCDMA/UMTS/HSPA)\r\n•\t4G (LTE)\r\n•\t5G\r\nДіагональ екрана\r\n•\t6.1\r\nРоздільна здатність дисплея\r\n•\t2556x1179\r\nТип матриці\r\n•\tOLED (Super Retina XDR)\r\nЧастота оновлення екрана\r\n•\t60 Гц\r\nМатеріал екрана\r\n•\tCeramic Shield\r\nКількість SIM-карток\r\n•\t2\r\nРозміри SIM-картки\r\n•\tNano-SIM\r\nВбудована пам'ять\r\n•\t128 ГБ\r\nМаксимальний обсяг підтримуваної карти пам'яті\r\n•\tНемає\r\nОпераційна система\r\n•\tiOS\r\nФронтальна камера\r\n•\t12 Мп\r\nОсобливості фронтальної камери\r\n•\tАвтофокус\r\n•\tОдинарна\r\n•\tПідтримка знімання 4К\r\n•\tСтабілізація\r\n•\tФронтальний спалах\r\nРозміщення фронтальної камери\r\n•\tВиріз\r\nВид фронтального спалаху\r\n•\tПрограмний\r\nЗапис відео фронтальної камери\r\n•\t4K/3840x2160/стереозвук\r\nНазва процесора\r\n•\tApple A16 Bionic\r\nКількість ядер\r\n•\t2+4\r\nСерія Apple\r\n•\tApple Ax Series\r\nОсновна камера\r\n•\t48 Мп + 12 Мп\r\nОсобливості основної камери\r\n•\tАвтофокус\r\n•\tПідтримка знімання 4К\r\n•\tСпалах\r\n•\tСтабілізація\r\n•\tУльтраширококутний об'єктив\r\n•\tШирококутний об'єктив\r\nКількість основних камер\r\n•\t2\r\nЗапис відео основної камери\r\n•\t4K/3840x2160/стереозвук\r\nМетод стабілізації\r\n•\tОптична\r\nМатеріал корпуса\r\n•\tАлюміній + скло\r\nРоз'єми\r\n•\tUSB Type-C\r\nНавігація\r\n•\tA-GPS\r\n•\tBDS\r\n•\tGPS\r\n•\tГЛОНАСС\r\n•\tЦифровий компас\r\nВага, г\r\n•\t171\r\nШирина\r\n•\t71.6 мм\r\nВисота\r\n•\t147.6 мм\r\nГлибина\r\n•\t7.8 мм\r\nБезпека\r\n•\tРозблокування за обличчям\r\nСтупінь пило/вологозахисту\r\n•\tIP68\r\nДатчики\r\n•\tАкселерометр\r\n•\tБарометр\r\n•\tГіроскоп\r\n•\tДатчик наближення\r\n•\tДатчик освітлення\r\n•\tКабель для синхронізації\r\nБездротові технології\r\n•\tBluetooth 5.3\r\n•\tNFC\r\n•\tWi-Fi\r\n•\tБездротова зарядка\r\nОснащення\r\n•\tПідтримка e-SIM\r\n•\tШвидке заряджання\r\nФорм-фактор\r\n•\tМоноблок\r\nОсобливості корпусу\r\n•\tБезрамковий дисплей\r\n•\tВодонепроникні\r\nКолір\r\n•\tBlack\r\nКраїна реєстрації бренду\r\n•\tСША\r\nГарантія\r\n•\t12 місяців\r\nКраїна-виробник товару\r\n•\tКитай",
                ImagePath = "./Assets/телефон1.png",
                Discount = "48123 ₴",
                Discountpng = "./Assets/discount3.png",
            };
            var itemForm = new FormItem(itemInfo, new MainForm());
            itemForm.Show();
            this.Close();
        }

        private void ButtonProduct2_Click(object sender, EventArgs e)
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
            var itemForm = new FormItem(itemInfo, new MainForm());
            itemForm.Show();
            this.Close();
        }

        private void ButtonProduct3_Click(object sender, EventArgs e)
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
            var itemForm = new FormItem(itemInfo, new MainForm());
            itemForm.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ButtonShopping_Cart1.Enabled = !ClassInformation.Items.Contains("Мобільний телефон Apple iPhone 15 128GB");
            ButtonShopping_Cart2.Enabled = !ClassInformation.Items.Contains("Ноутбук Acer Aspire 3 A315-58-553J Pure Silver");
            ButtonShopping_Cart3.Enabled = !ClassInformation.Items.Contains("Планшет Teclast T50 LTE 8/256GB Gray");
        }

        private void PictureBoxProduct1_Click(object sender, EventArgs e)
        {

        }
    }
}