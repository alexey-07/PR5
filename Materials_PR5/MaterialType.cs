using System;
using System.Collections.Generic;

namespace Materials_PR5;

public partial class MaterialType
{
    public short Id { get; set; }

    public string TypeMaterial { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
