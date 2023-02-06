namespace Models;

public class Product 
{
    //properties
    public int ProductId {get; init;}
    public string? Title {get; set;}
    public int Price {get; set;}
    public string? Description {get; set;}
    public int CategoryId {get; set;}
    // still need to deal with product images here 
}