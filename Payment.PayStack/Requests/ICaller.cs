using System.Collections.Generic;
using Payment.PayStack.Models;

namespace Payment.PayStack.Requests
{
    public interface ICaller
    {
        InitializeResponse InitialisePayment( InitializeRequest request);
        VerifyResponse VerifyPayment(VerifyRequest request);
        
    }
}