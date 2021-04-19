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
        Artem,
        Igor,
        Rafaat,
        Zachary,
        Joshua,
        Andrew,
        Vseleon,
        Fedotov,
        Dashkov,
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
        // Introducing variables.
        public List<FileClass> fileClass { get; set; } = new List<FileClass>();
        private static FileClass fileVariable { get; set; }
        private readonly Random random = new Random();

        public AddFileForm()
        {
            InitializeComponent();
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
        }

        /// <summary>
        /// Exit method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                // ignored.
            }
        }

        /// <summary>
        /// Random UCN token.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomUcnButton_Click(object sender, EventArgs e)
        {
            try
            {
                string rest = $"{(char)random.Next(65, 91)}" +
                              $"{(char)random.Next(97, 123)}" +
                              $"{random.Next(700, 1000)}" +
                              $"{(char)random.Next(97, 123)}" +
                              $"{(char)random.Next(65, 91)}" +
                              $"{random.Next(80, 1000)}" +
                              $"{(char)random.Next(97, 123)}" +
                              $"{random.Next(1, 1000)}" +
                              $"{(char)random.Next(97, 123)}" +
                              $"{(char)random.Next(65, 91)}" +
                              $"{random.Next(465, 987)}" +
                              $"{(char)random.Next(97, 123)}" +
                              $"{(char)random.Next(65, 91)}" +
                              $"{(char)random.Next(65, 91)}" +
                              $"{(char)random.Next(97, 123)}";
                ucnTxtBox.Text = rest;
            }
            catch (Exception)
            {
                ucnTxtBox.Text = "SDjre3245md34fgKUYr324";
            }
        }

        /// <summary>
        /// Validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                // Validation.
                if (nameTxtBox.Text == String.Empty)
                    return;
                if (!Regex.IsMatch(nameTxtBox.Text, @"^[a-zA-Zа-я-А-я ]+$"))
                    nameTxtBox.Text = String.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Code validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void codeTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                // Validation.
                if (!Regex.IsMatch(codeTxtBox.Text, @"^[0-9]+$"))
                    codeTxtBox.Text = String.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// UCN validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucnTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                // Validation.
                if (!Regex.IsMatch(ucnTxtBox.Text, @"^[a-zA-Z0-9]+$"))
                    throw new InvalidOperationException(@"Incorrect UCN. The string must contain only words and digits!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Amount validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amountTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                // Validation.
                firstCostTxtBox.Enabled = false;
                if (!Regex.IsMatch(amountTxtBox.Text, @"^[0-9]+$"))
                    amountTxtBox.Text = String.Empty;
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

        /// <summary>
        /// Edit image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating the File Dialog.
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Filter = "PNG files(*.png)|*.png|JPEG files(*.jpeg)|*.jpeg|JPG files(*.jpg)|*.jpg"
                };
                // Validation.
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // Getting the chosen file.
                string filename = openFileDialog1.FileName;
                imageFileBox.Image = Image.FromFile($@"{filename}");
                imageFileBox.Image.Save(openFileDialog1.SafeFileName ?? string.Empty);
                imageFileBox.AccessibleDescription = openFileDialog1.SafeFileName;
            }
            catch (Exception)
            {
               // ignored.
            }
        }

        /// <summary>
        /// Button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainFuncButton_Click(object sender, EventArgs e) => controlPage.SetPage(mainFunc);
        /// <summary>
        /// Button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extraFuncButton_Click(object sender, EventArgs e) => controlPage.SetPage(extraFunc);

        /// <summary>
        /// Apply button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (discountTxtBox.Text == String.Empty)
                    discountTxtBox.Text = "0";

                // Validation.
                var warranty = warrantyDropdown.Text == @"Available";
                var status = statusDropdown.Text == @"Available";
                if (!double.TryParse(firstCostTxtBox.Text, out var cost) || cost < 0)
                    throw new ArgumentException("Invalid code. The code must be greater than 0 but less than max value");
                if (!int.TryParse(amountTxtBox.Text, out var amount) || amount < 0 || amount >= int.MaxValue)
                    throw new ArgumentException("Invalid amount. The amount must be greater than 0 but less than max value");
                if (!int.TryParse(discountTxtBox.Text, out var discount) || discount < 0 || discount > 100)
                    throw new ArgumentException("Invalid discount. The discount must be greater than 0 but less than 100");

                // Creating file variable.
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
                // Event handler.
                Program.CallBackMy.CallbackEventHandler(file, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Cost validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void costTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                discountTxtBox.Enabled = false;

                // Validation.
                if (!Regex.IsMatch(firstCostTxtBox.Text, @"^[0-9]+$"))
                   firstCostTxtBox.Text = String.Empty;
                if (!double.TryParse(firstCostTxtBox.Text, out double res) || res <= 0)
                    throw new InvalidOperationException(@"Incorrect cost. The cost is less than value!");
                if (!double.TryParse(firstCostTxtBox.Text, out double newRes) || newRes >= Double.MaxValue)
                    throw new InvalidOperationException(@"Incorrect cost. The cost is greater than value!");

                discountTxtBox.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Button OK. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Random name button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomNameButton_Click(object sender, EventArgs e) => nameTxtBox.Text = "" + (Names)random.Next(0, 20);

        /// <summary>
        /// Random digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void digitsRandomButton_Click(object sender, EventArgs e)
        {
            amountTxtBox.Text = $"{random.Next(4, 100)}";
            firstCostTxtBox.Text = $"{random.Next(50, 1000)}";
            currencyDropdown.Text = currencyDropdown.Items[random.Next(1, 30)] + "";
        }
        /// <summary>
        /// Boolean Random.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void booleanRandomButton_Click(object sender, EventArgs e)
        {
            try
            {
                warrantyDropdown.Text = random.Next(0, 2) == 1 ? "Available" : "Unavailable";
                statusDropdown.Text = random.Next(0, 2) == 1 ? "Available" : "Unavailable";
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Discount validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discountTxtBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                // Validation.
                if (!Regex.IsMatch(discountTxtBox.Text, @"^[0-9]+$"))
                    discountTxtBox.Text = String.Empty;
                resultDiscountLabel.Visible = false;
                if (int.TryParse(discountTxtBox.Text, out int discount) && discount >= 0 || discount <= 100)
                {
                    if (discount == 0)
                        return;
                    // Validation.
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

        /// <summary>
        /// Code random.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void codeRandomButton_Click(object sender, EventArgs e)
        {
            try
            {
                codeTxtBox.Text = $"{random.Next(164, 5390) * 352}";
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFileForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (fileClass != null)
                {
                    if (fileClass.Count > 0)
                    {
                        // It requires for editing data.
                        foreach (var data in fileClass)
                        {

                            var warrantyText = data.Warranty ? "Available" : "Unavailable";
                            var statusText = data.Status ? "Available" : "Unavailable";

                            nameTxtBox.Text = data.Name;
                            codeTxtBox.Text = data.Code;
                            ucnTxtBox.Text = data.UCN;

                            companyTxtBox.Text = data.Company;
                            countryDropdown.Text = data.Country;

                            amountTxtBox.Text = data.Amount.ToString();
                            firstCostTxtBox.Text = data.Cost.ToString(CultureInfo.InvariantCulture);
                            currencyDropdown.Text = data.Currency;

                            warrantyDropdown.Text = warrantyText;
                            statusDropdown.Text = statusText;

                            discountTxtBox.Text = data.Discount.ToString();
                            imageFileBox.Image = Image.FromFile(data.PictureBox);
                            descriptionTxtBox.Text = data.Description ?? String.Empty;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Country random.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countryRandomButton_Click(object sender, EventArgs e)
        {
            try
            {
                countryDropdown.Text = countryDropdown.Items[random.Next(1, 196)].ToString();
            }
            catch (Exception)
            {
                countryDropdown.Text = @"Russian Federation";
            }
        }

        /// <summary>
        /// Cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e) => Close();
    }
}
