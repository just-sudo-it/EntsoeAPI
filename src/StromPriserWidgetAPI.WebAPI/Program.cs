using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

using StromPriserWidgetAPI.Data;
using StromPriserWidgetAPI.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

builder.Services.AddHostedService<UpdateDbService>();

builder.Services.AddDbContext<DataContext>(opt =>
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
  opt.LogTo(Console.WriteLine, LogLevel.Trace);
  opt.EnableSensitiveDataLogging();
  opt.EnableDetailedErrors(builder.Environment.IsDevelopment());
  opt.ConfigureWarnings(warnings => warnings
  .Ignore(CoreEventId.SensitiveDataLoggingEnabledWarning)
  .Log(RelationalEventId.QueryPossibleUnintendedUseOfEqualsWarning));
});
#endregion

#region Configuration Files
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Configuration.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true, reloadOnChange: true);

builder.Configuration.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);

builder.Configuration.AddEnvironmentVariables();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
