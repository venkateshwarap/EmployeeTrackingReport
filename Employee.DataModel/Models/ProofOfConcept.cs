using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class ProofOfConcept
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string Pocname { get; set; }

    public int? SkillId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
