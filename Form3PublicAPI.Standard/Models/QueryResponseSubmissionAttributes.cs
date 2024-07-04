// <copyright file="QueryResponseSubmissionAttributes.cs" company="APIMatic">
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
    /// QueryResponseSubmissionAttributes.
    /// </summary>
    public class QueryResponseSubmissionAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseSubmissionAttributes"/> class.
        /// </summary>
        public QueryResponseSubmissionAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseSubmissionAttributes"/> class.
        /// </summary>
        /// <param name="auto">auto.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        public QueryResponseSubmissionAttributes(
            bool? auto = null,
            Models.QueryResponseSubmissionStatusEnum? status = null,
            string statusReason = null)
        {
            this.Auto = auto;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Gets or sets Auto.
        /// </summary>
        [JsonProperty("auto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryResponseSubmissionStatusEnum? Status { get; set; }

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

            return $"QueryResponseSubmissionAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseSubmissionAttributes other &&                ((this.Auto == null && other.Auto == null) || (this.Auto?.Equals(other.Auto) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Auto = {(this.Auto == null ? "null" : this.Auto.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
        }
    }
}