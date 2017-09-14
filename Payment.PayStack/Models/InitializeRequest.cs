using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Payment.PayStack.Models
{
    public class InitializeRequest
    {
        [JsonProperty("callback_url")]
        public string callback_url { get; set; }

        [JsonProperty("amount")]
        public string amount { get; set; }

        [JsonProperty("reference")]
        public string reference { get; set; }

        [JsonProperty("bearer")]
        public string bearer { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

         [JsonProperty("channels")]
         public string[] channels { get; set; }

         [JsonProperty("subaccount")]
         public string subaccount { get; set; }

        [JsonProperty("transaction_charge")]
        public int transaction_charge { get; set; }
    }
}
