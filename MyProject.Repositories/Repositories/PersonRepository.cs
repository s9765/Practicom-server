using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IContext _context;

        public PersonRepository(IContext context)
        {
            _context = context;
        }
       
        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.Persons.FindAsync(id);
        }
        public async Task<Person> AddAsync(Person person)
        {
            var p = _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return p.Entity;
        }
        public async Task<Person> UpdateAsync(Person person)
        {
            Person p1 = await GetByIdAsync(person.Id);
            p1.FirstName = person.FirstName;
            p1.LastName= person.LastName;
            p1.Tz= person.Tz;
            p1.DateOfBirth= person.DateOfBirth;
            p1.Gender= person.Gender;
            p1.HMO = person.HMO;
            return p1;
        }
        public async Task DeleteAsync(int id)
        {
            _context.Persons.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }
    }
}
