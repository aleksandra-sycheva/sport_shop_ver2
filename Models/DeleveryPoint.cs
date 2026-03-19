using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class DeleveryPoint
{
    public int Id { get; set; }

    public string DeliveryAdress { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<HistoryOrder> HistoryOrders { get; set; } = new List<HistoryOrder>();
}
