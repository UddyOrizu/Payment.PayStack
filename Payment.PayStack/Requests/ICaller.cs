using System.Collections.Generic;
using Payment.PayStack.Models;
using Payment.PayStack.Models.Verify;

namespace Payment.PayStack.Requests
{
    public interface ICaller
    {
        InitializeResponse InitializePayment( InitializeRequest request);
        VerifyResponse VerifyPayment(VerifyRequest request);
        
    }
}