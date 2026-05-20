using eCommerce.Core;
using eCommerceAPI.Middlewares;


var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure service.
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add controllers to the service collection
builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();
//Route incoming HTTP requests to the appropriate controllers
app.UseRouting();

//authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

//controller routes
app.MapControllers();

app.Run();
