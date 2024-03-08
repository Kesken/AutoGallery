using AutoMapper.Configuration;
using Business.Services.Repositories;
using DataAccess.Contexts;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistiration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("SqlCon"));
            });

            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
