using WeatherViewer.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WeatherViewer.WebApiData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c => {
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WeatherViewerContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddCustomServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    //To enable mini profiler middelware.
    //app.UseMiniProfiler();
}

app.MapControllers();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
//app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });


await app.RunAsync();