﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace UNIVidaPortalWeb.Common.Token.Src
{
    public static class Extensions
    {
        private static readonly string JwtSectionName = "jwt";
        
        public static IServiceCollection AddJwtCustomized(this IServiceCollection services, string keyAuthJwtGateway = "SECURITY-TOKEN")
        {
            IConfiguration configuration;
            using (var serviceProvider = services.BuildServiceProvider())
            {
                configuration = serviceProvider.GetService<IConfiguration>();
            }


            //var options = configuration.GetOptions<JwtOptions>(JwtSectionName);

            var options = new JwtOptions();
            configuration.GetSection(JwtSectionName).Bind(options);

            if (options.Enabled)
            {
                var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(options.Key));

                services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                        .AddJwtBearer(keyAuthJwtGateway, opt =>
                        {
                            opt.TokenValidationParameters = new TokenValidationParameters
                            {
                                ValidateIssuer = true,
                                ValidateAudience = true,
                                ValidateLifetime = true,
                                ValidateIssuerSigningKey = true,

                                ValidIssuer = options.Issuer,
                                ValidAudience = options.Audience,
                                IssuerSigningKey = signingKey
                            };
                        });                    
            }

            return services;
        }
    }
}
