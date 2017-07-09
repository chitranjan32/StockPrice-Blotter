using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockPriceService;
using PagedList;


namespace StockPriceBlotter.Controllers
{
    /// <summary>
    /// Controller class for Stocks 
    /// </summary>
    public class StocksController : Controller
    {
        StockRepository _stockRepository = new StockRepository();

       /// <summary>
       /// Method to return the seach results as per user's search text
       /// </summary>
       /// <param name="searchTerm">Search text entered by user , to filter the result</param>
       /// <param name="page">Page No.</param>
       /// <returns>Search Result as per user's search Text</returns>
        public ActionResult Index(string searchTerm = null, int page = 1)
        {
            var model =
                 _stockRepository.GetStockList()
                   .Where(r => searchTerm == null || r.StockName.Contains(searchTerm))
                  .ToPagedList(page, 13);

            //Render the partial view , in case of Ajax Request.
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Stocks", model);
            }

            return View(model);
        }


        public ActionResult About()
        {
            ViewBag.Message = "This is Stock Trading Platform.";

            return View();
        }      
    }
}