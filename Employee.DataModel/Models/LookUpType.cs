using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class LookUpType
{
    public int Id { get; set; }

    public string Lookup { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
