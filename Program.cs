var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Services.AddApplicationInsightsTelemetry();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

try {
    app.Logger.LogWarning("Configuring routes....");
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // app.UseHttpsRedirection();

    // app.UseAuthorization();

    app.MapControllers();

    app.Logger.LogWarning("Running app....");
    app.Run();
} catch(Exception e) {
    app.Logger.LogError("Error while configuring app..", e);

    throw;
}
