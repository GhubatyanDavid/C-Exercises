using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollectionMonths
{
    internal class Elements
    {
        public string MonthWithNumber { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public Elements(string monthWithNumber,string month,string day)
        {
            MonthWithNumber = monthWithNumber;
            Month = month;
            Day = day;
        }
    }
}
