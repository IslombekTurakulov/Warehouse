using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Warehouse
{
    class CSVClassAnalyzer
    {
        [Name("NodePath")] public string NodePath { get; set; }
        [Name("Name")] public string Name { get; set; }
        [Name("UCN")] public string UCN { get; set; }
        [Name("Amount")] public int Amount { get; set; }
        [Name("Cost")] public double Cost { get; set; }
    }
}
