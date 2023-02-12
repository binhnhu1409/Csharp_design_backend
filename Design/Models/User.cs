namespace Models;

public enum UserRole {
    Customer,
    Admin
}

public class User
{
    //properties
    public int ID { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserRole Role { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public string Avatar { get; set; }

    //constructor
    public User(int id, string email, string firstName, string lastName)
    {
        ID = id;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Role = UserRole.Customer;
    }
}
