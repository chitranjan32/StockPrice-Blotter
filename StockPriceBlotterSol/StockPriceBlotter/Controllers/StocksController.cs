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

        //public ActionResult Autocomplete(string term)
        //{
        //    var model =
        //        _stockRepository.GetStockList()
        //           .Where(r => r.StockName.Contains(term))
        //           .Take(10)
        //           .Select(r => new
        //           {
        //               label = r.StockName
        //           });

        //    return Json(model, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Index(string searchTerm = null)
        //{
        //    var model = _stockRepository.GetStockList()
        //                 .Where(r => searchTerm == null || r.StockName.Contains(searchTerm))
        //                 .Take(10);

        //    return View(model);
        //}

        public ActionResult Index(string searchTerm = null, int page = 1)
        {
            var model =
                 _stockRepository.GetStockList()
                   .Where(r => searchTerm == null || r.StockName.Contains(searchTerm))
                  .ToPagedList(page, 10);

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