using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockPriceService;
using PagedList;


namespace StockPriceBlotter.Controllers
{
    public class StocksController : Controller
    {
        StockRepository _stockRepository = new StockRepository();

       public ActionResult Index(string searchTerm = null, int page = 1)
        {
            var model =
                 _stockRepository.GetStockList()
                   .Where(r => searchTerm == null || r.StockName.Contains(searchTerm))
                  .ToPagedList(page, 13);

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