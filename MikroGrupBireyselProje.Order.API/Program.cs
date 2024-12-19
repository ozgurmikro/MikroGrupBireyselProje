using Refit;
using MikroGrupBireyselProje.Catalog;
using MikroGrupBireyselProje.Order.API.Endpoints.Order;
using MikroGrupBireyselProje.Order.API.Extensions;
using MikroGrupBireyselProje.Order.Application.Contracts.refit;
using MikroGrupBireyselProje.Order.Application.DelegateHandlers;
using MikroGrupBireyselProje.Order.Persistence;
using MikroGrupBireyselProje.Shared;
using MikroGrupBireyselProje.Shared.Options;
using MikroGrupBireyselProje.Shared.Resiliency;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthenticationExt(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddSwaggerServicesExt();
builder.Services.AddCommonServicesExt(typeof(OrderApplicationAssembly));
builder.Services.AddVersioningExt();
builder.Services.AddPersistenceExt(builder.Configuration);
builder.Services.AddMasstransitExt(builder.Configuration);

builder.Services.AddScoped<AuthenticatedHttpClientHandler>();

builder.Services.AddRefitClient<IPaymentService>()
    .ConfigureHttpClient(
        c =>
        {
            var microserviceOption =
                builder.Configuration.GetSection(nameof(MicroserviceOption)).Get<MicroserviceOption>();
            c.BaseAddress = new Uri(microserviceOption!.Payment!.Address);
        }).AddHttpMessageHandler<AuthenticatedHttpClientHandler>()
    .AddPolicyHandler(ResiliencyPolicy.AddResiliencyCombinePolicy());


var app = builder.Build();
app.UseExceptionHandler();
app.AddSwaggerMiddlewareExt();


app.UseAuthentication();
app.UseAuthorization();
var apiVersionSet = app.AddVersionSetExt();
app.AddOrderEndpointsExt(apiVersionSet);


app.Run();