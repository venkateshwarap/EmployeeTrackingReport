using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class Learning
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string Skill { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
