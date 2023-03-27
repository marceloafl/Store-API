namespace Store.Domain.Models
{
    public class Purchase
    {
        public string PurchaseId { get; set; }
        public string ClienteId { get; set; }
        public string Item { get; set; }
        public int Number { get; set; }
        public bool PaymentConfirmed { get; set; }
        public bool Delivered { get; set; }
    }
}
