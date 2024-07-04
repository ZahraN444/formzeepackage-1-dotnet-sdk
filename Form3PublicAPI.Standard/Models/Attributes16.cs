// <copyright file="Attributes16.cs" company="APIMatic">
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
    /// Attributes16.
    /// </summary>
    public class Attributes16
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes16"/> class.
        /// </summary>
        public Attributes16()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes16"/> class.
        /// </summary>
        /// <param name="clearingSystem">clearing_system.</param>
        /// <param name="fileIdentifier">file_identifier.</param>
        /// <param name="fileNumber">file_number.</param>
        /// <param name="limitBreachEndDatetime">limit_breach_end_datetime.</param>
        /// <param name="limitBreachStartDatetime">limit_breach_start_datetime.</param>
        /// <param name="redirectedAccountNumber">redirected_account_number.</param>
        /// <param name="redirectedBankId">redirected_bank_id.</param>
        /// <param name="route">route.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="settlementCycle">settlement_cycle.</param>
        /// <param name="settlementDate">settlement_date.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        /// <param name="transactionStartDatetime">transaction_start_datetime.</param>
        public Attributes16(
            string clearingSystem = null,
            string fileIdentifier = null,
            string fileNumber = null,
            DateTime? limitBreachEndDatetime = null,
            DateTime? limitBreachStartDatetime = null,
            string redirectedAccountNumber = null,
            string redirectedBankId = null,
            Models.RouteEnum? route = null,
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            int? settlementCycle = null,
            DateTime? settlementDate = null,
            Models.PaymentSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null,
            DateTime? transactionStartDatetime = null)
        {
            this.ClearingSystem = clearingSystem;
            this.FileIdentifier = fileIdentifier;
            this.FileNumber = fileNumber;
            this.LimitBreachEndDatetime = limitBreachEndDatetime;
            this.LimitBreachStartDatetime = limitBreachStartDatetime;
            this.RedirectedAccountNumber = redirectedAccountNumber;
            this.RedirectedBankId = redirectedBankId;
            this.Route = route;
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.SettlementCycle = settlementCycle;
            this.SettlementDate = settlementDate;
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
            this.TransactionStartDatetime = transactionStartDatetime;
        }

        /// <summary>
        /// Clearing infrastructure through which the payment instruction was processed
        /// </summary>
        [JsonProperty("clearing_system", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingSystem { get; set; }

        /// <summary>
        /// Identification code of the file sent to scheme.
        /// </summary>
        [JsonProperty("file_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string FileIdentifier { get; set; }

        /// <summary>
        /// Number of the file sent to scheme.
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNumber { get; set; }

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
        /// Route taken for an outbound payment
        /// </summary>
        [JsonProperty("route", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RouteEnum? Route { get; set; }

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
        /// [Status of the submission](https://api-docs.form3.tech/api.html#enumerations-payment-status-codes-submission-status)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentSubmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Description of the submission status
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Date of the submission
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("submission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SubmissionDatetime { get; set; }

        /// <summary>
        /// Time the request was received by Form3. Used to compute the total transaction time of a payment.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TransactionStartDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes16 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes16 other &&                ((this.ClearingSystem == null && other.ClearingSystem == null) || (this.ClearingSystem?.Equals(other.ClearingSystem) == true)) &&
                ((this.FileIdentifier == null && other.FileIdentifier == null) || (this.FileIdentifier?.Equals(other.FileIdentifier) == true)) &&
                ((this.FileNumber == null && other.FileNumber == null) || (this.FileNumber?.Equals(other.FileNumber) == true)) &&
                ((this.LimitBreachEndDatetime == null && other.LimitBreachEndDatetime == null) || (this.LimitBreachEndDatetime?.Equals(other.LimitBreachEndDatetime) == true)) &&
                ((this.LimitBreachStartDatetime == null && other.LimitBreachStartDatetime == null) || (this.LimitBreachStartDatetime?.Equals(other.LimitBreachStartDatetime) == true)) &&
                ((this.RedirectedAccountNumber == null && other.RedirectedAccountNumber == null) || (this.RedirectedAccountNumber?.Equals(other.RedirectedAccountNumber) == true)) &&
                ((this.RedirectedBankId == null && other.RedirectedBankId == null) || (this.RedirectedBankId?.Equals(other.RedirectedBankId) == true)) &&
                ((this.Route == null && other.Route == null) || (this.Route?.Equals(other.Route) == true)) &&
                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true)) &&
                ((this.SettlementCycle == null && other.SettlementCycle == null) || (this.SettlementCycle?.Equals(other.SettlementCycle) == true)) &&
                ((this.SettlementDate == null && other.SettlementDate == null) || (this.SettlementDate?.Equals(other.SettlementDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.SubmissionDatetime == null && other.SubmissionDatetime == null) || (this.SubmissionDatetime?.Equals(other.SubmissionDatetime) == true)) &&
                ((this.TransactionStartDatetime == null && other.TransactionStartDatetime == null) || (this.TransactionStartDatetime?.Equals(other.TransactionStartDatetime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClearingSystem = {(this.ClearingSystem == null ? "null" : this.ClearingSystem)}");
            toStringOutput.Add($"this.FileIdentifier = {(this.FileIdentifier == null ? "null" : this.FileIdentifier)}");
            toStringOutput.Add($"this.FileNumber = {(this.FileNumber == null ? "null" : this.FileNumber)}");
            toStringOutput.Add($"this.LimitBreachEndDatetime = {(this.LimitBreachEndDatetime == null ? "null" : this.LimitBreachEndDatetime.ToString())}");
            toStringOutput.Add($"this.LimitBreachStartDatetime = {(this.LimitBreachStartDatetime == null ? "null" : this.LimitBreachStartDatetime.ToString())}");
            toStringOutput.Add($"this.RedirectedAccountNumber = {(this.RedirectedAccountNumber == null ? "null" : this.RedirectedAccountNumber)}");
            toStringOutput.Add($"this.RedirectedBankId = {(this.RedirectedBankId == null ? "null" : this.RedirectedBankId)}");
            toStringOutput.Add($"this.Route = {(this.Route == null ? "null" : this.Route.ToString())}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.SettlementCycle = {(this.SettlementCycle == null ? "null" : this.SettlementCycle.ToString())}");
            toStringOutput.Add($"this.SettlementDate = {(this.SettlementDate == null ? "null" : this.SettlementDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
            toStringOutput.Add($"this.TransactionStartDatetime = {(this.TransactionStartDatetime == null ? "null" : this.TransactionStartDatetime.ToString())}");
        }
    }
}