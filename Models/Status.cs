using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class Status
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<HistoryOrder> HistoryOrders { get; set; } = new List<HistoryOrder>();
}
