using Library.ApplicationCore;
using Library.Infrastructure.Data;
using Library.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

// One line pulls in OpenTelemetry, health checks, service discovery and HTTP resilience.
builder.AddServiceDefaults();

// Same domain registrations the console app uses (Library.Console/Program.cs).
builder.Services.AddScoped<IPatronRepository, JsonPatronRepository>();
builder.Services.AddScoped<ILoanRepository, JsonLoanRepository>();
builder.Services.AddScoped<ILoanService, LoanService>();
builder.Services.AddScoped<IPatronService, PatronService>();
builder.Services.AddSingleton<JsonData>();

var app = builder.Build();

// Maps /health and /alive (in Development) from ServiceDefaults.
app.MapDefaultEndpoints();

app.MapGet("/patrons/search", async (string? q, IPatronRepository patrons) =>
    Results.Ok(await patrons.SearchPatrons(q ?? string.Empty)));

app.MapGet("/patrons/{id:int}", async (int id, IPatronRepository patrons) =>
    await patrons.GetPatron(id) is { } patron ? Results.Ok(patron) : Results.NotFound());

app.MapPost("/patrons/{id:int}/renew", async (int id, IPatronService patronService) =>
    Results.Ok(new { status = (await patronService.RenewMembership(id)).ToString() }));

app.MapPost("/loans/{id:int}/return", async (int id, ILoanService loans) =>
    Results.Ok(new { status = (await loans.ReturnLoan(id)).ToString() }));

app.MapPost("/loans/{id:int}/extend", async (int id, ILoanService loans) =>
    Results.Ok(new { status = (await loans.ExtendLoan(id)).ToString() }));

app.Run();
