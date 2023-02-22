using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class Oppurtunity
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string Description { get; set; }

    public int? CompletionStatus { get; set; }

    public int? OpportunityValue { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? HoursSpent { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
