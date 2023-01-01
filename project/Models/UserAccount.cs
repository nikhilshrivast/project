using System;
using System.Collections.Generic;

namespace project.Models;

public partial class UserAccount
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Graduction { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Hobbies { get; set; }

    public string? EmailId { get; set; }

    public string? UploadDoc { get; set; }
}
