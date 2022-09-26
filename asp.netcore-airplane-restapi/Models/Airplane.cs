using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace asp.netcore_airplane_restapi.Models
{
    public class Airplane
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string NameStart { get; set; }

        [Required]
        public string NameLand { get; set; }

        [Required]
        public string SeatPosition { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public int ToNumOfSeat { get; set; }

        [Required]
        public int SeatNumb { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        public List<Person> People { get; set; }
    }
}
