using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using MikroGrupBireyselProje.Payment;
using MikroGrupBireyselProje.Payment.Features.Payments;
using MikroGrupBireyselProje.Payment.Repositories;
using MikroGrupBireyselProje.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthenticationExt(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddSwaggerServicesExt();
builder.Services.AddCommonServicesExt(typeof(PaymentAssembly));
builder.Services.AddVersioningExt();

builder.Services.AddDbContext<AppDbContext>(options => { options.UseInMemoryDatabase("payment-db"); });
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
var app = builder.Build();
app.UseExceptionHandler();
app.AddSwaggerMiddlewareExt();


app.UseAuthentication();
app.UseAuthorization();
var apiVersionSet = app.AddVersionSetExt();
app.AddPaymentEndpointsExt(apiVersionSet);


app.Run();