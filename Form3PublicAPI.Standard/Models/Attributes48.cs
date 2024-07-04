// <copyright file="Attributes48.cs" company="APIMatic">
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
    /// Attributes48.
    /// </summary>
    public class Attributes48
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes48"/> class.
        /// </summary>
        public Attributes48()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes48"/> class.
        /// </summary>
        /// <param name="fileIdentifier">file_identifier.</param>
        /// <param name="fileNumber">file_number.</param>
        /// <param name="lastPaymentDate">last_payment_date.</param>
        /// <param name="originalMandate">original_mandate.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        /// <param name="submissionReason">submission_reason.</param>
        /// <param name="submittedMandate">submitted_mandate.</param>
        public Attributes48(
            string fileIdentifier = null,
            string fileNumber = null,
            DateTime? lastPaymentDate = null,
            Models.MandateAttributes originalMandate = null,
            Models.MandateSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null,
            string submissionReason = null,
            Models.MandateAttributes submittedMandate = null)
        {
            this.FileIdentifier = fileIdentifier;
            this.FileNumber = fileNumber;
            this.LastPaymentDate = lastPaymentDate;
            this.OriginalMandate = originalMandate;
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
            this.SubmissionReason = submissionReason;
            this.SubmittedMandate = submittedMandate;
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
        /// Gets or sets LastPaymentDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("last_payment_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastPaymentDate { get; set; }

        /// <summary>
        /// Gets or sets OriginalMandate.
        /// </summary>
        [JsonProperty("original_mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateAttributes OriginalMandate { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateSubmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets StatusReason.
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Gets or sets SubmissionDatetime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("submission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SubmissionDatetime { get; set; }

        /// <summary>
        /// Gets or sets SubmissionReason.
        /// </summary>
        [JsonProperty("submission_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmissionReason { get; set; }

        /// <summary>
        /// Gets or sets SubmittedMandate.
        /// </summary>
        [JsonProperty("submitted_mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateAttributes SubmittedMandate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes48 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes48 other &&                ((this.FileIdentifier == null && other.FileIdentifier == null) || (this.FileIdentifier?.Equals(other.FileIdentifier) == true)) &&
                ((this.FileNumber == null && other.FileNumber == null) || (this.FileNumber?.Equals(other.FileNumber) == true)) &&
                ((this.LastPaymentDate == null && other.LastPaymentDate == null) || (this.LastPaymentDate?.Equals(other.LastPaymentDate) == true)) &&
                ((this.OriginalMandate == null && other.OriginalMandate == null) || (this.OriginalMandate?.Equals(other.OriginalMandate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.SubmissionDatetime == null && other.SubmissionDatetime == null) || (this.SubmissionDatetime?.Equals(other.SubmissionDatetime) == true)) &&
                ((this.SubmissionReason == null && other.SubmissionReason == null) || (this.SubmissionReason?.Equals(other.SubmissionReason) == true)) &&
                ((this.SubmittedMandate == null && other.SubmittedMandate == null) || (this.SubmittedMandate?.Equals(other.SubmittedMandate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FileIdentifier = {(this.FileIdentifier == null ? "null" : this.FileIdentifier)}");
            toStringOutput.Add($"this.FileNumber = {(this.FileNumber == null ? "null" : this.FileNumber)}");
            toStringOutput.Add($"this.LastPaymentDate = {(this.LastPaymentDate == null ? "null" : this.LastPaymentDate.ToString())}");
            toStringOutput.Add($"this.OriginalMandate = {(this.OriginalMandate == null ? "null" : this.OriginalMandate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
            toStringOutput.Add($"this.SubmissionReason = {(this.SubmissionReason == null ? "null" : this.SubmissionReason)}");
            toStringOutput.Add($"this.SubmittedMandate = {(this.SubmittedMandate == null ? "null" : this.SubmittedMandate.ToString())}");
        }
    }
}