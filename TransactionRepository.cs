using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace docker_app_sql
{
    public class TransactionRepository
    {
        public void AddTransaction(Transaction newTransaction)
        {
            if(newTransaction == null)
                throw new ArgumentNullException(nameof(newTransaction));

            string queryString = @"INSERT INTO [TRANSACTION] (Merchant, Price, TransactionDate) VALUES (@pMerchant, @pPrice, @pTransactionDate)";

            SqlConnection con = new SqlConnection(Config.ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(queryString, con);

            var transaction = new Transaction()
            {
                Merchant = newTransaction.Merchant,
                Price = newTransaction.Price,
                TransactionDate = DateTime.Now
            };

            cmd.Parameters.Add("@pMerchant", SqlDbType.VarChar).Value = transaction.Merchant;
            cmd.Parameters.Add("@pPrice", SqlDbType.Float).Value = transaction.Price;
            cmd.Parameters.Add("@pTransactionDate", SqlDbType.DateTime).Value = transaction.TransactionDate;

            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
