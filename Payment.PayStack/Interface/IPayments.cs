using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayStack.Payment.Models;
using PayStack.Payment.Models.Verify;

namespace PayStack.Payment.Interface
{
    public interface IPayments
    {
        Task<InitializeResponse> InitializePayment(InitializeRequest request);
        Task<VerifyResponse> VerifyPayment(VerifyRequest request);
    }
}
