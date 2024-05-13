﻿using System;
using System.Collections.Generic;

namespace RemotelDbTest2.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Neptun { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public decimal? AverageGrade { get; set; }

    public bool IsActive { get; set; }
}
