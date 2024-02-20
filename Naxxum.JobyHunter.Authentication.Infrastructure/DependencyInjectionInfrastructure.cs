using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Naxxum.JobyHunter.Authentication.Application.Interfaces;
using Naxxum.JobyHunter.Authentication.Domain.Entities;
using Naxxum.JobyHunter.Authentication.Infrastructure.Data;
using Naxxum.JobyHunter.Authentication.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Infrastructure
{
    public static  class DependencyInjectionInfrastructure
    {
        public static IServiceCollection AddInfrastructureServices
           (this IServiceCollection services, IConfiguration configuration)

        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ??
                    throw new InvalidOperationException("connection string 'DefaultConnection not found '"))
            );

            services.AddTransient<IRepository<Blog>, Repository<Blog>>();

            return services;

        }
    }
}
