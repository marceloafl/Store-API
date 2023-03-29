using System;
using System.Collections.Generic;

namespace Store.Domain.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientCpf { get; set; }

    public string? ClientCountry { get; set; }

    public string? ClientState { get; set; }

    public string? ClientCity { get; set; }

    public string? ClienteAddress { get; set; }

    public DateTime? ClientBirth { get; set; }

    public virtual ICollection<Purchase> Purchases { get; } = new List<Purchase>();
}
