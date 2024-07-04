// <copyright file="Attributes43.cs" company="APIMatic">
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
    /// Attributes43.
    /// </summary>
    public class Attributes43
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes43"/> class.
        /// </summary>
        public Attributes43()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes43"/> class.
        /// </summary>
        /// <param name="admissionDatetime">admission_datetime.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="transactionStartDatetime">transaction_start_datetime.</param>
        public Attributes43(
            DateTime? admissionDatetime = null,
            Models.TransactionFileAdmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? transactionStartDatetime = null)
        {
            this.AdmissionDatetime = admissionDatetime;
            this.Status = status;
            this.StatusReason = statusReason;
            this.TransactionStartDatetime = transactionStartDatetime;
        }

        /// <summary>
        /// Time when the Form3 system begins processing of the admission
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("admission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdmissionDatetime { get; set; }

        /// <summary>
        /// Status of the transaction file admission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFileAdmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Plain-text description of the status attribute
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Time the admission request was received by Form3. Used to compute the total transaction time
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TransactionStartDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes43 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes43 other &&                ((this.AdmissionDatetime == null && other.AdmissionDatetime == null) || (this.AdmissionDatetime?.Equals(other.AdmissionDatetime) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.TransactionStartDatetime == null && other.TransactionStartDatetime == null) || (this.TransactionStartDatetime?.Equals(other.TransactionStartDatetime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdmissionDatetime = {(this.AdmissionDatetime == null ? "null" : this.AdmissionDatetime.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.TransactionStartDatetime = {(this.TransactionStartDatetime == null ? "null" : this.TransactionStartDatetime.ToString())}");
        }
    }
}