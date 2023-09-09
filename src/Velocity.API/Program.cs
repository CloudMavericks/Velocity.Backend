using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Velocity.API.Configurations;
using Velocity.API.Endpoints;
using Velocity.API.Extensions;
using Velocity.Shared.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddTokenConfiguration(builder.Configuration);
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

app.MapPost("api/login", ([FromBody] LoginRequest request, [FromServices]IOptions<TokenConfiguration> tokenConfiguration) 
    => LoginEndpoints.Login(request, tokenConfiguration.Value));

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Velocity.API v1"));

await app.RunAsync();