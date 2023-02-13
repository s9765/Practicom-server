using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Models;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Services.Interfaces;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ChildController : Controller
    {
        //public string MyAllowSpecificOrigins { get; set; } = "_myAllowSpecificOrigins";

        private readonly IChildService _childServise;

        public ChildController(IChildService childServise)
        {
            _childServise = childServise;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childServise.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> GetByid(int id)
        {
            return await _childServise.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ChildDTO> Add([FromBody] ChildModel child)
        {
            ChildDTO childDTO = new ChildDTO() { Id = 0, Name = child.Name, Tz = child.Tz, DateOfBirth = child.DateOfBirth, ParentId = child.ParentId };
            return await _childServise.AddAsync(childDTO);
        }
 
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childServise.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildDTO child)
        {
            return await _childServise.UpdateAsync(child);
        }
    }
}
//////////////////////////////
