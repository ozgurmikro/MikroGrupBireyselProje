using MikroGrupBireyselProje.Basket.Extensions;
using MikroGrupBireyselProje.Basket.Features.Basket;
using MikroGrupBireyselProje.Catalog;
using MikroGrupBireyselProje.Shared;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthenticationExt(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddSwaggerServicesExt();
builder.Services.AddCommonServicesExt(typeof(BasketAssembly));
builder.Services.AddVersioningExt();
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    //options.InstanceName = "SampleInstance";
});

builder.Services.AddMasstransitExt(builder.Configuration);

var app = builder.Build();
app.UseExceptionHandler();

app.AddSwaggerMiddlewareExt();
app.UseAuthentication();
app.UseAuthorization();
var apiVersionSet = app.AddVersionSetExt();
app.AddBasketEndpointsExt(apiVersionSet);


app.Run();