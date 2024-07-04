// <copyright file="Attributes65.cs" company="APIMatic">
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
    /// Attributes65.
    /// </summary>
    public class Attributes65
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes65"/> class.
        /// </summary>
        public Attributes65()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes65"/> class.
        /// </summary>
        /// <param name="redirectedAccountNumber">redirected_account_number.</param>
        /// <param name="redirectedBankId">redirected_bank_id.</param>
        /// <param name="route">route.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="settlementCycle">settlement_cycle.</param>
        /// <param name="settlementDate">settlement_date.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        public Attributes65(
            string redirectedAccountNumber = null,
            string redirectedBankId = null,
            Models.Route1Enum? route = null,
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            int? settlementCycle = null,
            DateTime? settlementDate = null,
            Models.ReturnSubmissionStatusEnum? status = null,
            string statusReason = null)
        {
            this.RedirectedAccountNumber = redirectedAccountNumber;
            this.RedirectedBankId = redirectedBankId;
            this.Route = route;
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.SettlementCycle = settlementCycle;
            this.SettlementDate = settlementDate;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Details of the account to which funds are redirected (if applicable)
        /// </summary>
        [JsonProperty("redirected_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectedAccountNumber { get; set; }

        /// <summary>
        /// Details of the bank to which funds are redirected (if applicable)
        /// </summary>
        [JsonProperty("redirected_bank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectedBankId { get; set; }

        /// <summary>
        /// Route taken for a return
        /// </summary>
        [JsonProperty("route", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Route1Enum? Route { get; set; }

        /// <summary>
        /// Scheme-specific status (if submission has been submitted to a scheme)
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// [Description](http://api-docs.form3.tech/api.html#enumerations-scheme-status-codes-for-bacs) of `scheme_status_code`
        /// </summary>
        [JsonProperty("scheme_status_code_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCodeDescription { get; set; }

        /// <summary>
        /// Cycle in which the payment will be settled
        /// </summary>
        [JsonProperty("settlement_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? SettlementCycle { get; set; }

        /// <summary>
        /// Date that the payment will be settled
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-submission-status) of the submission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnSubmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Description of the submission status
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes65 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes65 other &&                ((this.RedirectedAccountNumber == null && other.RedirectedAccountNumber == null) || (this.RedirectedAccountNumber?.Equals(other.RedirectedAccountNumber) == true)) &&
                ((this.RedirectedBankId == null && other.RedirectedBankId == null) || (this.RedirectedBankId?.Equals(other.RedirectedBankId) == true)) &&
                ((this.Route == null && other.Route == null) || (this.Route?.Equals(other.Route) == true)) &&
                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true)) &&
                ((this.SettlementCycle == null && other.SettlementCycle == null) || (this.SettlementCycle?.Equals(other.SettlementCycle) == true)) &&
                ((this.SettlementDate == null && other.SettlementDate == null) || (this.SettlementDate?.Equals(other.SettlementDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RedirectedAccountNumber = {(this.RedirectedAccountNumber == null ? "null" : this.RedirectedAccountNumber)}");
            toStringOutput.Add($"this.RedirectedBankId = {(this.RedirectedBankId == null ? "null" : this.RedirectedBankId)}");
            toStringOutput.Add($"this.Route = {(this.Route == null ? "null" : this.Route.ToString())}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.SettlementCycle = {(this.SettlementCycle == null ? "null" : this.SettlementCycle.ToString())}");
            toStringOutput.Add($"this.SettlementDate = {(this.SettlementDate == null ? "null" : this.SettlementDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
        }
    }
}