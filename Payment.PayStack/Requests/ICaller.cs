using System.Collections.Generic;
using PayStack.Payment.Models;
using PayStack.Payment.Models.Verify;

namespace PayStack.Payment.Requests
{
    public interface ICaller
    {
        InitializeResponse InitializePayment( InitializeRequest request);
        VerifyResponse VerifyPayment(VerifyRequest request);
        
    }
}