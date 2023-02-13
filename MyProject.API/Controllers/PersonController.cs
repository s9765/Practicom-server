using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Services;
using MyProject.Services.Interfaces;
using MyProject.API.Models;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personServise;

        public PersonController(IPersonService personServise)
        {
            _personServise = personServise;
        }
        [HttpGet]
        public async Task<List<PersonDTO>> Get()
        {
            return await _personServise.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonDTO> GetByid(int id)
        {
            return await _personServise.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<PersonDTO> Add([FromBody] PersonModel person)
        {
            PersonDTO p = new PersonDTO() { Id = 0, DateOfBirth = person.DateOfBirth, FirstName = person.FirstName, LastName = person.LastName,HMO=person.HMO,Gender=person.Gender,Tz=person.Tz };
            return await _personServise.AddAsync(p);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _personServise.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<PersonDTO> Update([FromBody] PersonDTO person)
        {
            return await _personServise.UpdateAsync(person);
        }
    }
}
