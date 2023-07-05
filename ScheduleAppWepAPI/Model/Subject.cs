using System;
using System.Collections.Generic;

namespace ScheduleAppWepAPI.Model;

public partial class Subject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? TimeBeginId { get; set; }

    public int? TimeEndId { get; set; }

    public string? DayOfWeek { get; set; }

    public virtual ICollection<Scheduling> Schedulings { get; } = new List<Scheduling>();

    public virtual TimeFrame? TimeBegin { get; set; }

    public virtual TimeFrame? TimeEnd { get; set; }
}
