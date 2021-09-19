using CRM.Dto;
using CRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRM.Services
{
    public interface IOrganizationService
    {
        Task<object> CreateOrganization(OrganizationDto organizationDto);

        Task<object>  UpdateOrganization(Organization organization);
    }
}