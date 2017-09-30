using System.Collections.Generic;
using System.Configuration;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using Payment.PayStack.Models;
using System;
using Payment.PayStack.Models.Verify;

namespace Payment.PayStack.Requests
{
    public class RestSharpCaller : ICaller
    {
        private RestClient client;

        public string Paystack_SECRET_KEY { get; set; }

        public RestSharpCaller()
        {
            client = new RestClient(Constants.Routes.BaseUrl);
        }

       public InitializeResponse InitializePayment(InitializeRequest initializerequest)
       {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;


           var request = new RestRequest(Constants.Routes.InitializeTransaction, Method.POST);
           request.AddHeader("content-type", "application/x-www-form-urlencoded");

           request.AddHeader("authorization", "Bearer " + Paystack_SECRET_KEY);
           request.AddJsonBody(initializerequest);

           try
           {
               var response = client.Execute<InitializeResponse>(request);

               if (response.StatusCode == System.Net.HttpStatusCode.OK)
               {
                   var result = JsonConvert.DeserializeObject<InitializeResponse>(response.Content);

                   return result;
               }
               return null;
           }
           catch
           {
               return null;
           }
        }

        public  VerifyResponse VerifyPayment(VerifyRequest verifyrequest)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var url = string.Format(Constants.Routes.VerifyTransaction, verifyrequest.reference);
            var request = new RestRequest(url, Method.GET);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("authorization", "Bearer " + Paystack_SECRET_KEY);
            try
            {
                var response = client.Execute<VerifyResponse>(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = JsonConvert.DeserializeObject<VerifyResponse>(response.Content);

                    return result;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       
       
    }
}