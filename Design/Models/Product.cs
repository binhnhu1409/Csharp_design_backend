namespace Models;

public class Product 
{
	//properties
	public int ID { get; init; }
	public string? Title { get; set; }
	public int Price { get; set; }
	public string? Description { get; set; }
	public Category Category { get; set; }
	public string[] Images { get; set; }
}