using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Intefaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();

        Task<Person> GetByIdAsync(int id);

        Task<Person> AddAsync(Person person);
        Task<Person> UpdateAsync(Person Person);
        Task DeleteAsync(int id);

    }
}
