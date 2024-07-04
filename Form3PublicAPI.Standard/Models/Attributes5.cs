// <copyright file="Attributes5.cs" company="APIMatic">
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
    /// Attributes5.
    /// </summary>
    public class Attributes5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes5"/> class.
        /// </summary>
        public Attributes5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes5"/> class.
        /// </summary>
        /// <param name="admissionDatetime">admission_datetime.</param>
        /// <param name="clearingSystem">clearing_system.</param>
        /// <param name="route">route.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="settlementCycle">settlement_cycle.</param>
        /// <param name="settlementDate">settlement_date.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        public Attributes5(
            DateTime? admissionDatetime = null,
            string clearingSystem = null,
            Models.RouteEnum? route = null,
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            int? settlementCycle = null,
            DateTime? settlementDate = null,
            Models.PaymentAdmissionStatusEnum? status = null,
            Models.PaymentAdmissionStatusReasonEnum? statusReason = null)
        {
            this.AdmissionDatetime = admissionDatetime;
            this.ClearingSystem = clearingSystem;
            this.Route = route;
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.SettlementCycle = settlementCycle;
            this.SettlementDate = settlementDate;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Date and time the payment admission was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("admission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdmissionDatetime { get; set; }

        /// <summary>
        /// Clearing infrastructure through which the payment instruction was processed
        /// </summary>
        [JsonProperty("clearing_system", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingSystem { get; set; }

        /// <summary>
        /// Route taken for an outbound payment
        /// </summary>
        [JsonProperty("route", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RouteEnum? Route { get; set; }

        /// <summary>
        /// Refers to individual scheme where applicable
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
        /// Date on which the payment will be settled
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// [Status of the admission](https://api-docs.form3.tech/api.html#enumerations-payment-status-codes-admission-status)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// [Payment admission status reason](https://api-docs.form3.tech/api.html#enumerations-payment-status-codes-payment-admission-status-reasons)
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdmissionStatusReasonEnum? StatusReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes5 other &&                ((this.AdmissionDatetime == null && other.AdmissionDatetime == null) || (this.AdmissionDatetime?.Equals(other.AdmissionDatetime) == true)) &&
                ((this.ClearingSystem == null && other.ClearingSystem == null) || (this.ClearingSystem?.Equals(other.ClearingSystem) == true)) &&
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
            toStringOutput.Add($"this.AdmissionDatetime = {(this.AdmissionDatetime == null ? "null" : this.AdmissionDatetime.ToString())}");
            toStringOutput.Add($"this.ClearingSystem = {(this.ClearingSystem == null ? "null" : this.ClearingSystem)}");
            toStringOutput.Add($"this.Route = {(this.Route == null ? "null" : this.Route.ToString())}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.SettlementCycle = {(this.SettlementCycle == null ? "null" : this.SettlementCycle.ToString())}");
            toStringOutput.Add($"this.SettlementDate = {(this.SettlementDate == null ? "null" : this.SettlementDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason.ToString())}");
        }
    }
}