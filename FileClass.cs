using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    class FileClass
    {
        private static string _name;
        private static string _code;
        private static string _url;
        private static string _ucn;
        private static bool _warranty;
        private static bool _status;
        private static int _amount;
        private static double _cost;
        private static int _discount;

        public FileClass(string name, string company, string country, 
            string code, string ucn, string url, int amount, double cost, int discount,
            bool warranty, bool status, string currency)
        {
            Name = name;
            Company = company;
            Country = country;
            Code = code;
            UCN = ucn;
            Amount = amount;
            URL = url;
            Cost = cost;
            Discount = discount;
            Warranty = warranty;
            Status = status;
            Currency = currency;
        }

        public static string Name
        {
            get => _name;
            set
            {
                if (value == String.Empty) 
                    MessageBox.Show(@"Incorrect Name. The string mustn't be empty!");
                else
                {

                    if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                        MessageBox.Show(@"Incorrect Name. The string must contain only words!");
                    else
                        _name = value.Trim().Replace(" ", "");
                }
            }
        }

        public static string Company { get; set; }

        public static string Code
        {
            get => _code;
            set
            {
                if (value == String.Empty) 
                    MessageBox.Show(@"Incorrect Name. The string mustn't be empty!");
                else
                {
                    if (!Regex.IsMatch(value, @"^[0-9]+$"))
                        MessageBox.Show(@"Incorrect code. The string must contain only digits!");
                    else
                        _code = value.Trim().Replace(" ", "");
                }
            }
        }

        public static string Country { get; set; }
        public static string Currency { get; set; }

        public static string URL
        {
            get => _url;
            set
            {
                if (value == String.Empty) 
                    MessageBox.Show(@"Incorrect URL. The string mustn't be empty!");
                else
                {

                    if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                        MessageBox.Show(@"Incorrect URL. The string must contain only words and digits!");
                    else
                        _url = value.Trim().Replace(" ", "");
                }
            }
        }

        public static string UCN
        {
            get => _ucn;
            set => _ucn = value.Trim().Replace(" ", "");
        }

        public static bool Warranty
        {
            get => _warranty;
            set => _warranty = value;
        }
        public static bool Status
        {
            get => _status;
            set => _status = value;
        }

        public static int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }

        public static double Cost
        {
            get => _cost;
            set => _cost = value;
        }

        public static int Discount
        {
            get => _discount;
            set => _discount = value;
        }
    }

}
