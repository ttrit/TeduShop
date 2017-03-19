using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
  public abstract class Auditable : IAuditable
  {
    public string MetaKeyword { set; get; }
    public string MetaDescription { set; get; }
    public DateTime CreatedDate { set; get; }
    [MaxLength(256)]
    public string CreatedBy { set; get; }
    public DateTime? UpdatedDate { set; get; }
    public string UpdatedBy { set; get; }
    public bool Status { set; get; }
  }
}
