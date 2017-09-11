using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.PayStack.Interface;
using Payment.PayStack.Models;
using Payment.PayStack.Requests;

namespace Payment.PayStack.Processor
{
    public class Payment : IPayments
    {
        private readonly string _payStackSecretKey;

        public Payment(string payStackSecretKey)
        {
            _payStackSecretKey = payStackSecretKey;
        }

        public async Task<InitializeResponse> InitialisePayment(InitializeRequest request)
        {
           RestSharpCaller ApiCaller = new RestSharpCaller();
           ApiCaller.Paystack_SECRET_KEY = _payStackSecretKey;

            return ApiCaller.InitialisePayment(request);
        }


        public async Task<VerifyResponse> VerifyPayment(VerifyRequest request)
        {
            RestSharpCaller ApiCaller = new RestSharpCaller();

            ApiCaller.Paystack_SECRET_KEY = _payStackSecretKey;

            return ApiCaller.VerifyPayment(request);
        }

    }
}
