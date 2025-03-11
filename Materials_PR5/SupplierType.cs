using System;
using System.Collections.Generic;

namespace Materials_PR5;

public partial class SupplierType
{
    public short Id { get; set; }

    public string TypeSupplier { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
