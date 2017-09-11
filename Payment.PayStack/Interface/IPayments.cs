using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.PayStack.Models;
namespace Payment.PayStack.Interface
{
    public interface IPayments
    {
        Task<InitializeResponse> InitializePayment(InitializeRequest request);
        Task<VerifyResponse> VerifyPayment(VerifyRequest request);
    }
}
