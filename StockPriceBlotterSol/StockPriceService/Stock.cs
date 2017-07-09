using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPriceService
{
    /// <summary>
    /// Model class to represent a Stock
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Stock Name
        /// </summary>
        public string StockName { get; set; }
        
        /// <summary>
        /// StockPrice
        /// </summary>
        public int StockPrice { get; set; }
        
        /// <summary>
        /// This property is utilized in web application to highlight the price movement. 
        /// </summary>
        public int PriceMovement { get; set; }
    }
}
