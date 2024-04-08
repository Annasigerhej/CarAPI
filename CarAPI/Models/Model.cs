namespace CarAPI.Models
{
    public class Model
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; } = null!;
        public int MakeId { get; set; }
        public ICollection<Car> Cars { get; set; } = null!;
        public ICollection<Style> Styles { get; set; } = null!;
    }
}