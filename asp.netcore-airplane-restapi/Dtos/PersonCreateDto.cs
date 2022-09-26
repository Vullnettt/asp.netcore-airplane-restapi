using asp.netcore_airplane_restapi.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace asp.netcore_airplane_restapi.Dtos
{
    public class PersonCreateDto
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public int AirplaneId { get; set; }
    }
}
