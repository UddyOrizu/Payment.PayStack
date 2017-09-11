# Payment.PayStack
This is a C# implemantation of Paystack Standard https://developers.paystack.co/v1.0/reference

This code only implements Transaction initialization and Verifying Transactions

Feel free to use and extend  :)

Requires RestSharp and Json.Net

TO DO: adding this to Nuget for easy install, Add some Logging 

On your payment post page 

using Payment.PayStack.Processor;

var payment = new Payment("Bearer secret key goes here");

var transaction = await payment.InitializePayment(request);

Check status and Redirect to transaction.data.authorization_url

On your callback or payment verification page 

var payment = new Payment("Bearer secret key goes here");

var transaction = await payment.VerifyPayment(request);
