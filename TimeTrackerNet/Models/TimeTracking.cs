﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TimeTrackerNet.Models;

public partial class TimeTracking
{
    public int Id { get; set; }

    public string Category { get; set; }

    public string Skill { get; set; }

    public int? duration { get; set; }

    public DateTime? Date { get; set; }
}