// <copyright file="Attributes44.cs" company="APIMatic">
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
    /// Attributes44.
    /// </summary>
    public class Attributes44
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes44"/> class.
        /// </summary>
        public Attributes44()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes44"/> class.
        /// </summary>
        /// <param name="schemeReferences">scheme_references.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        /// <param name="transactionStartDatetime">transaction_start_datetime.</param>
        public Attributes44(
            List<Models.TransactionFileSubmissionSchemeReference> schemeReferences = null,
            Models.TransactionFileSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null,
            DateTime? transactionStartDatetime = null)
        {
            this.SchemeReferences = schemeReferences;
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
            this.TransactionStartDatetime = transactionStartDatetime;
        }

        /// <summary>
        /// Summary of scheme-specific references submission to the scheme
        /// </summary>
        [JsonProperty("scheme_references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TransactionFileSubmissionSchemeReference> SchemeReferences { get; set; }

        /// <summary>
        /// Status of the transaction file submission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFileSubmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Plain-text description of the status attribute
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Time when the Form3 system begins processing of the submission
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("submission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SubmissionDatetime { get; set; }

        /// <summary>
        /// Time the submission request was received by Form3. Used to compute the total transaction time
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TransactionStartDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes44 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes44 other &&                ((this.SchemeReferences == null && other.SchemeReferences == null) || (this.SchemeReferences?.Equals(other.SchemeReferences) == true)) &&
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
            toStringOutput.Add($"this.SchemeReferences = {(this.SchemeReferences == null ? "null" : $"[{string.Join(", ", this.SchemeReferences)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
            toStringOutput.Add($"this.TransactionStartDatetime = {(this.TransactionStartDatetime == null ? "null" : this.TransactionStartDatetime.ToString())}");
        }
    }
}