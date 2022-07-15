namespace Projux.Backend.Database.Entities;

using LiteDB;

public class CustomerContactEntity
{
    public ObjectId Id { get; set; } = ObjectId.Empty;
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string EmailAddress { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
}