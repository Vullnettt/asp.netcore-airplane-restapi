using asp.netcore_airplane_restapi.Data;
using asp.netcore_airplane_restapi.Dtos;
using asp.netcore_airplane_restapi.Models;
using asp.netcore_airplane_restapi.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace asp.netcore_airplane_restapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;
        public PersonController(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPerson(int airplaneId)
        {
            return Ok(await personRepository.GetPersonWithAirplaneId(airplaneId));
        }

        [HttpPost]
        public async Task<ActionResult<List<Person>>> AddPerson(PersonCreateDto person)
        {
            if(person.Age < 18)
            {
                return NotFound("You are under 18");
            }
            return Ok(await personRepository.AddPersonWithAirplaneId(mapper.Map<Person>(person)));
        }
      
    }
}
