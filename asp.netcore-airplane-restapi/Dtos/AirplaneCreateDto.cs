using System.ComponentModel.DataAnnotations;

namespace asp.netcore_airplane_restapi.Dtos
{
    public class AirplaneCreateDto
    {
        [Required]
        public string NameStart { get; set; }
        
        [Required]
        public string NameLand { get; set; }
        
        [Required]
        public string SeatPosition { get; set; }
        
        [Required]
        public int NumberOfSeats { get; set; }
    }
}
