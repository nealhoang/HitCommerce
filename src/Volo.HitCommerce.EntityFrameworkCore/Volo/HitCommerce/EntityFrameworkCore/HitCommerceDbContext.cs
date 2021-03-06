﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.HitCommerce.Addresses;
using Volo.HitCommerce.BaseEntities;
using Volo.HitCommerce.Customers;
using Volo.HitCommerce.Directions;
using Volo.HitCommerce.Medias;
using Volo.HitCommerce.UserGroups;
using Volo.HitCommerce.Vendors;
using Volo.HitCommerce.Widgets;

namespace Volo.HitCommerce.EntityFrameworkCore
{
    [ConnectionStringName("HitCommerce")]
    public class HitCommerceDbContext : AbpDbContext<HitCommerceDbContext>, IHitCommerceDbContext
    {
        public static string TablePrefix { get; set; } = HitCommerceConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = HitCommerceConsts.DefaultDbSchema;
        
        public DbSet<Address> Addresses { get; set; }
        
        public DbSet<BaseEntity> Entities { get; set; }
        
        public DbSet<BaseEntityType> EntityTypes { get; set; }
        
        public DbSet<Customer> Users { get; set; }
        
        public DbSet<CustomerAddress> UserAddresses { get; set; }
        
        public DbSet<CustomerUserGroup> CustomerUserGroups{ get; set; }
        
        public DbSet<Country> Countries { get; set; }
        
        public DbSet<StateOrProvince> StateOrProvinces { get; set; }
        
        public DbSet<District> Districts { get; set; }
        
        public DbSet<UserGroup> UserGroups { get; set; }
        
        public DbSet<Media> Medias { get; set; }
        
        public DbSet<Vendor> Vendors { get; set; }
        
        public DbSet<Widget> Widgets { get; set; }
        
        public DbSet<WidgetInstance> WidgetInstances { get; set; }

        public HitCommerceDbContext(DbContextOptions<HitCommerceDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureHitCommerce(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}