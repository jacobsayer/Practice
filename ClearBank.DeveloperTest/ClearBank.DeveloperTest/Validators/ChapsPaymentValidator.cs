﻿using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Validators
{
    public class ChapsPaymentValidator : PaymentSchemeValidator
    {
        public override bool IsValid(Account account, decimal amount)
        {
            return account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Chaps) && account.Status == AccountStatus.Live;
        }
    }
}
