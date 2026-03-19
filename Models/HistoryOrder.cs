using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class HistoryOrder
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public int IdDeliveryPoint { get; set; }

    public int IdUser { get; set; }

    public int Code { get; set; }

    public int IdStatuses { get; set; }

    public virtual DeleveryPoint IdDeliveryPointNavigation { get; set; } = null!;

    public virtual Status IdStatusesNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<SportingProductsHistoryOrder> SportingProductsHistoryOrders { get; set; } = new List<SportingProductsHistoryOrder>();
}
