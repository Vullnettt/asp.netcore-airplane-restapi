using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace asp.netcore_airplane_restapi.Models
{
    public class Person
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Email { get; set; }

        [JsonIgnore]
        public Airplane Airplane { get; set; }
        public int AirplaneId { get; set; }
    }
}
