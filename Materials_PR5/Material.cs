using System;
using System.Collections.Generic;

namespace Materials_PR5;

public partial class Material
{
    public int Id { get; set; }

    public short IdMaterialType { get; set; }

    public string NameMaterial { get; set; } = null!;

    public short CountInPack { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual MaterialType IdMaterialTypeNavigation { get; set; } = null!;

    public virtual ICollection<SuppliersMaterial> SuppliersMaterials { get; set; } = new List<SuppliersMaterial>();
}
