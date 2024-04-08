namespace CarAPI.Models
{
    public class Make
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; } = null!;

        public ICollection<Model>? Models { get; set; }
        public ICollection<Car>? Cars { get; set; }
    }
}