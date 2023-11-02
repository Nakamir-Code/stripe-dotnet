// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsCz : StripeEntity<RegistrationCountryOptionsCz>
    {
        [JsonProperty("standard")]
        public RegistrationCountryOptionsCzStandard Standard { get; set; }

        /// <summary>
        /// Type of registration in an EU country.
        /// One of: <c>ioss</c>, <c>oss_non_union</c>, <c>oss_union</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
