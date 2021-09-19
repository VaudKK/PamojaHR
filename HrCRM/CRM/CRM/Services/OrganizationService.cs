using CRM.Dto;
using CRM.Models;
using CRM.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CRM.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly OrganizationRepository organziationRepository;

        public OrganizationService(OrganizationRepository organziationRepository)
        {
            this.organziationRepository = organziationRepository;
        }

        public async Task<object> CreateOrganization(OrganizationDto organizationDto)
        {
            var organization = await organziationRepository.FindByEmailOrName(organizationDto.Email,organizationDto.Name);

            if(organization != null)
            {
                return new ErrorDto
                {
                    message = "Organization Exists"
                };

            }

            var newOrganization = new Organization
            {
                OrganizationId = Guid.NewGuid(),
                Name = organizationDto.Name,
                Email = organizationDto.Email,
                Address = organizationDto.Address,
                PrimaryContact = organizationDto.PrimaryContact,
                UserId = Guid.Parse("94f63890-cd51-46e0-979f-0431b120a47f"),
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow
            };

            var saved =  await organziationRepository.SaveAsync(newOrganization);

            if(saved == 1)
            {
                return newOrganization;
            }
            else
            {
                return new ErrorDto
                {
                    message = "Error while creating organization."
                };
            }
        }

        public Task<object> UpdateOrganization(Organization organization)
        {
            throw new System.NotImplementedException();
        }
    }
}