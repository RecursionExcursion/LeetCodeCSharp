using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    public class CoinChangeSol
    {
        //public int CoinChange(int[] coins, int amount)
        //{
        //    Array.Sort(coins);
        //    Array.Reverse(coins);

        //    List<int> res = new List<int>();

        //    int val = 0;

        //    int coinsUsed = 0;

        //    for (int i = 0, j = 0; i < coins.Length;)
        //    {

        //        int coin = coins[i];

        //        if (res.Sum() + coin > amount)
        //        {
        //            i++;
        //            continue;
        //        }

        //        res.Add(coin);
        //    }





        //    return -1;
        //}
        public int CoinChange(int[] coins, int amount)
        {
            //Build DP array
            int[] dp = new int[amount + 1];

            //Fill array with Amount + 1
            Array.Fill(dp, amount + 1);

            //Base case
            dp[0] = 0;

            //Outer loop is for coins
            foreach (int coin in coins)
            {
                //Iterate over DP array to find how many coins needed to form that total of amount
                //Start from the denomination of coin as it's not possible to make total less than the denomination with this coin
                for (int i = coin; i <= amount; i++)
                {
                    //Update the DP array with minimum number of coins needed to make the total
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
            //Catch condition where if its not possible to form total with given coins return -1
            return dp[amount] <= amount ? dp[amount] : -1;
        }
        //public int CoinChange(int[] coins, int amount)
        //{
        //    Array.Sort(coins);
        //    Array.Reverse(coins);



        //    int temp = 0;
        //    int numOfCoins = 0;


        //    int x = 0;
        //    int y = 0;


        //    while (true)
        //    {
        //        int coin = coins[x];

        //        while (temp + coin <= amount)
        //        {
        //            AddCoin(coin);
        //        }

        //        if (temp == amount)
        //        {
        //            return numOfCoins;
        //        }

        //        if(++x >= coins.Length)
        //        {
        //            return -1;
        //        }
        //    }

        //    return -1;

        //    bool IsEqualOrOver(int val, int amount)
        //    {
        //        return val >= amount;
        //    }

        //    void AddCoin(int coin)
        //    {
        //        temp += coin;
        //        numOfCoins++;
        //    }

        //    void RemoveCoin(int coin)
        //    {
        //        temp -= coin;
        //        numOfCoins--;
        //    }
        //}



        //public int CoinChange(int[] coins, int amount)
        //{
        //    Array.Sort(coins);
        //    Array.Reverse(coins);


        //    int val = 0;
        //    int numOfCoins = 0;


        //    foreach (int coin in coins)
        //    {
        //        while (amount >= val + coin)
        //        {
        //            numOfCoins++;
        //            val += coin;
        //        }
        //    }


        //    return val == amount ? numOfCoins : -1;
        //}
    }
}
