using System;
using System.Collections.Generic;

namespace Store.Domain.Models;

public partial class Purchase
{
    public int PurchaseId { get; set; }

    public int ClientId { get; set; }

    public string? Item { get; set; }

    public int? Number { get; set; }

    public bool? PaymentConfirmed { get; set; }

    public bool? Delivered { get; set; }

    public virtual Client Client { get; set; } = null!;
}
