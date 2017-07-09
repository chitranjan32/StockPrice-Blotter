using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


using StockPriceService;

namespace StockPriceBlotter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        System.Timers.Timer timer;
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Simulate the stock Price movements
            SimulateStocksPriceMovement();
        }

        /// <summary>
        /// Method to update the stock prices after each 5 seconds.
        /// </summary>
        private void SimulateStocksPriceMovement()
        {
            StockRepository stockPriceService = new StockRepository();

            stockPriceService.InitializeStockList();
            timer = new System.Timers.Timer(5000);
            timer.Elapsed += (o, e) => { stockPriceService.UpdateStockPrices(); };
            
            //Calling the timer on a Background thread.
            timer.Start();
        }

        protected void Application_End()
        {
            //Stop timer while application ends
            timer.Stop();
        }

    }
}
