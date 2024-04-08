namespace CarAPI.Models
{
    public class Owner
    {
        [Key]
        public int CPRNumber { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; } 
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public ICollection<Car> Cars { get; set; } = null!;
    
    }
}