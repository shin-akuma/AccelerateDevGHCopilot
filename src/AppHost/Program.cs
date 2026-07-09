var builder = DistributedApplication.CreateBuilder(args);

// The Library.Api web service — a long-running service that Aspire is designed for.
// It shows up in the dashboard with live logs, traces, metrics and health status.
builder.AddProject<Projects.Library_Api>("library-api");

// The existing console app, orchestrated as a resource. Note: it is interactive
// (reads stdin), so under orchestration it exits at end-of-input — kept here only
// to show that non-service projects can also be registered.
builder.AddProject<Projects.Library_Console>("library-console");

// Example of what Aspire really shines at — adding backing resources and wiring
// their connection info into your services automatically. Uncomment once the app
// consumes them (and add the matching Aspire.Hosting.* package to this project):
//
// var cache = builder.AddRedis("cache");
// var db = builder.AddPostgres("pg").AddDatabase("librarydb");
// builder.AddProject<Projects.Library_Console>("library-console")
//        .WithReference(cache)
//        .WithReference(db);

builder.Build().Run();
