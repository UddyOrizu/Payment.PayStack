using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.PayStack.Interface;
using Payment.PayStack.Models;
using Payment.PayStack.Requests;
using Payment.PayStack.Models.Verify;

namespace Payment.PayStack
{
    public class Payment : IPayments
    {
        private readonly string _payStackSecretKey;

        public Payment(string payStackSecretKey)
        {
            _payStackSecretKey = payStackSecretKey;
        }

        public async Task<InitializeResponse> InitializePayment(InitializeRequest request)
        {
           RestSharpCaller ApiCaller = new RestSharpCaller();
           ApiCaller.Paystack_SECRET_KEY = _payStackSecretKey;

            return ApiCaller.InitializePayment(request);
        }


        public async Task<VerifyResponse> VerifyPayment(VerifyRequest request)
        {
            RestSharpCaller ApiCaller = new RestSharpCaller();

            ApiCaller.Paystack_SECRET_KEY = _payStackSecretKey;

            return ApiCaller.VerifyPayment(request);
        }

    }
}
