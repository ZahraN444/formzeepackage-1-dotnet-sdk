// <copyright file="ReturnPaymentAttributes.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ReturnPaymentAttributes.
    /// </summary>
    public class ReturnPaymentAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPaymentAttributes"/> class.
        /// </summary>
        public ReturnPaymentAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPaymentAttributes"/> class.
        /// </summary>
        /// <param name="agents">agents.</param>
        /// <param name="amount">amount.</param>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="limitBreachEndDatetime">limit_breach_end_datetime.</param>
        /// <param name="limitBreachStartDatetime">limit_breach_start_datetime.</param>
        /// <param name="reason">reason.</param>
        /// <param name="returnCode">return_code.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        /// <param name="settlement">settlement.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        /// <param name="userDefinedData">user_defined_data.</param>
        public ReturnPaymentAttributes(
            List<Models.Agent> agents = null,
            string amount = null,
            string clearingId = null,
            string currency = null,
            DateTime? limitBreachEndDatetime = null,
            DateTime? limitBreachStartDatetime = null,
            string reason = null,
            string returnCode = null,
            string schemeTransactionId = null,
            Models.Settlement settlement = null,
            string uniqueSchemeId = null,
            List<Models.UserDefinedData> userDefinedData = null)
        {
            this.Agents = agents;
            this.Amount = amount;
            this.ClearingId = clearingId;
            this.Currency = currency;
            this.LimitBreachEndDatetime = limitBreachEndDatetime;
            this.LimitBreachStartDatetime = limitBreachStartDatetime;
            this.Reason = reason;
            this.ReturnCode = returnCode;
            this.SchemeTransactionId = schemeTransactionId;
            this.Settlement = settlement;
            this.UniqueSchemeId = uniqueSchemeId;
            this.UserDefinedData = userDefinedData;
        }

        /// <summary>
        /// Block to represent a Financial Institution/agent in the payment chain
        /// </summary>
        [JsonProperty("agents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Agent> Agents { get; set; }

        /// <summary>
        /// The amount to return which should correspond to the amount of the original payment
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Unique identifier for organisations collecting payments
        /// </summary>
        [JsonProperty("clearing_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingId { get; set; }

        /// <summary>
        /// ISO currency code for transaction amount
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Time a payment was released from being held due to a limit breach
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("limit_breach_end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LimitBreachEndDatetime { get; set; }

        /// <summary>
        /// Start time a payment was held due to a limit breach
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("limit_breach_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LimitBreachStartDatetime { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// The return [reason code](http://draft-api-docs.form3.tech/api.html#enumerations-payment-return-codes)
        /// </summary>
        [JsonProperty("return_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// A unique reference to the return payment instruction. If not supplied, the value is generated by Form3.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// Specifies the details on how the settlement of the transaction between the instructing agent and the instructed agent is completed
        /// </summary>
        [JsonProperty("settlement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Settlement Settlement { get; set; }

        /// <summary>
        /// The scheme-specific unique transaction ID. Populated by the scheme.
        /// </summary>
        [JsonProperty("unique_scheme_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSchemeId { get; set; }

        /// <summary>
        /// All purpose list of key-value pairs specific data stored on the return.
        /// </summary>
        [JsonProperty("user_defined_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDefinedData> UserDefinedData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnPaymentAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ReturnPaymentAttributes other &&                ((this.Agents == null && other.Agents == null) || (this.Agents?.Equals(other.Agents) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.LimitBreachEndDatetime == null && other.LimitBreachEndDatetime == null) || (this.LimitBreachEndDatetime?.Equals(other.LimitBreachEndDatetime) == true)) &&
                ((this.LimitBreachStartDatetime == null && other.LimitBreachStartDatetime == null) || (this.LimitBreachStartDatetime?.Equals(other.LimitBreachStartDatetime) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.ReturnCode == null && other.ReturnCode == null) || (this.ReturnCode?.Equals(other.ReturnCode) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true)) &&
                ((this.Settlement == null && other.Settlement == null) || (this.Settlement?.Equals(other.Settlement) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true)) &&
                ((this.UserDefinedData == null && other.UserDefinedData == null) || (this.UserDefinedData?.Equals(other.UserDefinedData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Agents = {(this.Agents == null ? "null" : $"[{string.Join(", ", this.Agents)} ]")}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.LimitBreachEndDatetime = {(this.LimitBreachEndDatetime == null ? "null" : this.LimitBreachEndDatetime.ToString())}");
            toStringOutput.Add($"this.LimitBreachStartDatetime = {(this.LimitBreachStartDatetime == null ? "null" : this.LimitBreachStartDatetime.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ReturnCode = {(this.ReturnCode == null ? "null" : this.ReturnCode)}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
            toStringOutput.Add($"this.Settlement = {(this.Settlement == null ? "null" : this.Settlement.ToString())}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
            toStringOutput.Add($"this.UserDefinedData = {(this.UserDefinedData == null ? "null" : $"[{string.Join(", ", this.UserDefinedData)} ]")}");
        }
    }
}