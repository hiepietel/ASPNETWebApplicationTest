using System.ComponentModel.DataAnnotations;
using ASPNETWebApplicationTest.Resources;
using ServiceStack.DataAnnotations;

namespace ASPNETWebApplicationTest.Models
{
    public class CarModel
    {
        [PrimaryKey]
        [AutoIncrement]
        [Alias("Id")]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(30)]
        public string Producer { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(30)]
        public string Model { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public CarSegment Segment { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public CarFuel Fuel { get; set; }
        [System.ComponentModel.DataAnnotations.Range(0, 10)]
        public double EngineCapacity { get; set; }
        [System.ComponentModel.DataAnnotations.Range(0, 1000)]
        public double VMax { get; set; } 
        public double Acceleration { get; set; }
        
        public bool FirstOwner { get; set; }
        
    }
}