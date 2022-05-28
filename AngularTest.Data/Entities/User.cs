﻿using System.ComponentModel.DataAnnotations;

namespace AngularTest.Data.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public IEnumerable<Role> Roles { get; set; }
}
