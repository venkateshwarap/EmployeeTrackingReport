using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class Training
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string TrainingGroup { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
