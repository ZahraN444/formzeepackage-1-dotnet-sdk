// <copyright file="ReportAdmissionRelationships.cs" company="APIMatic">
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
    /// ReportAdmissionRelationships.
    /// </summary>
    public class ReportAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAdmissionRelationships"/> class.
        /// </summary>
        public ReportAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="report">report.</param>
        public ReportAdmissionRelationships(
            Models.Report1 report = null)
        {
            this.Report = report;
        }

        /// <summary>
        /// Gets or sets Report.
        /// </summary>
        [JsonProperty("report", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Report1 Report { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportAdmissionRelationships other &&                ((this.Report == null && other.Report == null) || (this.Report?.Equals(other.Report) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Report = {(this.Report == null ? "null" : this.Report.ToString())}");
        }
    }
}