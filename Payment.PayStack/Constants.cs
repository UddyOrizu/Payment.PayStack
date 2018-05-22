using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayStack.Payment
{
    public static class Constants
    {
        public static class Routes
        {
            public const string BaseUrl = "https://api.paystack.co/";
            public const string InitializeTransaction =  "transaction/initialize";
            public const string VerifyTransaction =  "transaction/verify/{0}";
        }
    }
}
