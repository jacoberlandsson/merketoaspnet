﻿namespace merketoaspnet.Models.Dtos;

public class Product
{
    public string? ArticleNumber { get; set; } = null!;
    public string? ProductName { get; set; }
    public string? Ingress { get; set; }
    public string? Description { get; set; }
    public string? VendorName { get; set; }
    public string? Image { get; set; }
    public string? Price { get; set; }

    public List<string> Tags { get; set; } = new List<string>();
}
