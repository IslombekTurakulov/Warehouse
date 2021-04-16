using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Warehouse
{
    public enum Names
    {
        Michael,
        James,
        Matthew,
        Nicholas,
        Christopher,
        Joseph,
        Zachary,
        Joshua,
        Andrew,
        William,
        Emily,
        Hannah,
        Kaitlyn,
        Sarah,
        Madison,
        Brianna,
        Kaylee,
        Hailey,
        Alexis
    }

    public partial class AddFileForm : Form
    {
        private static FileClass fileVariable { get; set; }
        private Random rnd = new Random();
        public AddFileForm()
        {
            InitializeComponent();
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure want to exit?",
                "Program exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void randomUcnButton_Click(object sender, EventArgs e)
        {
            string rest = $"{(char)rnd.Next(65, 91)}" +
                          $"{(char)rnd.Next(97, 123)}" +
                          $"{rnd.Next(700, 1000)}" +
                          $"{(char)rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65, 91)}" +
                          $"{rnd.Next(80, 1000)}" +
                          $"{(char)rnd.Next(97, 123)}" +
                          $"{rnd.Next(1, 1000)}" +
                          $"{(char)rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65, 91)}" +
                          $"{rnd.Next(465, 987)}" +
                          $"{(char)rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65, 91)}" +
                          $"{(char)rnd.Next(65, 91)}" +
                          $"{(char)rnd.Next(97, 123)}";
            ucnTxtBox.Text = rest;
        }

        private void nameTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (nameTxtBox.Text == String.Empty)
                    return;
                if (!Regex.IsMatch(nameTxtBox.Text, @"^[a-zA-Zа-я-А-я]+$"))
                    throw new InvalidOperationException(@"Incorrect name. The string must contain only latin letters!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void codeTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (codeTxtBox.Text == String.Empty)
                    return;
                if (!Regex.IsMatch(codeTxtBox.Text, @"^[0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect code. The string must contain only digits!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ucnTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (ucnTxtBox.Text == String.Empty)
                    return;
                if (!Regex.IsMatch(ucnTxtBox.Text, @"^[a-zA-Z0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect UCN. The string must contain only words and digits!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void amountTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                firstCostTxtBox.Enabled = false;
                if (amountTxtBox.Text == String.Empty)
                    return;
                if (!Regex.IsMatch(amountTxtBox.Text, @"^[0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect amount. The string must contain only digits!");
                if (!int.TryParse(amountTxtBox.Text, out int amount) && amount <= 0 || amount >= Int32.MaxValue)
                    throw new InvalidOperationException("Invalid amount. The amount must be greater than 0 but less than max value");
                var temp = int.Parse(amountTxtBox.Text);
                if (temp > 0)
                    firstCostTxtBox.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "PNG files(*.png)|*.png|JPEG files(*.jpeg)|*.jpeg|JPG files(*.jpg)|*.jpg"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            imageFileBox.Image = Image.FromFile($@"{filename}");
            imageFileBox.Image.Save(openFileDialog1.SafeFileName ?? string.Empty);
            imageFileBox.AccessibleDescription = openFileDialog1.SafeFileName;
        }

        private void mainFuncButton_Click(object sender, EventArgs e) => controlPage.SetPage(mainFunc);

        private void extraFuncButton_Click(object sender, EventArgs e)
        {
            controlPage.SetPage(extraFunc);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var warranty = warrantyDropdown.Text == @"Available";
                var status = statusDropdown.Text == @"Available";
                if (!double.TryParse(firstCostTxtBox.Text, out var cost) || cost < 0)
                    throw new ArgumentException("Invalid code. The code must be greater than 0 but less than max value");
                if (!int.TryParse(amountTxtBox.Text, out var amount) || amount < 0 || amount >= int.MaxValue)
                    throw new ArgumentException("Invalid amount. The amount must be greater than 0 but less than max value");
                if (!int.TryParse(discountTxtBox.Text, out var discount) || discount < 0 || discount > 100)
                    throw new ArgumentException("Invalid discount. The discount must be greater than 0 but less than 100");

                var file = new FileClass
                {
                    Name = nameTxtBox.Text,
                    Code = codeTxtBox.Text,
                    UCN = ucnTxtBox.Text,
                    Company = companyTxtBox.Text,
                    Country = countryDropdown.Text,
                    Amount = amount,
                    Cost = cost,
                    Currency = currencyDropdown.Text,
                    Warranty = warranty,
                    Status = status,
                    Discount = discount,
                    PictureBox = imageFileBox.AccessibleDescription,
                    Description = descriptionTxtBox.Text
                };
                Program.CallBackMy.CallbackEventHandler(file, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void firstCostTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {  
                discountTxtBox.Enabled = false;
                if (firstCostTxtBox.Text == String.Empty)
                    return;
                if (!double.TryParse(firstCostTxtBox.Text, out double res) || res <= 0)
                    throw new InvalidOperationException(@"Incorrect cost. The cost is less than value!");
                if (!double.TryParse(firstCostTxtBox.Text, out double newRes) || newRes >= Double.MaxValue)
                    throw new InvalidOperationException(@"Incorrect cost. The cost is greater than value!");
                if (!Regex.IsMatch(firstCostTxtBox.Text, @"^[0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect cost. The cost must contain only digits!");

                discountTxtBox.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void randomNameButton_Click(object sender, EventArgs e)
        {
            nameTxtBox.Text = "" + (Names)rnd.Next(0, 17);
        }

        private void digitsRandomButton_Click(object sender, EventArgs e)
        {
            amountTxtBox.Text = $"{rnd.Next(4, 100)}";
            firstCostTxtBox.Text = $"{rnd.Next(50, 1000)}";
            currencyDropdown.Text = currencyDropdown.Items[rnd.Next(1, 30)] + "";
        }

        private void booleanRandomButton_Click(object sender, EventArgs e)
        {
            warrantyDropdown.Text = rnd.Next(0, 2) == 1 ? "Available" : "Unavailable";
            statusDropdown.Text = rnd.Next(0, 2) == 1 ? "Available" : "Unavailable";
        }

        private void discountTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(discountTxtBox.Text, out var newDiscount) || newDiscount < 0 || newDiscount > 100)
                    MessageBox.Show("Invalid discount. The discount must be greater than 0 but less than 100");
                resultDiscountLabel.Visible = false;
                if (int.TryParse(discountTxtBox.Text, out int discount) && discount > 0 || discount < 100)
                {
                    if (discount == 0)
                        return;
                    resultDiscountLabel.Visible = true;
                    resultDiscountLabel.Text =
                        $@"Cost after discount: {int.Parse(firstCostTxtBox.Text) - (discount * int.Parse(firstCostTxtBox.Text)) / 100}";
                }
            }
            catch (Exception)
            {
              // ignore
            }
        }

        private void codeRandomButton_Click(object sender, EventArgs e)
        {
            codeTxtBox.Text = $"{rnd.Next(164, 5390) * 352}";
        }
    }
}
