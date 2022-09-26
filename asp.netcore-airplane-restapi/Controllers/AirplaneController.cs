using asp.netcore_airplane_restapi.Data;
using asp.netcore_airplane_restapi.Dtos;
using asp.netcore_airplane_restapi.Models;
using asp.netcore_airplane_restapi.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.netcore_airplane_restapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;

        public AirplaneController(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<List<Airplane>>> Add(AirplaneCreateDto airplane)
        {
            if (airplane.SeatPosition != "Front" && airplane.SeatPosition != "Back" && airplane.SeatPosition != "Middle")
            {
                return NotFound("You can write just 'Front', 'Back', 'Middle'.");
            }
            return Ok(await personRepository.AddAirplane(mapper.Map<Airplane>(airplane)));
        }

        [HttpGet]
        public async Task<ActionResult<List<Airplane>>> Get()
        {
            return Ok(await personRepository.GetAirplaneWithPerson());
        }
    }
}
