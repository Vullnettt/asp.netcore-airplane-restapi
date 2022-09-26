using asp.netcore_airplane_restapi.Dtos;
using asp.netcore_airplane_restapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;

namespace asp.netcore_airplane_restapi.Repository
{
    public interface IPersonRepository 
    {
        Task<ActionResult<List<Airplane>>> GetAirplaneWithPerson();
        Task<ActionResult<List<Airplane>>> AddAirplane(Airplane airplane);
        Task<ActionResult<List<Person>>> GetPersonWithAirplaneId(int airplaneId);
        Task<ActionResult<List<Person>>> AddPersonWithAirplaneId(Person person);


        //Person
        //bool SaveChanges();

        //void AddPerson(Person person);
        //IEnumerable<Person> GetPerson();
        //Person GetPersonById(int id);


        ////Airplane
        //void AddAiplane(int personId, Airplane airplane);
        //IEnumerable<Airplane> GetAirplanes();
        //Airplane GetAirplaneById(int airplaneId);
    }
}
