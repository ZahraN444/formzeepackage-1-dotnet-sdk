// <copyright file="Attributes27.cs" company="APIMatic">
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
    /// Attributes27.
    /// </summary>
    public class Attributes27
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes27"/> class.
        /// </summary>
        public Attributes27()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes27"/> class.
        /// </summary>
        /// <param name="auto">auto.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        public Attributes27(
            bool? auto = false,
            string schemeStatusCode = null,
            Models.DirectDebitDecisionSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null)
        {
            this.Auto = auto;
            this.SchemeStatusCode = schemeStatusCode;
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
        }

        /// <summary>
        /// Indicates if the submission was created automatically by the system (`true`) or manually (`false`).
        /// </summary>
        [JsonProperty("auto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto { get; set; }

        /// <summary>
        /// Scheme-specific status (if submission has been submitted to a scheme)
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDecisionSubmissionStatusEnum? Status { get; set; }

        /// <summary>
        /// Reason for submission failure if status is `delivery_failed`
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Date and time of the submission
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("submission_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SubmissionDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes27 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes27 other &&                ((this.Auto == null && other.Auto == null) || (this.Auto?.Equals(other.Auto) == true)) &&
                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.SubmissionDatetime == null && other.SubmissionDatetime == null) || (this.SubmissionDatetime?.Equals(other.SubmissionDatetime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Auto = {(this.Auto == null ? "null" : this.Auto.ToString())}");
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
        }
    }
}