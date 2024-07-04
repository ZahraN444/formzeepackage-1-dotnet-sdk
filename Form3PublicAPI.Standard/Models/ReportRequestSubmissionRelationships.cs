// <copyright file="ReportRequestSubmissionRelationships.cs" company="APIMatic">
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
    /// ReportRequestSubmissionRelationships.
    /// </summary>
    public class ReportRequestSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestSubmissionRelationships"/> class.
        /// </summary>
        public ReportRequestSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="reportRequest">report_request.</param>
        public ReportRequestSubmissionRelationships(
            Models.ReportRequest3 reportRequest = null)
        {
            this.ReportRequest = reportRequest;
        }

        /// <summary>
        /// Gets or sets ReportRequest.
        /// </summary>
        [JsonProperty("report_request", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportRequest3 ReportRequest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRequestSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRequestSubmissionRelationships other &&                ((this.ReportRequest == null && other.ReportRequest == null) || (this.ReportRequest?.Equals(other.ReportRequest) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReportRequest = {(this.ReportRequest == null ? "null" : this.ReportRequest.ToString())}");
        }
    }
}