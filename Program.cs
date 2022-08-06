using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("What amount of money would you like to convert?");
      string amount = Console.ReadLine();
      double number = Convert.ToDouble(amount);
      Console.WriteLine($"Converting {number} into the least amount of coins...");
      double goldCoin= 0.10;
      double silverCoin = 0.05;
      double bronzeCoin=0.01;
      int goldCoinFit=(int)Math.Floor(number/goldCoin);
      double remaining= number % goldCoin;
      double silverFit= Math.Floor(remaining/silverCoin);
      remaining=remaining%silverCoin;
      int bronzeFit=(int)Math.Ceiling(remaining/bronzeCoin);
      remaining=remaining%bronzeCoin;
      Console.WriteLine($"You will have {goldCoinFit} Gold Coins");
      Console.WriteLine($"You will have {silverFit} Silver Coins");
      Console.WriteLine($"You will have {bronzeFit} Bronze Coins");
    }
  }
}