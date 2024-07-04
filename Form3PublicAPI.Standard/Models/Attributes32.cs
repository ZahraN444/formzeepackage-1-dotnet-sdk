// <copyright file="Attributes32.cs" company="APIMatic">
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
    /// Attributes32.
    /// </summary>
    public class Attributes32
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes32"/> class.
        /// </summary>
        public Attributes32()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes32"/> class.
        /// </summary>
        /// <param name="admissionDatetime">admission_datetime.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="settlementCycle">settlement_cycle.</param>
        /// <param name="settlementDate">settlement_date.</param>
        /// <param name="status">status.</param>
        public Attributes32(
            DateTime? admissionDatetime = null,
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            int? settlementCycle = null,
            DateTime? settlementDate = null,
            Models.DirectDebitReturnAdmissionStatusEnum? status = null)
        {
            this.AdmissionDatetime = admissionDatetime;
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.SettlementCycle = settlementCycle;
            this.SettlementDate = settlementDate;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets AdmissionDatetime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("admission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdmissionDatetime { get; set; }

        /// <summary>
        /// Gets or sets SchemeStatusCode.
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// Gets or sets SchemeStatusCodeDescription.
        /// </summary>
        [JsonProperty("scheme_status_code_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCodeDescription { get; set; }

        /// <summary>
        /// Gets or sets SettlementCycle.
        /// </summary>
        [JsonProperty("settlement_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? SettlementCycle { get; set; }

        /// <summary>
        /// Gets or sets SettlementDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnAdmissionStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes32 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes32 other &&                ((this.AdmissionDatetime == null && other.AdmissionDatetime == null) || (this.AdmissionDatetime?.Equals(other.AdmissionDatetime) == true)) &&
                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true)) &&
                ((this.SettlementCycle == null && other.SettlementCycle == null) || (this.SettlementCycle?.Equals(other.SettlementCycle) == true)) &&
                ((this.SettlementDate == null && other.SettlementDate == null) || (this.SettlementDate?.Equals(other.SettlementDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdmissionDatetime = {(this.AdmissionDatetime == null ? "null" : this.AdmissionDatetime.ToString())}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.SettlementCycle = {(this.SettlementCycle == null ? "null" : this.SettlementCycle.ToString())}");
            toStringOutput.Add($"this.SettlementDate = {(this.SettlementDate == null ? "null" : this.SettlementDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}