namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class UserRequest
{
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserRole Role { get; set; } = UserRole.Customer;
    public string Email { get; set; }
    
    public string Avatar { get; set; }
}