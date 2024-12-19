using AutoMapper;
using MikroGrupBireyselProje.Payment.Features.Payments.GetAll;

namespace MikroGrupBireyselProje.Payment.Features.Payments;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<Repositories.Payment, PaymentsDto>();
    }
}