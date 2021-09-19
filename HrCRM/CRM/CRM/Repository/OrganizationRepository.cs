using CRM.Context;
using CRM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class OrganizationRepository : IBaseRepository<Guid, Organization>
    {

        private readonly PostgreContext PostgreContext;

        public OrganizationRepository(PostgreContext postgreContext)
        {
            this.PostgreContext = postgreContext;
        }

        public async Task DeleteAsync(Guid Id)
        {
            var organziation = await PostgreContext.Organizations.FindAsync(Id);
            PostgreContext.Remove(organziation);
            await PostgreContext.SaveChangesAsync();
        }

        public async Task<Organization> FindByEmailOrName(string email,string organizationName)
        {
            return await PostgreContext.Organizations.
                Where(org =>org.Name == organizationName || org.Email == email)
                .FirstOrDefaultAsync<Organization>();
        }

        public async Task<Organization> FindByIdAsync(Guid Id)
        {
            var user = await PostgreContext.Organizations.FindAsync(Id);
            return user;
        }

        public async Task SaveAllAsync(IEnumerable<Organization> Values)
        {
            await PostgreContext.Organizations.AddRangeAsync(Values);
            await PostgreContext.SaveChangesAsync();
        }

        public async Task<int> SaveAsync(Organization Value)
        {
            await PostgreContext.Organizations.AddAsync(Value);
            return await PostgreContext.SaveChangesAsync();
        }
    }
}