using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webservice.Models;

namespace webservice.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> Get();

        Task<Company> Get(string id);

        Task<Company> Create(Company company);

        Task Update(Company company);
    }
}
