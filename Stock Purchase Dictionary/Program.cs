using System.Security.Cryptography.X509Certificates;

Dictionary<string, string> stocks = new Dictionary<string, string>();

stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
stocks.Add("TSLA", "Tesla");
stocks.Add("NVDA", "NVIDIA");
stocks.Add("AAPL", "Apple");

List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

purchases.Add((ticker: "GM", shares: 150, price: 23.21));
purchases.Add((ticker: "CAT", shares: 32, price: 17.87));
purchases.Add((ticker: "TSLA", shares: 80, price: 19.02));
purchases.Add((ticker: "NVDA", shares: 102, price: 11.56));
purchases.Add((ticker: "AAPL", shares: 20, price: 30.06));

//Console.WriteLine(stocks["GM"]); //"General Motors"
//Console.WriteLine(purchases[0].shares); //"150"


//Create a total ownership report that computes the total value of each stock that you have purchased.
//This is the basic relational database join algorithm between two tables.
/*
 * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
 * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
*/
// Iterate over the purchases and update the valuation for each stock

// Does the company name key already exist in the report dictionary?
    // If it does, update the total valuation
    // If not, add the new key and set its value

Dictionary<string, double> totalStocks = new Dictionary<string, double>();

foreach ((string ticker, int shares, double price) purchase in purchases)
{
    double total = purchase.shares * purchase.price;
    string stockName = purchase.ticker;

    if (totalStocks.ContainsKey(purchase.ticker))
    {
        totalStocks[stockName] = total;
    }
    else
    {
        totalStocks.Add(stockName, total);
    }
}

Console.WriteLine("Total of each stock purchased:\n");
foreach (var stock in totalStocks)
{
    Console.WriteLine($"{stock.Key}: {stock.Value}");
}