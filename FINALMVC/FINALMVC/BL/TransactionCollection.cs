using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINALMVC.BL
{
    public class TransactionCollection
    {
        private Dictionary<string, Transaction> transCol;

        public TransactionCollection()
        {
            transCol = new Dictionary<string, Transaction>();
        }
        public void AddTransaction(Transaction trans)
        {
            transCol.Add(trans.transactionId, trans);
        }

        public Transaction GetTransaction(string id)
        {
            return transCol[id];
        }

        public List<Transaction> GetTransactions(string id)
        {
            List<Transaction> transList = new List<Transaction>();

            foreach (KeyValuePair<string, Transaction> trans in transCol)
            {
                if (trans.Value.transactionId.ToUpper().Equals(id.ToUpper()))
                {
                    transList.Add(trans.Value);
                }
            }

            return transList;
        }
    }
}
