using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeatureApplication.ApplicationContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FeatureApplication {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices (IServiceCollection services) {
            services.AddDbContext<ApplicationDbContext> (options => {
                options.UseSqlServer (Configuration.GetConnectionString ("ApplicationConnection"));
            });
            services.AddMvc ()
                .AddJsonOptions (opt => {
                    opt.SerializerSettings.ReferenceLoopHandling =
                        ReferenceLoopHandling.Ignore;
                });
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseMvc ();
        }
    }
}