using System;
using System.Collections.Generic;

namespace ScheduleAppWepAPI.Model;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? ScheduleId { get; set; }

    public virtual Schedule? Schedule { get; set; }
}
