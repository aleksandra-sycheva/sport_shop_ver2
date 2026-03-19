using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class User
{
    public int Id { get; set; }

    public short IdRole { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<HistoryOrder> HistoryOrders { get; set; } = new List<HistoryOrder>();

    public virtual Role IdRoleNavigation { get; set; } = null!;
}
