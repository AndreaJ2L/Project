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
    public partial class FormMobilephone : Form
    {
        public FormMobilephone()
        {
            InitializeComponent();
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
            var Shopping_CartForm = new FormShopping_Cart();
            Shopping_CartForm.Show();
            base.Close();
        }


        private void FormMobilephone_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            base.Close();
        }
        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            HandlePriceLimits();
        }

        private void HandlePriceLimits()
        {
            int? minValue = GetTextBoxValue(TextBoxMin);
            int? maxValue = GetTextBoxValue(TextBoxMax);
            CheckAndHideLabel(LabelPriceMobilephone1, minValue, maxValue);
            CheckAndHideLabel(LabelPriceMobilephone2, minValue, maxValue);
            CheckAndHideLabel(LabelPriceMobilephone3, minValue, maxValue);
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
            if (label == LabelPriceMobilephone1)
            {
                SetVisibility(false, PictureBoxdiscountMobilephone, LabelDiscountMobilephone, PictureBoxMobilephone1, ButtonMobilephone1, LabelUAHMobilephone1, ButtonShopping_Cart1);
            }
            else if (label == LabelPriceMobilephone2)
            {
                SetVisibility(false, PictureBoxMobilephone2, ButtonMobilephone2, LabelUAHMobilephone2, ButtonShopping_Cart2);
            }
            else if (label == LabelPriceMobilephone3)
            {
                SetVisibility(false, PictureBoxMobilephone3, ButtonMobilephone3, LabelUAHMobilephone3, ButtonShopping_Cart3);
            }
        }

        private void RestoreRelatedElements(Label label)
        {
            if (label == LabelPriceMobilephone1)
            {
                SetVisibility(true, PictureBoxdiscountMobilephone, PictureBoxdiscountMobilephone, LabelDiscountMobilephone, PictureBoxMobilephone1, ButtonMobilephone1, LabelUAHMobilephone1, ButtonShopping_Cart1);
            }
            else if (label == LabelPriceMobilephone2)
            {
                SetVisibility(true, PictureBoxMobilephone2, ButtonMobilephone2, LabelUAHMobilephone2, ButtonShopping_Cart2);
            }
            else if (label == LabelPriceMobilephone3)
            {
                SetVisibility(true, PictureBoxMobilephone3, ButtonMobilephone3, LabelUAHMobilephone3, ButtonShopping_Cart3);
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
            ClassInformation.Items.Add("Мобільний телефон Apple iPhone 15 128GB");
            ButtonShopping_Cart1.Enabled = false;
        }

        private void ButtonShopping_Cart2_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Мобільний телефон Samsung Galaxy A24 128GB Dark Red");
            ButtonShopping_Cart2.Enabled = false;
        }

        private void ButtonShopping_Cart3_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add("Мобільний телефон Infinix Hot 30 Play NFC 8/128 GB Mirage Black");
            ButtonShopping_Cart3.Enabled = false;
        }

        private void ComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSearch.Text == "Мобільний телефон Apple iPhone 15 128GB") ButtonMobilephone1_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Мобільний телефон Samsung Galaxy A24 128GB Dark Red") ButtonMobilephone2_Click(null!, EventArgs.Empty);
            else if (ComboBoxSearch.Text == "Мобільний телефон Infinix Hot 30 Play NFC 8/128 GB Mirage Black") ButtonMobilephone3_Click(null!, EventArgs.Empty);
        }

        private void ButtonMobilephone1_Click(object sender, EventArgs e)
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
            var itemForm = new FormItem(itemInfo, new FormMobilephone());
            itemForm.Show();
            this.Close();
        }

        private void ButtonMobilephone2_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Мобільний телефон Samsung Galaxy A24 128GB Dark Red",
                Price = "8499",
                Description = "Серія\r\n•\tGalaxy A\r\nСтандарт зв'язку\r\n•\t2G (GPRS/EDGE)\r\n•\t3G (WCDMA/UMTS/HSPA)\r\n•\t4G (LTE)\r\nДіагональ екрана\r\n•\t6.5\r\nРоздільна здатність дисплея\r\n•\t2340 x 1080\r\nТип матриці\r\n•\tSuper AMOLED\r\nЧастота оновлення екрана\r\n•\t90 Гц\r\nКількість SIM-карток\r\n•\t2\r\nРозміри SIM-картки\r\n•\tNano-SIM\r\nОперативна пам'ять\r\n•\t6 ГБ\r\nВбудована пам'ять\r\n•\t128 ГБ\r\nФормат підтримуваних карт пам'яті\r\n•\tMicroSD\r\nМаксимальний обсяг підтримуваної карти пам'яті\r\n•\t1 ТБ\r\nКомбінований слот\r\n•\tНемає\r\nОпераційна система\r\n•\tAndroid\r\nФронтальна камера\r\n•\t13 Мп\r\nОсобливості фронтальної камери\r\n•\tОдинарна\r\nРозміщення фронтальної камери\r\n•\tКрапелька\r\nЗапис відео фронтальної камери\r\n•\tFull HD/1920х1080/стереозвук\r\nНазва процесора\r\n•\tMediaTek Helio G99\r\nТип ядра\r\n•\tCortex-A76 (64bit) + Cortex-A55 (64bit)\r\nВідеоядро\r\n•\tARM Mali-G57 MC2\r\nКількість ядер\r\n•\t2+6\r\nСерія MediaTek\r\n•\tHelio G Series\r\nЧастота процесора\r\n•\t2.2 ГГц + 2.0 ГГц\r\nОсновна камера\r\n•\t50 Мп + 5 Мп + 2 Мп\r\nОсобливості основної камери\r\n•\tАвтофокус\r\n•\tСпалах\r\n•\tУльтраширококутний об'єктив\r\nКількість основних камер\r\n•\t3\r\nЗапис відео основної камери\r\n•\tFull HD/1920х1080/стереозвук\r\nЄмність акумулятора\r\n•\t5000 мА·год\r\nРоз'єми\r\n•\tUSB Type-C\r\nНавігація\r\n•\tBDS\r\n•\tGPS\r\n•\tГЛОНАСС\r\nВага, г\r\n•\t195\r\nШирина\r\n•\t77.6 мм\r\nВисота\r\n•\t162.1 мм\r\nГлибина\r\n•\t8.3 мм\r\nБезпека\r\n•\tСканер відбитків пальців збоку\r\nДатчики\r\n•\tАкселерометр\r\n•\tГіроскоп\r\n•\tДатчик наближення\r\n•\tДатчик освітлення\r\nКомплект постачання\r\n•\tГарантійний талон\r\n•\tДокументація\r\n•\tКабель для синхронізації\r\n•\tТелефон\r\nБездротові технології\r\n•\tBluetooth 5.3\r\n•\tNFC\r\n•\tWi-Fi\r\nОснащення\r\n•\tСлот для картки пам'яті\r\n•\tШвидке заряджання\r\nФорм-фактор\r\n•\tМоноблок\r\nОсобливості корпусу\r\n•\tБезрамковий дисплей\r\nКолір\r\n•\tDark Red\r\nКраїна реєстрації бренду\r\n•\tРеспубліка Корея (Південна Корея)\r\nГаряча лінія виробника\r\n•\tSamsung 0-800-502-000 Цілодобово 24/7\r\nГарантія\r\n•\t12 місяців\r\nКраїна-виробник товару\r\n•\tІндія",
                ImagePath = "./Assets/телефон2.png",
            };
            var itemForm = new FormItem(itemInfo, new FormMobilephone());
            itemForm.Show();
            this.Close();
        }

        private void ButtonMobilephone3_Click(object sender, EventArgs e)
        {
            var itemInfo = new ItemInfo()
            {
                Name = "Мобільний телефон Infinix Hot 30 Play NFC 8/128 GB Mirage Black",
                Price = "5299",
                Description = "Стандарт зв'язку\r\n•\t2G (GPRS/EDGE)\r\n•\t3G (WCDMA/UMTS/HSPA)\r\n•\t4G (LTE)\r\nДіагональ екрана\r\n•\t6.82\r\nРоздільна здатність дисплея\r\n•\t1640 x 720\r\nТип матриці\r\n•\tIPS\r\nЧастота оновлення екрана\r\n•\t90 Гц\r\nКількість SIM-карток\r\n•\t2\r\nРозміри SIM-картки\r\n•\tNano-SIM\r\nОперативна пам'ять\r\n•\t8 ГБ\r\nВбудована пам'ять\r\n•\t128 ГБ\r\nФормат підтримуваних карт пам'яті\r\n•\tMicroSD\r\nМаксимальний обсяг підтримуваної карти пам'яті\r\n•\t512 ГБ\r\nКомбінований слот\r\n•\tНемає\r\nОпераційна система\r\n•\tAndroid\r\nФронтальна камера\r\n•\t8 Мп\r\nОсобливості фронтальної камери\r\n•\tОдинарна\r\n•\tФронтальний спалах\r\nРозміщення фронтальної камери\r\n•\tКрапелька\r\nВид фронтального спалаху\r\n•\tФізичний\r\nЗапис відео фронтальної камери\r\n•\tFull HD/1920х1080/стереозвук\r\nДодатково\r\n•\tАпертура: f/2.0\r\nНазва процесора\r\n•\tMediaTek Helio G37\r\nТип ядра\r\n•\tCortex-A53 (64bit)\r\nВідеоядро\r\n•\tPowerVR GE8320\r\nКількість ядер\r\n•\t2+6\r\nЧастота процесора\r\n•\t2.3 ГГц + 1.8 ГГц\r\nОсновна камера\r\n•\t16 Мп + 2 Мп\r\nОсобливості основної камери\r\n•\tАвтофокус\r\n•\tСпалах\r\nКількість основних камер\r\n•\t2\r\nЗапис відео основної камери\r\n•\tFull HD/1920х1080/стереозвук\r\nАпертура\r\n•\tf/1.8\r\nРежими зйомки\r\n•\tвідео\r\n•\tAi Cam\r\n•\tпортрет\r\n•\tуповільнена зйомка\r\n•\tтаймлапс\r\n•\tAR Shot\r\n•\tпанорама\r\n•\tдокументи\r\nЄмність акумулятора\r\n•\t6000 мА·год\r\nМатеріал корпуса\r\n•\tПластик\r\nРоз'єми\r\n•\t3.5 mm Mini-Jack\r\n•\tUSB Type-CНавігація\r\n•\tGPS\r\n•\tГЛОНАСС\r\nВага, г\r\n•\t196\r\nШирина\r\n•\t76.6 мм\r\nВисота\r\n•\t168.7 мм\r\nГлибина\r\n•\t8.4 мм\r\nРобота без гарнітури\r\n•\tНемає\r\nБезпека\r\n•\tРозблокування за обличчям\r\n•\tСканер відбитків пальців збоку\r\nДатчики\r\n•\tАкселерометр\r\n•\tГіроскоп\r\n•\tДатчик наближення\r\n•\tДатчик освітлення\r\nКомплект постачання\r\n•\tГарантійний талон\r\n•\tДокументація\r\n•\tЗарядний пристрій\r\n•\tКабель для синхронізації\r\n•\tСкріпка для виймання СІМ-карти\r\n•\tТелефон\r\nБездротові технології\r\n•\tBluetooth 5.0\r\n•\tNFC\r\n•\tWi-Fi\r\nОснащення\r\n•\tFM-радіо\r\n•\tMP3-плеєр\r\n•\tПідтримка OTG\r\n•\tШвидке заряджання\r\nФорм-фактор\r\n•\tМоноблок\r\nОсобливості корпусу\r\n•\tБезрамковий дисплей\r\nКолір\r\n•\tMirage Black\r\nКраїна реєстрації бренду\r\n•\tКитай\r\nГарантія\r\n•\t12 місяців\r\nКраїна-виробник товару\r\n•\tКитай",
                ImagePath = "./Assets/телефон3.png",

            };
            var itemForm = new FormItem(itemInfo, new FormMobilephone());
            itemForm.Show();
            this.Close();
        }

        private void FormMobilephone_Load(object sender, EventArgs e)
        {
            ButtonShopping_Cart1.Enabled = !ClassInformation.Items.Contains("Мобільний телефон Apple iPhone 15 128GB");
            ButtonShopping_Cart2.Enabled = !ClassInformation.Items.Contains("Мобільний телефон Samsung Galaxy A24 128GB Dark Red");
            ButtonShopping_Cart3.Enabled = !ClassInformation.Items.Contains("Мобільний телефон Infinix Hot 30 Play NFC 8/128 GB Mirage Black");
        }

        private void PictureBoxMobilephone1_Click(object sender, EventArgs e)
        {

        }
    }
}