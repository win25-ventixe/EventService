﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Persistance.Entities;
public class EventEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Image { get; set; }

    public string? Title { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime EventDate { get; set; }

    public string? Location { get; set; } 

    public string? Description { get; set; }

    public ICollection<EventPackageEntity> Packages { get; set; } = [];


}
