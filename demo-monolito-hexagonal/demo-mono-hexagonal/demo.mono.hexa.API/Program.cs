using demo.mono.dominio.login;
using Microsoft.AspNetCore.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

builder.Services.AddScoped<IAuthentication, Authentication>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler(exceptionHandlerApp =>
//    {
//        exceptionHandlerApp.Run(async context =>
//        {
//            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

//            // using static System.Net.Mime.MediaTypeNames;
//            context.Response.ContentType = Text.Plain;

//            await context.Response.WriteAsync("An exception was thrown.");

//            var exceptionHandlerPathFeature =
//                context.Features.Get<IExceptionHandlerPathFeature>();

//            if (exceptionHandlerPathFeature?.Error is FileNotFoundException)
//            {
//                await context.Response.WriteAsync(" The file was not found.");
//            }

//            if (exceptionHandlerPathFeature?.Path == "/")
//            {
//                await context.Response.WriteAsync(" Page: Home.");
//            }
//        });
//    });
//}


app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo App"));


app.UseStatusCodePages();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
