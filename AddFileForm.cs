﻿using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Warehouse
{
    public partial class AddFileForm : Form
    {
        private static FileClass fileVariable { get; set; }
        private Random rnd = new Random();
        public AddFileForm()
        {
            InitializeComponent();
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
        }

        /*private void GetData(FileClass fileclass, bool getData)
        {
            if (fileclass != null)
            {
                var warrantyText = fileclass.Warranty ? "Available" : "Unavailable";
                var statusText = fileclass.Status ? "Available" : "Unavailable";

                nameTxtBox.Text = fileclass.Name;
                codeTxtBox.Text = fileclass.Code;
                ucnTxtBox.Text = fileclass.UCN;

                companyDropdown.Text = fileclass.Company; 
                countryDropdown.Text = fileclass.Country;

                amountTxtBox.Text = fileclass.Amount.ToString();
                firstCostTxtBox.Text = fileclass.Cost.ToString(CultureInfo.InvariantCulture);
                currencyDropdown.Text = fileclass.Currency;

                warrantyDropdown.Text = warrantyText;
                statusDropdown.Text = statusText;

                discountTxtBox.Text = fileclass.Discount.ToString();

                imageFileBox = fileclass.PictureBox ?? new BunifuPictureBox();
                descriptionTxtBox.Text = fileclass.Description ?? String.Empty;
            }
        }*/


        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure want to exit?",
                "Program exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if(dialog == DialogResult.Yes) {
                Close();
            }
        }

        private void randomUcnButton_Click(object sender, EventArgs e)
        {
            string rest = $"{(char)rnd.Next(65,91)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{rnd.Next(700, 1000)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65,91)}" +
                          $"{rnd.Next(80, 1000)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{rnd.Next(1, 1000)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65,91)}" +
                          $"{rnd.Next(465, 987)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65,91)}" +
                          $"{(char)rnd.Next(65,91)}" +
                          $"{(char) rnd.Next(97, 123)}";
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
                if (!int.TryParse(amountTxtBox.Text, out int amount) && amount <= 0 || amount >= Int32.MaxValue  )
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
            imageFileBox.Image = Image.FromFile($@"{openFileDialog1.FileName}");
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
                if (!int.TryParse(amountTxtBox.Text, out var amount) || amount <= 0 || amount >= 1000)
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
                    PictureBox = imageFileBox,
                    Description = descriptionTxtBox.Text
                };

                fileVariable = file;
                Program.CallBackMy.CallbackEventHandler(fileVariable, true);
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
                if (firstCostTxtBox.Text == String.Empty)
                    return;
                if (!double.TryParse(firstCostTxtBox.Text, out double res) || res <= 0)
                   throw new InvalidOperationException(@"Incorrect cost. The cost is less than value!");
                if (!double.TryParse(firstCostTxtBox.Text, out double newRes) || newRes >= Double.MaxValue)
                    throw new InvalidOperationException(@"Incorrect cost. The cost is greater than value!");
                if (!Regex.IsMatch(firstCostTxtBox.Text, @"^[0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect cost. The cost must contain only digits!");
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

        private void AddFileForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
