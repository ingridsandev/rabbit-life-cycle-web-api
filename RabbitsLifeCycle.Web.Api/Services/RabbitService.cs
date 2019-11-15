using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitsLifeCycle.Web.Api.Models;

namespace RabbitsLifeCycle.Web.Api.Services
{
    public class RabbitService : IRabbitService
    {
        public async Task<ObjectResult> CountAsync(int month)
        {
            try
            {
                return new OkObjectResult(await CalculateRabbitsByMonthAsync(month));
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unexpected error has occurred - Exception: {e}");
                return new ObjectResult("An unexpected error has occurred")
                {
                    StatusCode = (int) HttpStatusCode.InternalServerError
                };
            }
        }

        private async Task<int> CalculateRabbitsByMonthAsync(int month)
        {
            var rabbits = new List<RabbitBirthRegistration>();

            if (month < 0) // •	At any month before 0 there are no Rabbits in existence
                return 0;

            if (month >= 0 || month <= 2) // • At month 0 there magically is 1 pair of Rabbits
                rabbits.Add(new RabbitBirthRegistration(0, 2));

            for (var i = 3; i <= month; i++)
            {
                var matureRabbits = rabbits.Where(w => w.MatureMonth <= i).ToList();

                rabbits.Add(new RabbitBirthRegistration(i, matureRabbits.Sum(s => s.BornRabbits)));
            }

            return rabbits.Sum(s => s.BornRabbits) / 2;
        }
    }

    public interface IRabbitService
    {
        Task<ObjectResult> CountAsync(int month);
    }
}
