using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class EmployeeProject
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int? ProjectId { get; set; }

    public int? ManagerId { get; set; }

    public string ClientDesignation { get; set; }

    public DateTime? EmpProjectStartDate { get; set; }

    public DateTime? EmpProjectEndDate { get; set; }

    public string ReasonToLeave { get; set; }

    public string Achievements { get; set; }

    public string NewSkillEarned { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
