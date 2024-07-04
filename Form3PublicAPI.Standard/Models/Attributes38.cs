// <copyright file="Attributes38.cs" company="APIMatic">
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
    /// Attributes38.
    /// </summary>
    public class Attributes38
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes38"/> class.
        /// </summary>
        public Attributes38()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes38"/> class.
        /// </summary>
        /// <param name="fileIdentifier">file_identifier.</param>
        /// <param name="fileNumber">file_number.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        /// <param name="transactionStartDatetime">transaction_start_datetime.</param>
        public Attributes38(
            string fileIdentifier = null,
            string fileNumber = null,
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            Models.DirectDebitSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null,
            DateTime? transactionStartDatetime = null)
        {
            this.FileIdentifier = fileIdentifier;
            this.FileNumber = fileNumber;
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
            this.TransactionStartDatetime = transactionStartDatetime;
        }

        /// <summary>
        /// Gets or sets FileIdentifier.
        /// </summary>
        [JsonProperty("file_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string FileIdentifier { get; set; }

        /// <summary>
        /// Gets or sets FileNumber.
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNumber { get; set; }

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
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitSubmissionStatusEnum? Status { get; set; }

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
        /// Time the request was received by Form3. Used to compute the total transaction time of an operation.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TransactionStartDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes38 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes38 other &&                ((this.FileIdentifier == null && other.FileIdentifier == null) || (this.FileIdentifier?.Equals(other.FileIdentifier) == true)) &&
                ((this.FileNumber == null && other.FileNumber == null) || (this.FileNumber?.Equals(other.FileNumber) == true)) &&
                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true)) &&
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
            toStringOutput.Add($"this.FileIdentifier = {(this.FileIdentifier == null ? "null" : this.FileIdentifier)}");
            toStringOutput.Add($"this.FileNumber = {(this.FileNumber == null ? "null" : this.FileNumber)}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
            toStringOutput.Add($"this.TransactionStartDatetime = {(this.TransactionStartDatetime == null ? "null" : this.TransactionStartDatetime.ToString())}");
        }
    }
}