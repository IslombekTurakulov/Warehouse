using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Bunifu.UI.WinForms;

namespace Warehouse
{
    public partial class AddFileForm : Form
    {
        private FileClassManager fileClassManager = new FileClassManager();
        private FileClass fileClass;
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
            if(dialog == DialogResult.Yes) {
                this.Close();
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
                          $"{(char) rnd.Next(97, 123)}";
            ucnTxtBox.Text = rest;
        }

        private void nameTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (nameTxtBox.Text == String.Empty) 
                    return;
                if (!Regex.IsMatch(nameTxtBox.Text, @"^[a-zA-Z]+$"))
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
                if (codeTxtBox.Text == String.Empty) 
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
                if (amountTxtBox.Text == String.Empty) 
                    return;
                if (!int.TryParse(amountTxtBox.Text, out int amount) && amount <= 0 || amount >= Int32.MaxValue  )
                    throw new InvalidOperationException("Invalid amount. The amount must be greater than 0 but less than max value");
                if (!Regex.IsMatch(amountTxtBox.Text, @"^[0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect amount. The string must contain only digits!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void urlTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (codeTxtBox.Text == String.Empty) 
                    return;
                if (!Regex.IsMatch(ucnTxtBox.Text, @"^[a-zA-Z0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect URL. The string must contain only words and digits!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "PNG files(*.png)|*.png|JPEG files(*.jpeg)|*.jpeg|JPG files(*.jpg)|*.jpg"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            imageFileBox.Image = Image.FromFile($@"{openFileDialog1.FileName}");
        }

        private void mainFuncButton_Click(object sender, EventArgs e)
        {
            controlPage.SetPage(mainFunc);
        }

        private void extraFuncButton_Click(object sender, EventArgs e)
        {
            controlPage.SetPage(extraFunc);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            int discount = 0;
            int amount = 0;
            double cost = 0;

            try
            {
                bool warranty = warrantyDropdown.Text == @"Available";
                bool status = statusDropdown.Text == @"Available";
                if (!int.TryParse(amountTxtBox.Text, out amount) && amount <= 0 || amount >= Int32.MaxValue  )
                    throw new ArgumentException("Invalid amount. The amount must be greater than 0 but less than max value");
                if (!double.TryParse(codeTxtBox.Text,NumberStyles.Any,
                    CultureInfo.InvariantCulture, out cost) && cost <= 0 || cost >= Double.MaxValue)
                    throw new ArgumentException("Invalid cost. The cost must be greater than 0 but less than max value");
                if (!int.TryParse(discountTxtBox.Text, out discount) && (discount < 0 || discount > 100))
                    throw new ArgumentException("Invalid discount. The discount must be greater than 0 but less than 100");
                fileClass = new FileClass
                (
                    nameTxtBox.Text.Trim(),
                    companyDropdown.Text,
                    countryDropdown.Text.Trim(),
                    codeTxtBox.Text.Trim(),
                    ucnTxtBox.Text.Trim(),
                    urlTxtBox.Text.Trim(),
                    amount,
                    cost,
                    discount,
                    warranty,
                    status,
                    currencyDropdown.Text
                );
                fileClassManager.Add(fileClass);
                XmlSerializer formatter = new XmlSerializer(typeof(FileClass), new Type[] {typeof(FileClassManager)});
                using (FileStream stream = File.OpenWrite("HSEKontora.xml"))
                    formatter.Serialize(stream, fileClassManager);
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
                   throw new InvalidOperationException(@"Incorrect amount. The amount is less than value!");
                if (!double.TryParse(firstCostTxtBox.Text, out double newRes) || newRes >= Double.MaxValue)
                    throw new InvalidOperationException(@"Incorrect amount. The amount is greater than value!");
                if (!Regex.IsMatch(firstCostTxtBox.Text, @"^[0-9-]+$"))
                    throw new InvalidOperationException(@"Incorrect amount. The string must contain only digits!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
