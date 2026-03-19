using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<SportingProduct> SportingProducts { get; set; } = new List<SportingProduct>();
}
