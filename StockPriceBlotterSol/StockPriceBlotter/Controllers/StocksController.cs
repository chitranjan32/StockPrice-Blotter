using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockPriceService;


namespace StockPriceBlotter.Controllers
{
    public class StocksController : Controller
    {
        StockRepository _stockRepository = new StockRepository();
        public ActionResult Index(string searchTerm = null)
        {
            var model = _stockRepository.GetStockList()
                         .Where(r => searchTerm == null || r.StockName.StartsWith(searchTerm))
                         .Take(10);
            
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}