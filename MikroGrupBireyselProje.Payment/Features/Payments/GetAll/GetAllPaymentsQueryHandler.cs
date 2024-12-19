﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MikroGrupBireyselProje.Payment.Repositories;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Payment.Features.Payments.GetAll;

public class GetAllPaymentsQueryHandler(AppDbContext context, IMapper mapper)
    : IRequestHandler<GetAllPaymentsQuery, ServiceResult<List<PaymentsDto>>>
{
    public async Task<ServiceResult<List<PaymentsDto>>> Handle(GetAllPaymentsQuery request,
        CancellationToken cancellationToken)
    {
        var payments = await context.Payments.OrderByDescending(x => x.PaymentDate)
            .ToListAsync(cancellationToken);

        var result = mapper.Map<List<PaymentsDto>>(payments);

        return ServiceResult<List<PaymentsDto>>.SuccessAsOk(result);
    }
}