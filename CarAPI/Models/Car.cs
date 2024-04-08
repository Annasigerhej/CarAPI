using System.ComponentModel.DataAnnotations;
namespace CarAPI.Models
{
    public class Car
    {
        //set PlateNumber as primary key
        

        [Key]
        public int LicensePlate  { get; set; }
        public int MakeId { get; set; } 
        public int ModelId { get; set; }
        public int StyleId { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

    }
}