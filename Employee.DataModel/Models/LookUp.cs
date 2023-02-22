using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class LookUp
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public string Value { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
