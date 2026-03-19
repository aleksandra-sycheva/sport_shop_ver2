using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public virtual ICollection<SportingProduct> SportingProducts { get; set; } = new List<SportingProduct>();
}
