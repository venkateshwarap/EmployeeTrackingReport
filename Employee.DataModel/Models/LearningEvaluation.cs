using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class LearningEvaluation
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int? LearningId { get; set; }

    public int? EvaluatorEmpId { get; set; }
}
