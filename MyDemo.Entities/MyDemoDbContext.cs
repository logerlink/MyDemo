using Microsoft.EntityFrameworkCore;
using MyDemo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo.Entities
{
    public class MyDemoDbContext:DbContext
    {
        public MyDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 可以单独指定某个字段
            modelBuilder.Entity<User>().Property(x => x.Money).HasPrecision(18, 4);
            // 但不支持Owned的从属属性
            // modelBuilder.Entity<User>().Property(x => x.Address.Price).HasPrecision(18, 4);
            // modelBuilder.Entity<Address>().Property(x=>x.Price).HasPrecision(18, 4);
            // modelBuilder.Entity<Address>().Property(x=>x.Price).HasPrecision(18, 4);

            // 也可以指定全部decimal或decimal?类型的字段，同时支持Owned的从属属性，若多次指定则覆盖
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var propertyInfo in entityType.ClrType.GetProperties())
                {
                    if (propertyInfo.PropertyType == typeof(decimal) || propertyInfo.PropertyType == typeof(decimal?))
                    {
                        var property = entityType.FindProperty(propertyInfo);
                        if (property == null) continue;
                        property.SetPrecision(16);
                        property.SetScale(5);
                    }
                }
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
