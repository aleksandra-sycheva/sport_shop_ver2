using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class SportingProductsHistoryOrder
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public virtual HistoryOrder IdOrderNavigation { get; set; } = null!;

    public virtual SportingProduct IdProductNavigation { get; set; } = null!;
}
