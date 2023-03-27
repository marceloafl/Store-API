namespace Store.Domain.Models
{
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientCPF { get; set; }
        public string ClientContry { get; set; }
        public string ClientState { get; set; }
        public string ClientCity { get; set; }
        public string ClientAddress { get; set; }
        public DateTime ClientBirth { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
