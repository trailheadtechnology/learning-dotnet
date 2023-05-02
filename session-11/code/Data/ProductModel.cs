using System;
using System.Collections.Generic;

namespace session_11.Data;

public partial class ProductModel
{
    public int ProductModelId { get; set; }

    public string Name { get; set; }

    public string CatalogDescription { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<ProductModelProductDescription> ProductModelProductDescriptions { get; set; } = new List<ProductModelProductDescription>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
