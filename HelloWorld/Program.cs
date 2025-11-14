// A builder is initialized and then built.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GET endpoint mapped onto the base URL route, with a
// function body that returns a string.
app.MapGet("/", () => "Hello World!");


//The initialized app is started
app.Run();