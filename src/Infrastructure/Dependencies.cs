﻿using Microsoft.EntityFrameworkCore;
using Microsoft.eShopWeb.Infrastructure.Data;
using Microsoft.eShopWeb.Infrastructure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.eShopWeb.Infrastructure;

public static class Dependencies
{
    public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
          services.AddDbContext<CatalogContext>(c =>
             c.UseInMemoryDatabase("Catalog"));
         
          services.AddDbContext<AppIdentityDbContext>(options =>
             options.UseInMemoryDatabase("Identity"));
    }
}
