﻿using System;
using System.Collections.Generic;

namespace studies.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
