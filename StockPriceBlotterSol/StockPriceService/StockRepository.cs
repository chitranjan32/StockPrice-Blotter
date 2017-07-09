using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockPriceService
{
    public class StockRepository
    {
        private List<Stock> _stockList;
        
        public void InitializeStockList()
        {
            if (_stockList == null)
            {
                _stockList = new List<Stock>();
                
                _stockList.Add(new Stock{ StockName = "Aa1" , StockPrice = 12  });
                _stockList.Add(new Stock { StockName = "Aa2", StockPrice = 17 });
                _stockList.Add(new Stock { StockName = "Aa3", StockPrice = 22 });
                _stockList.Add(new Stock { StockName = "Aa4", StockPrice = 27 });
                _stockList.Add(new Stock { StockName = "Aa5", StockPrice = 32 });

                _stockList.Add(new Stock { StockName = "Bb1", StockPrice = 40 });
                _stockList.Add(new Stock { StockName = "Bb2", StockPrice = 33 });
                _stockList.Add(new Stock { StockName = "Bb3", StockPrice = 47 });
                _stockList.Add(new Stock { StockName = "Bb4", StockPrice = 26 });
                _stockList.Add(new Stock { StockName = "Bb5", StockPrice = 54 });


                _stockList.Add(new Stock { StockName = "Cc1", StockPrice = 39 });
                _stockList.Add(new Stock { StockName = "Cc2", StockPrice = 32 });
                _stockList.Add(new Stock { StockName = "Cc3", StockPrice = 46 });
                _stockList.Add(new Stock { StockName = "Cc4", StockPrice = 25 });
                _stockList.Add(new Stock { StockName = "Cc5", StockPrice = 53 });

                _stockList.Add(new Stock { StockName = "Dd1", StockPrice = 38 });
                _stockList.Add(new Stock { StockName = "Dd2", StockPrice = 31 });
                _stockList.Add(new Stock { StockName = "Dd3", StockPrice = 45 });
                _stockList.Add(new Stock { StockName = "Dd4", StockPrice = 24 });
                _stockList.Add(new Stock { StockName = "Dd5", StockPrice = 52 });

                _stockList.Add(new Stock { StockName = "Ee1", StockPrice = 41 });
                _stockList.Add(new Stock { StockName = "Ee2", StockPrice = 34 });
                _stockList.Add(new Stock { StockName = "Ee3", StockPrice = 48 });
                _stockList.Add(new Stock { StockName = "Ee4", StockPrice = 37 });
                _stockList.Add(new Stock { StockName = "Ee5", StockPrice = 55 });

                _stockList.Add(new Stock { StockName = "Ff1", StockPrice = 42 });
                _stockList.Add(new Stock { StockName = "Ff2", StockPrice = 35 });
                _stockList.Add(new Stock { StockName = "Ff3", StockPrice = 49 });
                _stockList.Add(new Stock { StockName = "Ff4", StockPrice = 28 });
                _stockList.Add(new Stock { StockName = "Ff5", StockPrice = 56 });


                _stockList.Add(new Stock { StockName = "Gg1", StockPrice = 37 });
                _stockList.Add(new Stock { StockName = "Gg2", StockPrice = 30 });
                _stockList.Add(new Stock { StockName = "Gg3", StockPrice = 44 });
                _stockList.Add(new Stock { StockName = "Gg4", StockPrice = 23 });
                _stockList.Add(new Stock { StockName = "Gg5", StockPrice = 51 });

                _stockList.Add(new Stock { StockName = "Hh1", StockPrice = 36 });
                _stockList.Add(new Stock { StockName = "Hh2", StockPrice = 29 });
                _stockList.Add(new Stock { StockName = "Hh3", StockPrice = 43 });
                _stockList.Add(new Stock { StockName = "Hh4", StockPrice = 22 });
                _stockList.Add(new Stock { StockName = "Hh5", StockPrice = 50 });


                _stockList.Add(new Stock { StockName = "Ii1", StockPrice = 35 });
                _stockList.Add(new Stock { StockName = "Ii2", StockPrice = 28 });
                _stockList.Add(new Stock { StockName = "Ii3", StockPrice = 42 });
                _stockList.Add(new Stock { StockName = "Ii4", StockPrice = 21 });
                _stockList.Add(new Stock { StockName = "Ii5", StockPrice = 49 });

                _stockList.Add(new Stock { StockName = "Jj1", StockPrice = 34 });
                _stockList.Add(new Stock { StockName = "Jj2", StockPrice = 27 });
                _stockList.Add(new Stock { StockName = "Jj3", StockPrice = 41 });
                _stockList.Add(new Stock { StockName = "Jj4", StockPrice = 25 });
                _stockList.Add(new Stock { StockName = "Jj5", StockPrice = 48 });
            }
        }

        public List<Stock> GetStockList()
        {
            return _stockList;
        }

        public void UpdateStockPrices()
        {
            Random stockPriceVariance = new Random();
            foreach (Stock stock in _stockList)
            {
                int updatedPrice = stock.StockPrice + stockPriceVariance.Next(-5, 5);
                if (updatedPrice > 0)
                {
                   stock.StockPrice = updatedPrice;
                }
                else
                {
                    stock.StockPrice = 0;                     
                }                
            }

        }        
    }
}
