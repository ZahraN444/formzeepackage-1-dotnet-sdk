// <copyright file="ReportRequestRelationships.cs" company="APIMatic">
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
    /// ReportRequestRelationships.
    /// </summary>
    public class ReportRequestRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestRelationships"/> class.
        /// </summary>
        public ReportRequestRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestRelationships"/> class.
        /// </summary>
        /// <param name="report">report.</param>
        /// <param name="reportRequestSubmission">report_request_submission.</param>
        public ReportRequestRelationships(
            Models.Report1 report = null,
            Models.ReportRequestSubmission2 reportRequestSubmission = null)
        {
            this.Report = report;
            this.ReportRequestSubmission = reportRequestSubmission;
        }

        /// <summary>
        /// Gets or sets Report.
        /// </summary>
        [JsonProperty("report", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Report1 Report { get; set; }

        /// <summary>
        /// Gets or sets ReportRequestSubmission.
        /// </summary>
        [JsonProperty("report_request_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportRequestSubmission2 ReportRequestSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRequestRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRequestRelationships other &&                ((this.Report == null && other.Report == null) || (this.Report?.Equals(other.Report) == true)) &&
                ((this.ReportRequestSubmission == null && other.ReportRequestSubmission == null) || (this.ReportRequestSubmission?.Equals(other.ReportRequestSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Report = {(this.Report == null ? "null" : this.Report.ToString())}");
            toStringOutput.Add($"this.ReportRequestSubmission = {(this.ReportRequestSubmission == null ? "null" : this.ReportRequestSubmission.ToString())}");
        }
    }
}