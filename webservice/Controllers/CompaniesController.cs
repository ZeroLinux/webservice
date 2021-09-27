using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webservice.Models;
using webservice.Repositories;

namespace webservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        public readonly ICompanyRepository _companyRepository;

        public CompaniesController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Company>> GetCompanies()
        {
            return await _companyRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompanies(string id)
        {
            return await _companyRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Company>>PostCompanies([FromBody] Company company)
        {
            var newCompany = await _companyRepository.Create(company);
            return CreatedAtAction(nameof(GetCompanies), new { id = newCompany.Id }, newCompany);
        }

        [HttpPut]
        public async Task<ActionResult<Company>>PutCompanies(int id, [FromBody] Company company)
        {
            await _companyRepository.Update(company);
            return NoContent();
        }

    }
}