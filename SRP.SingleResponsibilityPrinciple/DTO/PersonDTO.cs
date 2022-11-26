namespace SRP.SingleResponsibilityPrinciple.DTO
{
  public class PersonDTO
  {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string LastName { get; set; } = default!;
    public string Country { get; set; } = null!;
  }
}