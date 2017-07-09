using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockPriceService
{
    /// <summary>
    /// Stock Repository class to Fetch , Update Stock details
    /// </summary>
    public class StockRepository
    {
        private static List<Stock> _stockList;
        
        /// <summary>
        /// Function to Initialize the stock price list
        /// </summary>
        public void InitializeStockList()
        {
            if (_stockList == null)
            {
                _stockList = new List<Stock>();
                
                _stockList.Add(new Stock{ StockName = "abc1" , StockPrice = 12  });
                _stockList.Add(new Stock { StockName = "abc2", StockPrice = 17 });
                _stockList.Add(new Stock { StockName = "abc3", StockPrice = 22 });
                _stockList.Add(new Stock { StockName = "abc4", StockPrice = 27 });
                _stockList.Add(new Stock { StockName = "abc5", StockPrice = 32 });

                _stockList.Add(new Stock { StockName = "bcd1", StockPrice = 40 });
                _stockList.Add(new Stock { StockName = "bcd2", StockPrice = 33 });
                _stockList.Add(new Stock { StockName = "bcd3", StockPrice = 47 });
                _stockList.Add(new Stock { StockName = "bcd4", StockPrice = 26 });
                _stockList.Add(new Stock { StockName = "bcd5", StockPrice = 54 });


                _stockList.Add(new Stock { StockName = "cde1", StockPrice = 39 });
                _stockList.Add(new Stock { StockName = "cde2", StockPrice = 32 });
                _stockList.Add(new Stock { StockName = "cde3", StockPrice = 46 });
                _stockList.Add(new Stock { StockName = "cde4", StockPrice = 25 });
                _stockList.Add(new Stock { StockName = "cde5", StockPrice = 53 });

                _stockList.Add(new Stock { StockName = "def1", StockPrice = 38 });
                _stockList.Add(new Stock { StockName = "def2", StockPrice = 31 });
                _stockList.Add(new Stock { StockName = "def3", StockPrice = 45 });
                _stockList.Add(new Stock { StockName = "def4", StockPrice = 24 });
                _stockList.Add(new Stock { StockName = "def5", StockPrice = 52 });

                _stockList.Add(new Stock { StockName = "efg1", StockPrice = 41 });
                _stockList.Add(new Stock { StockName = "efg2", StockPrice = 34 });
                _stockList.Add(new Stock { StockName = "efg3", StockPrice = 48 });
                _stockList.Add(new Stock { StockName = "efg4", StockPrice = 37 });
                _stockList.Add(new Stock { StockName = "efg5", StockPrice = 55 });

                _stockList.Add(new Stock { StockName = "fgh1", StockPrice = 42 });
                _stockList.Add(new Stock { StockName = "fgh2", StockPrice = 35 });
                _stockList.Add(new Stock { StockName = "fgh3", StockPrice = 49 });
                _stockList.Add(new Stock { StockName = "fgh4", StockPrice = 28 });
                _stockList.Add(new Stock { StockName = "fgh5", StockPrice = 56 });


                _stockList.Add(new Stock { StockName = "ghi1", StockPrice = 37 });
                _stockList.Add(new Stock { StockName = "ghi2", StockPrice = 30 });
                _stockList.Add(new Stock { StockName = "ghi3", StockPrice = 44 });
                _stockList.Add(new Stock { StockName = "ghi4", StockPrice = 23 });
                _stockList.Add(new Stock { StockName = "ghi5", StockPrice = 51 });

                _stockList.Add(new Stock { StockName = "hij1", StockPrice = 36 });
                _stockList.Add(new Stock { StockName = "hij2", StockPrice = 29 });
                _stockList.Add(new Stock { StockName = "hij3", StockPrice = 43 });
                _stockList.Add(new Stock { StockName = "hij4", StockPrice = 22 });
                _stockList.Add(new Stock { StockName = "hij5", StockPrice = 50 });


                _stockList.Add(new Stock { StockName = "ijk1", StockPrice = 35 });
                _stockList.Add(new Stock { StockName = "ijk2", StockPrice = 28 });
                _stockList.Add(new Stock { StockName = "ijk3", StockPrice = 42 });
                _stockList.Add(new Stock { StockName = "ijk4", StockPrice = 21 });
                _stockList.Add(new Stock { StockName = "ijk5", StockPrice = 49 });

                _stockList.Add(new Stock { StockName = "jkl1", StockPrice = 34 });
                _stockList.Add(new Stock { StockName = "jkl2", StockPrice = 27 });
                _stockList.Add(new Stock { StockName = "jkl3", StockPrice = 41 });
                _stockList.Add(new Stock { StockName = "jkl4", StockPrice = 25 });
                _stockList.Add(new Stock { StockName = "jkl5", StockPrice = 48 });
            }
        }

        /// <summary>
        /// Function to fetch stock list
        /// </summary>
        /// <returns>List of Stock Details</returns>
        public List<Stock> GetStockList()
        {
            return _stockList;
        }

        /// <summary>
        /// Method to simulate Stock Price updations.
        /// This method runs on a background thread and is invoked from Application_Start() event handler of 
        /// Web application.
        /// </summary>
        public void UpdateStockPrices()
        {
            Random stockPriceVariance = new Random();
            foreach (Stock stock in _stockList)
            {
                int priceMov = stockPriceVariance.Next(-5, 5);
                int updatedPrice = stock.StockPrice + priceMov;
                if (updatedPrice > 0)
                {
                    stock.StockPrice = updatedPrice;
                    stock.PriceMovement = priceMov;
                }
                else
                {
                    //Stock Price can't go below 0.
                    stock.StockPrice = 0;
                    stock.PriceMovement = priceMov;
                } 
            }

        }        
    }
}
