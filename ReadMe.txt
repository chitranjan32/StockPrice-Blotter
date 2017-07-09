#### Stock Price Blotter - Help #####

1. There are two projects  in this solution : "StockPriceService" and "StockPriceBlotter". 
2. "StockPriceService" is a class library which offers functionalities to fetch ,query and update stock details( To simulate a stock price changes).
3.  "StockPriceBlotter" is a ASP.NET MVC application which allows user to View stock details , filter result sets and fetch updated prices.
	3.1 To support AJAX calls , various Nuget packages have been used like : Jquery , JQuery UI , Paged List , Jquery Unobtrusive and Jquery Validation etc  
                     3.2 All the user defined Javascript functions(which are invoked from Razor Views) are present in file "OTF.JS" under "~\StockPriceBlotter\Scripts" folder .
                     3.3 File "OTF.JS" has been bundled along with Minified version of  other Javascript files for faster Rendering on client browser

Please USE CHROME BROWSER for better results . 