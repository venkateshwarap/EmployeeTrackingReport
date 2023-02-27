using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class Interviews
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int? ProjectId { get; set; }

    public int? SkillId { get; set; }

    public string IsSelected { get; set; }

    public string Comments { get; set; }
}
