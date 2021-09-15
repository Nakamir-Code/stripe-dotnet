// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptions : StripeEntity<InvoicePaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the Canadian
        /// pre-authorized debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public InvoicePaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public InvoicePaymentSettingsPaymentMethodOptionsCard Card { get; set; }
    }
}
