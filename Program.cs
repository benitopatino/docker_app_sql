using docker_app_sql;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tRepo = new TransactionRepository();


            var t = new Transaction()
            {
                Merchant = "McDonalds",
                Price = 340.34F
            };

            tRepo.AddTransaction(t);


            var t2 = new Transaction()
            {
                Merchant = "Popeyes",
                Price = 20.23F
            };
            tRepo.AddTransaction(t2);
        }
    }
}