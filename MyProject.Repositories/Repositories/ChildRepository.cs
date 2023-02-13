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
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

       
        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }
        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.FindAsync(id);
       
        }
        public async Task<Child> AddAsync(Child child)
        {
            var c = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return c.Entity;
        }
        public async Task<Child> UpdateAsync(Child child)
        {
            Child c1 = await GetByIdAsync(child.Id);
            c1.Name = child.Name;
            c1.Tz = child.Tz;
            c1.DateOfBirth = child.DateOfBirth;
            c1.ParentId = child.ParentId;
            return c1;
        }
        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }
    }
}
