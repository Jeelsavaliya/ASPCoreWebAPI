using System;
using System.Collections.Generic;

namespace ASPCoreWebAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Standard { get; set; }

    public string? School { get; set; }

    public int? Age { get; set; }
}
