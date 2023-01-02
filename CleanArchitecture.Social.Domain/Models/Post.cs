﻿namespace CleanArchitecture.Social.Domain.Models;

public class Post
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Text { get; set; }
}
