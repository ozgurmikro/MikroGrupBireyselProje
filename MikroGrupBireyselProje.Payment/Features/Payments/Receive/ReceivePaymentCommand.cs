﻿using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Payment.Features.Payments.Receive;

public record ReceivePaymentCommand(
    string OrderCode,
    string CardNumber,
    string CardHolderName,
    string ExpiryDate,
    string Cvv,
    decimal Amount) : IRequestByServiceResult<ReceivePaymentResponse>;