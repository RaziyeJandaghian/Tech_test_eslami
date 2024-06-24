namespace Domain.Entities
{
    public class Wallet
    {
        public Guid WalletId { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }

    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
