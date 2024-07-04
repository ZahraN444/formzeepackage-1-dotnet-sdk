// <copyright file="ReportRequestSubmissionAttributes.cs" company="APIMatic">
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
    /// ReportRequestSubmissionAttributes.
    /// </summary>
    public class ReportRequestSubmissionAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestSubmissionAttributes"/> class.
        /// </summary>
        public ReportRequestSubmissionAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestSubmissionAttributes"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="statusReason">status_reason.</param>
        public ReportRequestSubmissionAttributes(
            Models.ReportRequestSubmissionStatusEnum status,
            string schemeStatusCode = null,
            string statusReason = null)
        {
            this.SchemeStatusCode = schemeStatusCode;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Gets or sets SchemeStatusCode.
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.ReportRequestSubmissionStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets StatusReason.
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRequestSubmissionAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRequestSubmissionAttributes other &&                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                this.Status.Equals(other.Status) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
        }
    }
}