using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users.EntityFrameworkCore;
using Volo.HitCommerce.EntityFrameworkCore;

namespace Volo.HitCommerce.Customers
{
    public class EfCoreCustomerRepository : EfCoreUserRepositoryBase<HitCommerceDbContext, Customer>,
        ICustomerRepository
    {
        public EfCoreCustomerRepository(IDbContextProvider<HitCommerceDbContext> dbContextProvider) : base(
            dbContextProvider)
        {
        }

        public async Task<List<Customer>> ListByVendorId(Guid vendorId)
        {
            return await DbSet.Where(x => x.VendorId.HasValue && x.VendorId == vendorId).ToListAsync();
        }

        public async Task<List<Customer>> GetCustomers(int maxCount, string filter)
        {
            return await DbSet
                .WhereIf(!string.IsNullOrWhiteSpace(filter), x => x.UserName.Contains(filter))
                .Take(maxCount).ToListAsync();
        }
    }
}