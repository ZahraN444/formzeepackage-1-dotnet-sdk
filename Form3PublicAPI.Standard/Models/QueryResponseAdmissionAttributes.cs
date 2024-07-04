// <copyright file="QueryResponseAdmissionAttributes.cs" company="APIMatic">
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
    /// QueryResponseAdmissionAttributes.
    /// </summary>
    public class QueryResponseAdmissionAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseAdmissionAttributes"/> class.
        /// </summary>
        public QueryResponseAdmissionAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseAdmissionAttributes"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        public QueryResponseAdmissionAttributes(
            Models.QueryResponseAdmissionStatusEnum status,
            string statusReason = null)
        {
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.QueryResponseAdmissionStatusEnum Status { get; set; }

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

            return $"QueryResponseAdmissionAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseAdmissionAttributes other &&                this.Status.Equals(other.Status) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
        }
    }
}