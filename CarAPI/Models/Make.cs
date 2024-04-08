namespace CarAPI.Models
{
    public class Make
    {
        public int MakeIdId { get; set; }
        public string MakeName { get; set; } = null!;

        public ICollection<Model> Models { get; set; } = null!;
        public ICollection<Car> Cars { get; set; } = null!;
    }
}