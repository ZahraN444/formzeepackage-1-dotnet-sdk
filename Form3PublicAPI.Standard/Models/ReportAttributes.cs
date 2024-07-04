// <copyright file="ReportAttributes.cs" company="APIMatic">
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
    /// ReportAttributes.
    /// </summary>
    public class ReportAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAttributes"/> class.
        /// </summary>
        public ReportAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAttributes"/> class.
        /// </summary>
        /// <param name="formats">formats.</param>
        /// <param name="generationTime">generation_time.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="reportSource">report_source.</param>
        /// <param name="reportType">report_type.</param>
        /// <param name="reportTypeDescription">report_type_description.</param>
        /// <param name="reportUsers">report_users.</param>
        public ReportAttributes(
            List<string> formats = null,
            DateTime? generationTime = null,
            DateTime? processingDate = null,
            string reportSource = null,
            string reportType = null,
            string reportTypeDescription = null,
            List<Models.ReportUser> reportUsers = null)
        {
            this.Formats = formats;
            this.GenerationTime = generationTime;
            this.ProcessingDate = processingDate;
            this.ReportSource = reportSource;
            this.ReportType = reportType;
            this.ReportTypeDescription = reportTypeDescription;
            this.ReportUsers = reportUsers;
        }

        /// <summary>
        /// Gets or sets Formats.
        /// </summary>
        [JsonProperty("formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// Gets or sets GenerationTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("generation_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? GenerationTime { get; set; }

        /// <summary>
        /// Gets or sets ProcessingDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets ReportSource.
        /// </summary>
        [JsonProperty("report_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportSource { get; set; }

        /// <summary>
        /// Type of report.
        /// </summary>
        [JsonProperty("report_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportType { get; set; }

        /// <summary>
        /// Gets or sets ReportTypeDescription.
        /// </summary>
        [JsonProperty("report_type_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportTypeDescription { get; set; }

        /// <summary>
        /// Users or organisations this report was generated for
        /// </summary>
        [JsonProperty("report_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReportUser> ReportUsers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportAttributes other &&                ((this.Formats == null && other.Formats == null) || (this.Formats?.Equals(other.Formats) == true)) &&
                ((this.GenerationTime == null && other.GenerationTime == null) || (this.GenerationTime?.Equals(other.GenerationTime) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.ReportSource == null && other.ReportSource == null) || (this.ReportSource?.Equals(other.ReportSource) == true)) &&
                ((this.ReportType == null && other.ReportType == null) || (this.ReportType?.Equals(other.ReportType) == true)) &&
                ((this.ReportTypeDescription == null && other.ReportTypeDescription == null) || (this.ReportTypeDescription?.Equals(other.ReportTypeDescription) == true)) &&
                ((this.ReportUsers == null && other.ReportUsers == null) || (this.ReportUsers?.Equals(other.ReportUsers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Formats = {(this.Formats == null ? "null" : $"[{string.Join(", ", this.Formats)} ]")}");
            toStringOutput.Add($"this.GenerationTime = {(this.GenerationTime == null ? "null" : this.GenerationTime.ToString())}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.ReportSource = {(this.ReportSource == null ? "null" : this.ReportSource)}");
            toStringOutput.Add($"this.ReportType = {(this.ReportType == null ? "null" : this.ReportType)}");
            toStringOutput.Add($"this.ReportTypeDescription = {(this.ReportTypeDescription == null ? "null" : this.ReportTypeDescription)}");
            toStringOutput.Add($"this.ReportUsers = {(this.ReportUsers == null ? "null" : $"[{string.Join(", ", this.ReportUsers)} ]")}");
        }
    }
}