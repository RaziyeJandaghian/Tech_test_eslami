namespace Application.DTOs
{
    public class WalletDto
    {
        public Guid WalletId { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
    }
}