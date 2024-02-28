using DomainEntities;
using DomainLogic.Service;
using Firebase.Auth;
using FirebaseAdmin;
using GolfApi.Services;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile(builder.Configuration.GetSection("GOOGLE_APPLICATION_CREDENTIALS").Value)
}));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddScheme<AuthenticationSchemeOptions,FirebaseAuthenticationHandler>(JwtBearerDefaults.AuthenticationScheme, (o) => { });

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder
            .AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

//builder.Services.Add(new ServiceDescriptor(typeof(AuthenticationFacade), typeof(AuthenticationFacade), ServiceLifetime.Scoped));
builder.Services.Add(new ServiceDescriptor(typeof(DomainLogic.Service.AuthenticationService), typeof(DomainLogic.Service.AuthenticationService), ServiceLifetime.Scoped));
builder.Services.Add(new ServiceDescriptor(typeof(FirebaseService), typeof(FirebaseService), ServiceLifetime.Scoped));
builder.Services.Add(new ServiceDescriptor(typeof(FirebaseAuthProvider),new FirebaseAuthProvider(new FirebaseConfig(builder.Configuration.GetSection("Firebase").GetSection("APIKey").Value))));
builder.Services.Add(new ServiceDescriptor(typeof(GolfApi.Services.GameManagementService), typeof(GolfApi.Services.GameManagementService), ServiceLifetime.Scoped));
//builder.Services.AddScoped<GameMatchBackendCalcService>();
builder.Services.AddDbContext<GolfDbContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("metaGolfDbConnection"));
    //options.UseMySQL(builder.Configuration.GetConnectionString("metaGolfDbConnection"));
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();

