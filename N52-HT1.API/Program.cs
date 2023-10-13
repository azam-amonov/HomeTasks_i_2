using System.Threading.RateLimiting;
using FileBaseContext.Context.Models.Configurations;
using N52_HT1.API.DataAccess;
using N52_HT1.API.Services.Interface;
using N52_HT1.API.Services.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IDataContext, AppFileContext>(_ =>
{
    var options = new FileContextOptions<AppFileContext>
    {
                    StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage")
    };

    var context = new AppFileContext(options);
    context.FetchAsync().AsTask().Wait();
    return context;

});

builder.Services.AddSingleton<IUserService, UserService>()
                .AddSingleton<IAccountService, AccountService>()
                .AddSingleton<IEmailSenderService, EmailSenderService>()
                .AddSingleton<AccountService>();

// Learn more bout configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();