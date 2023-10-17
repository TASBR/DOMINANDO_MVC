using AppSemTemplate.Data;
using Microsoft.AspNetCore.Identity;

namespace AppSemTemplate.Configuration
{
    public static class IdentityConfig
    {
        public static WebApplicationBuilder AddIdentityConfiguration(this WebApplicationBuilder builder)
        {
            //UTILIZANDO IDENTITY
            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            }).AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<AppDbContext>();//TRABALHANDO COM ENTITY FRAMEWORK

            builder.Services.AddAuthorization(options =>
            {
                //USE POLICY
                options.AddPolicy("PodeExcluirPermanentemente", policy =>
                policy.RequireRole("Admin"));

                //USE CLAIMS
                options.AddPolicy("VerProdutos", policy =>
                policy.RequireClaim("Produtos", "VI"));
            });

            return builder;
        }
    }
}
