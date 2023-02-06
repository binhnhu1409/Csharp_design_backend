namespace Models;

public enum Role {
    User,
    Admin
}

public class User
{
    //properties
    public int UserId {get; init;}
    public string Email {get; set;}
    public string Password {get; set;}
    public string Name {get; set;}
    public Role Role {get; set;}
    //still need to deal with avatar here

    //constructor
    public User(int id, string email, string password, string name, Role role)
    {
        UserId = id;
        Email = email;
        Password = password;
        Name = name;
        Role = role;
    }
}