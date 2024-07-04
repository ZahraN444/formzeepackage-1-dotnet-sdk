// <copyright file="PrometheusResultItem.cs" company="APIMatic">
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
    /// PrometheusResultItem.
    /// </summary>
    public class PrometheusResultItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrometheusResultItem"/> class.
        /// </summary>
        public PrometheusResultItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrometheusResultItem"/> class.
        /// </summary>
        /// <param name="metric">metric.</param>
        /// <param name="mValue">value.</param>
        public PrometheusResultItem(
            Dictionary<string, string> metric = null,
            object mValue = null)
        {
            this.Metric = metric;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets Metric.
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metric { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrometheusResultItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrometheusResultItem other &&                ((this.Metric == null && other.Metric == null) || (this.Metric?.Equals(other.Metric) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Metric = {(this.Metric == null ? "null" : this.Metric.ToString())}");
            toStringOutput.Add($"MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
        }
    }
}