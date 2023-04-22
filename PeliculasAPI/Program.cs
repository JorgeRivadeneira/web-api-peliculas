using PeliculasAPI;

var builder = WebApplication.CreateBuilder(args);

var starup = new Startup(builder.Configuration);

starup.ConfigureServices(builder.Services);

// Add services to the container.


var app = builder.Build();

starup.Configure(app, app.Environment);


app.Run();
