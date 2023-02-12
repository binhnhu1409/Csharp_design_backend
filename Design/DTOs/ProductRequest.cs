namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class ProductRequest
{
    [Required]
    public string? Title { get; set; }
	public int Price { get; set; }
	public string? Description { get; set; }
	public Category Category { get; set; }
	public string[] Images { get; set; }
}