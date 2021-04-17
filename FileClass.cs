using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using CsvHelper.Configuration.Attributes;

namespace Warehouse
{
    public class FileClass
    {
        [Name("Name")] private string _name;
        [Name("Code")] private string _code;
        [Name("UCN")] private string _ucn;
        [Name("Warranty")] private bool _warranty;
        [Name("Status")] private bool _status;
        [Name("Country")] private string _country;
        [Name("Company")] private string _company;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Trim(' ') == string.Empty) 
                    throw new ArgumentException(@"Incorrect Name. The name is empty!");
                /*if (!Regex.IsMatch(value, @"^[a-zA-Zа-я-А-я]+$"))
                    throw new ArgumentException(@"Incorrect Name. The string must contain only words!");*/
                _name = value.Trim();
            }
        }

        public string Company
        {
            get => _company;
            set
            {
                if (value.Length <= 2)
                    throw new ArgumentException("Incorrect company. The company name is empty!");
                _company = value;
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                if (value == string.Empty) 
                    throw new ArgumentException(@"Incorrect code. The code is empty!");
                if (!Regex.IsMatch(value, @"^[0-9]+$"))
                    throw new ArgumentException(@"Incorrect code. The string must contain only digits!");
                _code = value.Trim().Replace(" ", "");
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException(@"Incorrect Country. The country mustn't be empty!");
                _country = value;
            }
        }

        public string Currency { get; set; }


        public string UCN
        {
            get => _ucn;
            set
            {
                if (value == string.Empty) 
                    throw new ArgumentException(@"Incorrect UCN. The ucn is empty!");
                _ucn = value.Trim().Replace(" ", "");
            }
        }

        public bool Warranty
        {
            get => _warranty;
            set => _warranty = value;
        }
        public bool Status
        {
            get => _status;
            set => _status = value;
        }

        public int Amount { get; set; }

        public double Cost { get; set; }

        public int Discount { get; set; }

        public string PictureBox { get; set; }

        public string Description { get; set; }

        public FileClass()
        {
        }
    }

}
