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
    partial class FormItem : Form
    {
        private readonly ItemInfo _itemInfo;
        private readonly Form _previous;

        public FormItem(ItemInfo itemInfo, Form previous)
        {
            InitializeComponent();

            RichTextBoxName.Text = itemInfo.Name;
            LabelItem.Text = itemInfo.Price;
            RichTextBoxItem.Text = itemInfo.Description;
            Labeldiscount.Text = itemInfo.Discount;
            PictureBoxItem.ImageLocation = itemInfo.ImagePath;
            PictureBoxdiscount.ImageLocation = itemInfo.Discountpng;
            if (ClassInformation.Items.Contains(itemInfo.Name)) ButtonShopping_Cart.Enabled = false;
            _itemInfo = itemInfo;
            _previous = previous;
        }

        private void ButtonShopping_Cart_Click(object sender, EventArgs e)
        {
            ClassInformation.Items.Add(_itemInfo.Name);
            ButtonShopping_Cart.Enabled = false;
            ClassInformation.Process = false;
        }

        private void ItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _previous.Show();
        }

        private void PictureBoxItem_Click(object sender, EventArgs e)
        {

        }
    }
}