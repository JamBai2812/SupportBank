using System;

namespace SupportBank2
{
    public class Transaction
    {
        public string transactionDate { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string narrative { get; set; }
        public float amount { get; set; }

    }
}