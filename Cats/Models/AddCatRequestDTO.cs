namespace Cats.Models
//00012876
{
    public class AddCatRequestDTO
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string? Phone { get; set; }
        public bool Favorite { get; set; }
    }
}
