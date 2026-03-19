using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class SportingProduct
{
    public int Id { get; set; }

    public string Art { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int IdCategory { get; set; }

    public int IdManufacturer { get; set; }

    public int IdSupplier { get; set; }

    public string Price { get; set; } = null!;

    public int IdMeasure { get; set; }

    public int Discount { get; set; }

    public int CointInStok { get; set; }

    public string Description { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual Measure IdMeasureNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual ICollection<SportingProductsHistoryOrder> SportingProductsHistoryOrders { get; set; } = new List<SportingProductsHistoryOrder>();
}
