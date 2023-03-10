using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Intefaces
{
    public interface IContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<Child> Children { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
