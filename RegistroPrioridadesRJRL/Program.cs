using ClientesRJRL.BLL;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;
using RegistroPrioridadesRJRL.BLL;
using RegistroPrioridadesRJRL.Models;

namespace RegistroPrioridadesRJRL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();




			var ConStr = builder.Configuration.GetConnectionString("ConStr");

			builder.Services.AddDbContext<Context>(options => options.UseSqlite(ConStr));

			builder.Services.AddScoped<PrioridadesBLL>();

			builder.Services.AddScoped<ClientesBLL>();

			builder.Services.AddScoped<TicketsBLL>();

			builder.Services.AddScoped<SistemasBLL>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}