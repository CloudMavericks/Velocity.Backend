using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Velocity.API.Configurations;
using Velocity.API.Endpoints;
using Velocity.API.Extensions;
using Velocity.Shared.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTokenConfiguration(builder.Configuration);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetTokenConfiguration().Secret))
        };
    });
builder.Services.AddAuthorization(options =>
{
    options.DefaultPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Velocity.API", Version = "v1" });
});

var app = builder.Build();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers().RequireAuthorization();

app.MapPost("api/login", ([FromBody] LoginRequest request, [FromServices]IOptions<TokenConfiguration> tokenConfiguration) 
    => LoginEndpoints.Login(request, tokenConfiguration.Value)).WithName("Login").WithOpenApi();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Velocity.API v1"));

await app.RunAsync();