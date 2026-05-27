namespace VEGG.TABLE.Core.Entities;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public List<Produce> ListOfProduce { get; set; } = new List<Produce>();
    public UserType UserType { get; set; } = UserType.Buyer;
}
public enum UserType
{
    Seller,
    Buyer,
    Admin
}