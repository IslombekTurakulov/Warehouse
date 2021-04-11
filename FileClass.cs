using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Warehouse
{
    public class FileClass
    {
        private string _name;
        private string _code;
        private string _url;
        private string _ucn;
        private bool _warranty;
        private bool _status;
        private string _country;
        private BunifuPictureBox _pictureBox;

        public string Name
        {
            get => _name;
            set
            {
                if (value == string.Empty) 
                    throw new ArgumentException(@"Incorrect Name. The name is empty!");
                if (!Regex.IsMatch(value, @"^[a-zA-Zа-я-А-я]+$"))
                    throw new ArgumentException(@"Incorrect Name. The string must contain only words!");
                _name = value.Trim().Replace(" ", "");
            }
        }

        public string Company { get; set; }

        public string Code
        {
            get => _code;
            set
            {
                if (value == string.Empty) 
                    throw new ArgumentException(@"Incorrect Name. The code is empty!");
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

        public string URL
        {
            get => _url;
            set
            {
                if (value == string.Empty) 
                    throw new ArgumentException(@"Incorrect URL. The url is empty!");
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                    throw new ArgumentException(@"Incorrect URL. The string must contain only words and digits!");
                _url = value.Trim().Replace(" ", "");
            }
        }

        public string UCN
        {
            get => _ucn;
            set
            {
                if (value == string.Empty) 
                    throw new ArgumentException(@"Incorrect URL. The url is empty!");
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

        public BunifuPictureBox PictureBox
        {
            get => _pictureBox;
            set
            {
                value.Image.SaveAdd(new EncoderParameters(1));
                _pictureBox = value;
            }
        }

        public string Description { get; set; }
    }

}
