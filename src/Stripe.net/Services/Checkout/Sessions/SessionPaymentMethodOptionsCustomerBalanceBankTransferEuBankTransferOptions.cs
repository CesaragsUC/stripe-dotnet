// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// The desired country code of the bank account information. Permitted values include:
        /// <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
