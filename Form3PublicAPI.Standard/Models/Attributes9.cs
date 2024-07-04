// <copyright file="Attributes9.cs" company="APIMatic">
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
    /// Attributes9.
    /// </summary>
    public class Attributes9
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes9"/> class.
        /// </summary>
        public Attributes9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes9"/> class.
        /// </summary>
        /// <param name="admissionDatetime">admission_datetime.</param>
        /// <param name="route">route.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="settlementCycle">settlement_cycle.</param>
        /// <param name="settlementDate">settlement_date.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        public Attributes9(
            DateTime? admissionDatetime = null,
            Models.Route1Enum? route = null,
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            int? settlementCycle = null,
            DateTime? settlementDate = null,
            Models.ReturnAdmissionStatusEnum? status = null,
            string statusReason = null,
            string uniqueSchemeId = null)
        {
            this.AdmissionDatetime = admissionDatetime;
            this.Route = route;
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.SettlementCycle = settlementCycle;
            this.SettlementDate = settlementDate;
            this.Status = status;
            this.StatusReason = statusReason;
            this.UniqueSchemeId = uniqueSchemeId;
        }

        /// <summary>
        /// Date and time the payment admission was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("admission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdmissionDatetime { get; set; }

        /// <summary>
        /// Route taken for a return
        /// </summary>
        [JsonProperty("route", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Route1Enum? Route { get; set; }

        /// <summary>
        /// Refer to individual scheme where applicable
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
        /// [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-admission-status) of the return admission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnAdmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Further explanation of the status. [See here](http://api-docs.form3.tech/api.html#enumerations-payment-admission-status-reasons) for possible values.
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Scheme-specific unique ID (42 character string)
        /// </summary>
        [JsonProperty("unique_scheme_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSchemeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes9 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes9 other &&                ((this.AdmissionDatetime == null && other.AdmissionDatetime == null) || (this.AdmissionDatetime?.Equals(other.AdmissionDatetime) == true)) &&
                ((this.Route == null && other.Route == null) || (this.Route?.Equals(other.Route) == true)) &&
                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true)) &&
                ((this.SettlementCycle == null && other.SettlementCycle == null) || (this.SettlementCycle?.Equals(other.SettlementCycle) == true)) &&
                ((this.SettlementDate == null && other.SettlementDate == null) || (this.SettlementDate?.Equals(other.SettlementDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdmissionDatetime = {(this.AdmissionDatetime == null ? "null" : this.AdmissionDatetime.ToString())}");
            toStringOutput.Add($"this.Route = {(this.Route == null ? "null" : this.Route.ToString())}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.SettlementCycle = {(this.SettlementCycle == null ? "null" : this.SettlementCycle.ToString())}");
            toStringOutput.Add($"this.SettlementDate = {(this.SettlementDate == null ? "null" : this.SettlementDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
        }
    }
}