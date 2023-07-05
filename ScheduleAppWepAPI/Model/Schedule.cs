using System;
using System.Collections.Generic;

namespace ScheduleAppWepAPI.Model;

public partial class Schedule
{
    public int Id { get; set; }

    public virtual ICollection<Scheduling> Schedulings { get; } = new List<Scheduling>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
