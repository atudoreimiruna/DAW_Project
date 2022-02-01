using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Interfaces
{
    public interface IDesignerRepository
    {
        Task<List<Designer>> GetAll();
        Task<Designer> GetById(int id);
        Task Create(Designer designer);
        Task Update(Designer designer);
        Task Delete(Designer designer);
    }
}
