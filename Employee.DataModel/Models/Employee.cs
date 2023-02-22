using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class Employees
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public int? IsInProject { get; set; }

    public int? Status { get; set; }

    public int? ManagerId { get; set; }

    public int? Skill { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
