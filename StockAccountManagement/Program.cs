using StockAccountManagement.StockManagement;
using System;

namespace StockAccountManagement
{
    class Program
    {
        const string STOCK_JSON = @"V:\BridgeLabz\StockAccountManagement\StockAccountManagement\StockManagement\Stock.json";
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            stockManager.StockReport(STOCK_JSON);
        }
    }
}
