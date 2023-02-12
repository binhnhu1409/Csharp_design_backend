namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class CategoryRequest
{
    [Required]
    public string? Name { get; set; }
    public string? Image { get; set; }
}