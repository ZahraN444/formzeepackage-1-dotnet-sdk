// <copyright file="Attributes41.cs" company="APIMatic">
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
    /// Attributes41.
    /// </summary>
    public class Attributes41
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes41"/> class.
        /// </summary>
        public Attributes41()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes41"/> class.
        /// </summary>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        public Attributes41(
            DateTime? startDatetime = null,
            Models.SchemeFileSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null)
        {
            this.StartDatetime = startDatetime;
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
        }

        /// <summary>
        /// Time the submission request was received by Form3. Used to compute the total processing time
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDatetime { get; set; }

        /// <summary>
        /// Status of the scheme file submission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeFileSubmissionStatusEnum? Status { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes41 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes41 other &&                ((this.StartDatetime == null && other.StartDatetime == null) || (this.StartDatetime?.Equals(other.StartDatetime) == true)) &&
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
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
        }
    }
}