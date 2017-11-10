using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpeakerWrangler.Models;
using Microsoft.EntityFrameworkCore;

namespace SpeakerWrangler
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddEntityFrameworkSqlite()
				.AddDbContext<SpeakerWranglerDbContext>(options =>
				{
					options.UseSqlite("Data Source=mydb.db");
				});

			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, SpeakerWranglerDbContext context)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
									name: "default",
									template: "{controller}/{action=Index}/{id?}");
			});

			context.Database.EnsureCreated();
			if (!context.Speakers.Any())
			{
				context.Speakers.Add(new Speaker { Name = "Tasha Scott", Email = "tasha@microsoft.com" });
				context.Speakers.Add(new Speaker { Name = "Jeff Fritz", Email = "jfritz@microsoft.com" });
				context.SaveChanges();
			}


		}
	}
}
