using asp.netcore_airplane_restapi.Data;
using asp.netcore_airplane_restapi.Dtos;
using asp.netcore_airplane_restapi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.netcore_airplane_restapi.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext personDb;
        public PersonRepository(PersonDbContext personDb)
        {
            this.personDb = personDb;
        }

        public async Task<ActionResult<List<Person>>> GetPersonWithAirplaneId(int airplaneId)
        {
            var persons = await personDb.people.Where(c => c.AirplaneId == airplaneId).ToListAsync();
            return persons;
        }

        public async Task<ActionResult<List<Person>>> AddPersonWithAirplaneId(Person person)
        {
            var airplane = await personDb.airplanes.FindAsync(person.AirplaneId);

            personDb.people.Add(person);
            
            await personDb.SaveChangesAsync();
            return await GetPersonWithAirplaneId(person.AirplaneId);
        }

        public async Task<ActionResult<List<Airplane>>> GetAirplaneWithPerson()
        {
            return await personDb.airplanes.Include(c => c.People).ToListAsync();
        }

        public async Task<ActionResult<List<Airplane>>> AddAirplane(Airplane airplane)
        {
            Random random = new Random();
            personDb.airplanes.Add(airplane);
            if (airplane.NumberOfSeats == 1)
            {
                if (airplane.SeatPosition == "Front")
                {
                    airplane.Price = 500;
                    airplane.SeatNumb = random.Next(1, 50);
                    airplane.ToNumOfSeat += airplane.SeatNumb;
                }
                else if (airplane.SeatPosition == "Middle")
                {
                    airplane.Price = 430;
                    airplane.SeatNumb = random.Next(51, 100);
                    airplane.ToNumOfSeat += airplane.SeatNumb;
                }
                else if (airplane.SeatPosition == "Back")
                {
                    airplane.Price = 390;
                    airplane.SeatNumb = random.Next(101, 150);
                    airplane.ToNumOfSeat += airplane.SeatNumb;
                }
            }
            else if (airplane.NumberOfSeats == 2)
            {

                if (airplane.SeatPosition == "Front")
                {
                    airplane.Price = 950;
                    airplane.SeatNumb = random.Next(1, 50);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 1;
                }
                else if (airplane.SeatPosition == "Middle")
                {
                    airplane.Price = 870;
                    airplane.SeatNumb = random.Next(51, 100);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 1;
                }
                else if (airplane.SeatPosition == "Back")
                {
                    airplane.Price = 790;
                    airplane.SeatNumb = random.Next(101, 150);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 1;
                }
            }
            else if (airplane.NumberOfSeats == 3)
            {

                if (airplane.SeatPosition == "Front")
                {
                    airplane.Price = 1400;
                    airplane.SeatNumb = random.Next(1, 50);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 2;
                }
                else if (airplane.SeatPosition == "Middle")
                {
                    airplane.Price = 1360;
                    airplane.SeatNumb = random.Next(51, 100);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 2;
                }
                else if (airplane.SeatPosition == "Back")
                {
                    airplane.Price = 1300;
                    airplane.SeatNumb = random.Next(101, 150);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 2;
                }
            }
            else if (airplane.NumberOfSeats == 4)
            {

                if (airplane.SeatPosition == "Front")
                {
                    airplane.Price = 1800;
                    airplane.SeatNumb = random.Next(1, 50);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 3;
                }
                else if (airplane.SeatPosition == "Middle")
                {
                    airplane.Price = 1710;
                    airplane.SeatNumb = random.Next(51, 100);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 3;
                }
                else if (airplane.SeatPosition == "Back")
                {
                    airplane.Price = 1670;
                    airplane.SeatNumb = random.Next(101, 150);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 3;
                }
            }
            else if (airplane.NumberOfSeats == 5)
            {

                if (airplane.SeatPosition == "Front")
                {
                    airplane.Price = 2100;
                    airplane.SeatNumb = random.Next(1, 50);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 4;
                }
                else if (airplane.SeatPosition == "Middle")
                {
                    airplane.Price = 2010;
                    airplane.SeatNumb = random.Next(51, 100);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 4;
                }
                else if (airplane.SeatPosition == "Back")
                {
                    airplane.Price = 1999;
                    airplane.SeatNumb = random.Next(101, 150);
                    airplane.ToNumOfSeat += airplane.SeatNumb + 5;
                }
            }
            await personDb.SaveChangesAsync();
            return await personDb.airplanes.ToListAsync();
        }
    }
}


