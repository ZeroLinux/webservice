using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webservice.Models;

namespace webservice.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyContext _context;

        public CompanyRepository(CompanyContext context)
        {
            _context = context;
        }

        public async Task<Company> Create(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();

            return company;
        }

        public async Task<IEnumerable<Company>> Get()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> Get(string id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public async Task Update(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
