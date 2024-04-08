namespace CarAPI.Models
{
    public class Style
    {
        public int StyleId { get; set; }
        public string StyleName { get; set; } = null!;
        public string? Description { get; set; }
        public int ModelId { get; set; }
        public ICollection<Car> Cars { get; set; } = null!;
    }
}