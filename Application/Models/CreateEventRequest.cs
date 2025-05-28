﻿namespace Application.Models;
public class CreateEventRequest
{
    public string? Image { get; set; }
    public string? Title { get; set; }
    public DateTime EventDate { get; set; }
    public string? Location { get; set; }
    public string? Description { get; set; }
}
