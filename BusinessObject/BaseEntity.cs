﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject;
public class BaseEntity
{
    [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
}
