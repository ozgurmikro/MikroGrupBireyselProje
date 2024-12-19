using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Payment.Features.Payments.GetAll;

public record GetAllPaymentsQuery : IRequestByServiceResult<List<PaymentsDto>>;