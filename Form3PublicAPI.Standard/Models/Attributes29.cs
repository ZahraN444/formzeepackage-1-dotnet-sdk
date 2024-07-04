// <copyright file="Attributes29.cs" company="APIMatic">
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
    /// Attributes29.
    /// </summary>
    public class Attributes29
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes29"/> class.
        /// </summary>
        public Attributes29()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes29"/> class.
        /// </summary>
        /// <param name="admissionDatetime">admission_datetime.</param>
        /// <param name="sourceGateway">source_gateway.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        public Attributes29(
            DateTime? admissionDatetime = null,
            string sourceGateway = null,
            Models.DirectDebitRecallAdmissionStatusEnum? status = null,
            string statusReason = null)
        {
            this.AdmissionDatetime = admissionDatetime;
            this.SourceGateway = sourceGateway;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Date and time the recall admission was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("admission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdmissionDatetime { get; set; }

        /// <summary>
        /// Gets or sets SourceGateway.
        /// </summary>
        [JsonProperty("source_gateway", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceGateway { get; set; }

        /// <summary>
        /// [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-admission-status) of the recall admission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitRecallAdmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Human-readable reason for failure if admission status is failed
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes29 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes29 other &&                ((this.AdmissionDatetime == null && other.AdmissionDatetime == null) || (this.AdmissionDatetime?.Equals(other.AdmissionDatetime) == true)) &&
                ((this.SourceGateway == null && other.SourceGateway == null) || (this.SourceGateway?.Equals(other.SourceGateway) == true)) &&
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
            toStringOutput.Add($"this.SourceGateway = {(this.SourceGateway == null ? "null" : this.SourceGateway)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
        }
    }
}