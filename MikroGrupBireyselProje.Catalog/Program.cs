using MikroGrupBireyselProje.Catalog;
using MikroGrupBireyselProje.Catalog.Features.Categories;
using MikroGrupBireyselProje.Catalog.Features.Courses;
using MikroGrupBireyselProje.Catalog.Repositories;
using MikroGrupBireyselProje.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthenticationExt(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddSwaggerServicesExt();
builder.Services.AddDatabaseServicesExt();
builder.Services.AddCommonServicesExt(typeof(CatalogAssembly));
builder.Services.AddOptionsExt();
builder.Services.AddVersioningExt();

var app = builder.Build();
app.UseExceptionHandler();

// Configure the HTTP request pipeline.
app.AddSwaggerMiddlewareExt();

app.UseAuthentication();
app.UseAuthorization();
var apiVersionSet = app.AddVersionSetExt();
app.AddCategoryEndpointsExt(apiVersionSet);
app.AddCourseEndpointsExt(apiVersionSet);
_ = app.AddSeedDataExt().ContinueWith(task => Console.WriteLine("Seed data has been saved successfully."));
app.Run();