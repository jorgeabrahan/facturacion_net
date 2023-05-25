using System.ComponentModel.DataAnnotations;

namespace facturacion.Models;
/* Articulo */
public class Inventory
{
  [Key]
  public Guid InventoryId { get; set; }

  public virtual ICollection<Article>? Article { get; set; }
}