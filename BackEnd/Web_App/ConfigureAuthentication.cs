﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

//using NLog;
//using NLog.Web;
using Microsoft.Extensions.Logging;
using GM.DatabaseAccess;


namespace GM.WebApp
{
    public class ConfigureAuthentication
    {
        //private readonly ILogger<ConfigureAuthentication> _logger;

        //public ConfigureAuthentication(ILogger<ConfigureAuthentication> logger)
        //{
        //    _logger = logger;
        //}
        public void ConfigureAuthenticationServices(
            IServiceCollection services,
            IConfiguration Configuration
            )
        {
            services.AddAuthentication()
            .AddGoogle(options =>
            {
                options.ClientId = Configuration["ExternalAuth:Google:ClientId"];
                options.ClientSecret = Configuration["ExternalAuth:Google:ClientSecret"];
            });

            //_logger.LogTrace("GM: Add Identity");

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
        // Govmeeting: Set options for cookie expiration.
        // TODO - While upgrading to .NET SDK 2.0, I was getting an error on the next two line so
        // I commented them out. Error = "IdentityOptions does not contain a definition for Cookies"
        //options.Cookies.ApplicationCookie.SlidingExpiration = true;
        //options.Cookies.ApplicationCookie.ExpireTimeSpan = TimeSpan.FromHours(1);

        options.Password.RequiredLength = 8;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // amount of time they are locked out
        options.Lockout.AllowedForNewUsers = true;
        // TODO We should send the admin an email if someone is locked out.
        options.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Govmeeting: Brock Allen suggest stronger hashing instead of the default.
            //services.Configure<PasswordHasherOptions>(options =>
            //{
            //    options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2;
            //    options.IterationCount = 20000;
            //});

            //_logger.LogTrace("GM: Add Authorization");

            // https://docs.asp.net/en/latest/security/authorization/claims.html
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Administrator", policy =>
                { policy.RequireClaim("role", "administrator"); });

                options.AddPolicy("Editor", policy =>
                { policy.RequireClaim("role", "editor"); });

                options.AddPolicy("Proofreader", policy =>
                { policy.RequireClaim("role", "proofreader"); });

                options.AddPolicy("PhillyEditor", policy =>
                {
                    policy.RequireClaim("role", "editor");
                    policy.RequireClaim("location", "Philadelphia");
                });
                options.AddPolicy("BbhEditor", policy =>
                {
                    policy.RequireClaim("role", "editor");
                    policy.RequireClaim("location", "Boothbay Harbor");
                });
            });

        }

    }
}

