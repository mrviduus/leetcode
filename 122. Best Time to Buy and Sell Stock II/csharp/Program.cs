

int[] prices1 = { 7, 1, 5, 3, 6, 4 };
int[] prices2 = { 1, 2, 3, 4, 5 };
int[] prices3 = { 7, 6, 4, 3, 1 };

Solution profit = new();

Console.WriteLine(profit.MaxProfit(prices1));
Console.WriteLine(profit.MaxProfit(prices2));
Console.WriteLine(profit.MaxProfit(prices3));



public class Solution
{
    public int MaxProfit(int[] prices)
    {

        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
                profit += (prices[i] - (prices[i - 1]));
        }

        return profit;
    }
}