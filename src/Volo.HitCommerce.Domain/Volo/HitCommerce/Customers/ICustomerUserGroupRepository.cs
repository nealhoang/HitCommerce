using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Volo.HitCommerce.Customers
{
    public interface ICustomerUserGroupRepository : IBasicRepository<CustomerUserGroup>
    {
        Task<List<CustomerUserGroup>> ListByCustomerId(Guid customerId);
    }
}