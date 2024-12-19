using MikroGrupBireyselProje.Catalog;
using MikroGrupBireyselProje.Catalog.Repositories;
using MikroGrupBireyselProje.Discount.Features.Discount;
using MikroGrupBireyselProje.Shared;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthenticationExt(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddSwaggerServicesExt();
builder.Services.AddCommonServicesExt(typeof(DiscountAssembly));
builder.Services.AddVersioningExt();
builder.Services.AddOptionsExt();
builder.Services.AddDatabaseServicesExt();

var app = builder.Build();
app.UseExceptionHandler();
app.AddSwaggerMiddlewareExt();

app.UseAuthentication();
app.UseAuthorization();
var apiVersionSet = app.AddVersionSetExt();
app.AddDiscountEndpointsExt(apiVersionSet);
app.Run();