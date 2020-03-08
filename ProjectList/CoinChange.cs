using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectList
{
    public class CoinChange
    {
        int[] memo;
        public int CoinChangeM(int[] coins, int amount)
        {
            if (coins.Length == 0)
                return -1;
            memo = new int[amount];
            return Find(coins, amount);
        }
        public int CoinChangeM2(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            dp[0] = 0;
            for (int i = 1; i <=amount; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    if(i>=coins[j]&&dp[i-coins[j]]<min)
                    {
                        min = dp[i - coins[j]] + 1;
                    }
                }
                dp[i] = min;
            }
            return dp[amount]>amount?-1:dp[amount];
        }
        public int Find(int[] coins,int amount)
        {
            if (amount < 0) return -1;
            if (amount == 0) return 0;
            if (memo[amount - 1] != 0) return memo[amount - 1];
            int min = int.MaxValue;
            for (int i = 0; i < coins.Length; i++)
            {
                int res = Find(coins, amount - coins[i]);
                if(res>=0&&res<min)
                {
                    min = res + 1;
                }
            }
            memo[amount - 1] = (min == int.MaxValue) ? -1 : min;
            return memo[amount - 1];
        }
    }
}
