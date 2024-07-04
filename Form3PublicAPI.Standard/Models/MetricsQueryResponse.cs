// <copyright file="MetricsQueryResponse.cs" company="APIMatic">
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
    /// MetricsQueryResponse.
    /// </summary>
    public class MetricsQueryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsQueryResponse"/> class.
        /// </summary>
        public MetricsQueryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsQueryResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="error">error.</param>
        /// <param name="errorType">errorType.</param>
        /// <param name="status">status.</param>
        /// <param name="warnings">warnings.</param>
        public MetricsQueryResponse(
            Models.PrometheusMetricData data = null,
            string error = null,
            string errorType = null,
            string status = null,
            List<string> warnings = null)
        {
            this.Data = data;
            this.Error = error;
            this.ErrorType = errorType;
            this.Status = status;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrometheusMetricData Data { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets ErrorType.
        /// </summary>
        [JsonProperty("errorType", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Warnings.
        /// </summary>
        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Warnings { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MetricsQueryResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is MetricsQueryResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.ErrorType == null && other.ErrorType == null) || (this.ErrorType?.Equals(other.ErrorType) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Warnings == null && other.Warnings == null) || (this.Warnings?.Equals(other.Warnings) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error)}");
            toStringOutput.Add($"this.ErrorType = {(this.ErrorType == null ? "null" : this.ErrorType)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Warnings = {(this.Warnings == null ? "null" : $"[{string.Join(", ", this.Warnings)} ]")}");
        }
    }
}