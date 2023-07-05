using System;
using System.Collections.Generic;

namespace ScheduleAppWepAPI.Model;

public partial class Scheduling
{
    public int SubjectId { get; set; }

    public int ScheduleId { get; set; }

    public int Id { get; set; }

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
