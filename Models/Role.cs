using System;
using System.Collections.Generic;

namespace sport_shop_ver2.Models;

public partial class Role
{
    public short Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
