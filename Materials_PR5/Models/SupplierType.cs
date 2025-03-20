using System;
using System.Collections.Generic;

namespace Materials_PR5.Models;

public partial class SupplierType
{
    public short Id { get; set; }

    public string TypeSupplier { get; set; } = null!;


    // навигационные свойства
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
