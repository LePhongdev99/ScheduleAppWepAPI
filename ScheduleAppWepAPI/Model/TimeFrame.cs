using System;
using System.Collections.Generic;

namespace ScheduleAppWepAPI.Model;

public partial class TimeFrame
{
    public int Id { get; set; }

    public TimeSpan? Time { get; set; }

    public virtual ICollection<Subject> SubjectTimeBegins { get; } = new List<Subject>();

    public virtual ICollection<Subject> SubjectTimeEnds { get; } = new List<Subject>();
}
