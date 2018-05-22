using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayStack.Payment.Interface;
using PayStack.Payment.Models;
using PayStack.Payment.Requests;
using PayStack.Payment.Models.Verify;

namespace PayStack.Payment
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
