using System;
using System.Collections.Generic;
using System.Text;

namespace YottaWally
{
    class Transaction
    {
        ///A Class Managing Transactions
        public string from { get; set; }
        public string to { get; set; }
        public decimal value { get; set; }
        public int fee { get; set; }
        public string dateCreated { get; set; }
        public string data { get; set; }
        public string senderPubKey { get; set; }
        public string transactionDataHash { get; set; }
        public List<string> senderSignature { get; set; }
        public decimal minedInBlockIndex { get; set; }
        public bool transferSuccessful { get; set; }
    }
}
