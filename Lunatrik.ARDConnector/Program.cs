using AutoMapper;
using Flurl.Http;
using Lunatrik.ARDConnector;
using Lunatrik.ARDConnector.AzureModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

// Add services to the container.
builder.Services.AddAuthentication("BasicAuthentication")
        .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapPost("/code_pushed", ([FromBody] AzureMessage payload, IMapper mapper, IConfiguration configuration) =>
{
    //1. Map azureMessage to DiscordModel

    DiscordMessage discordMessage = mapper.Map<DiscordMessage>(payload);

    //2. Send to Discord
    var webhook = configuration["Discord_Webhook"];

    webhook.PostJsonAsync(discordMessage);

    return;
});

app.Run();
