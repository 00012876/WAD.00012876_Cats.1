namespace Cats.Models.Domain
//00012876
{
    public class Cat
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string? Phone { get; set; }
        public bool Favorite { get; set; }
    }
}
