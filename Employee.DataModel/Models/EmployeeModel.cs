using System;
using System.Collections.Generic;

namespace Employee.DataModel.Models;

public partial class EmployeeModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Status { get; set; }

    public string Skills { get; set; }

    public string InProject { get; set; }
}
