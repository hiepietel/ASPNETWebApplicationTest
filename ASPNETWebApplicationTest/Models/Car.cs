using System.ComponentModel.DataAnnotations;
using ASPNETWebApplicationTest.Resources;
using ServiceStack.DataAnnotations;

namespace ASPNETWebApplicationTest.Models
{
    public class Car
    {
        [PrimaryKey]
        [AutoIncrement]
        [Alias("Id")]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(30)]
        public string Producer { get; set; }

        public string Model { get; set; }
        
        public CarSegment Segment { get; set; }
        
        [System.ComponentModel.DataAnnotations.Range(0, 10)]
        public double EngineCapacity { get; set; }
        [System.ComponentModel.DataAnnotations.Range(0, 1000)]
        public double VMax { get; set; } 
        public double Acceleration { get; set; }
        
    }
}