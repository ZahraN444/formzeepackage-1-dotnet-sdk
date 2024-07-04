// <copyright file="PrometheusMetricData.cs" company="APIMatic">
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
    /// PrometheusMetricData.
    /// </summary>
    public class PrometheusMetricData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrometheusMetricData"/> class.
        /// </summary>
        public PrometheusMetricData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrometheusMetricData"/> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="resultType">resultType.</param>
        public PrometheusMetricData(
            List<Models.PrometheusResultItem> result = null,
            string resultType = null)
        {
            this.Result = result;
            this.ResultType = resultType;
        }

        /// <summary>
        /// Gets or sets Result.
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PrometheusResultItem> Result { get; set; }

        /// <summary>
        /// Gets or sets ResultType.
        /// </summary>
        [JsonProperty("resultType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrometheusMetricData : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrometheusMetricData other &&                ((this.Result == null && other.Result == null) || (this.Result?.Equals(other.Result) == true)) &&
                ((this.ResultType == null && other.ResultType == null) || (this.ResultType?.Equals(other.ResultType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Result = {(this.Result == null ? "null" : $"[{string.Join(", ", this.Result)} ]")}");
            toStringOutput.Add($"this.ResultType = {(this.ResultType == null ? "null" : this.ResultType)}");
        }
    }
}