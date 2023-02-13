using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Intefaces
{
    public interface IChildRepository
    {
      
        Task<Child> GetByIdAsync(int id);
        Task<List<Child>> GetAllAsync();
        Task<Child> AddAsync(Child child);
        Task<Child> UpdateAsync(Child child);
        Task DeleteAsync(int id);

    }
}
