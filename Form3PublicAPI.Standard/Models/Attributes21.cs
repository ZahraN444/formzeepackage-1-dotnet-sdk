// <copyright file="Attributes21.cs" company="APIMatic">
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
    /// Attributes21.
    /// </summary>
    public class Attributes21
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes21"/> class.
        /// </summary>
        public Attributes21()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes21"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="submissionDatetime">submission_datetime.</param>
        public Attributes21(
            Models.ClaimSubmissionStatusEnum? status = null,
            string statusReason = null,
            DateTime? submissionDatetime = null)
        {
            this.Status = status;
            this.StatusReason = statusReason;
            this.SubmissionDatetime = submissionDatetime;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimSubmissionStatusEnum? Status { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes21 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes21 other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.SubmissionDatetime == null && other.SubmissionDatetime == null) || (this.SubmissionDatetime?.Equals(other.SubmissionDatetime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
            toStringOutput.Add($"this.SubmissionDatetime = {(this.SubmissionDatetime == null ? "null" : this.SubmissionDatetime.ToString())}");
        }
    }
}