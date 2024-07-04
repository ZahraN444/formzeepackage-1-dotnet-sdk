// <copyright file="CHAPS.cs" company="APIMatic">
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
    /// CHAPS.
    /// </summary>
    public class CHAPS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CHAPS"/> class.
        /// </summary>
        public CHAPS()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CHAPS"/> class.
        /// </summary>
        /// <param name="acceptsPayments">accepts_payments.</param>
        /// <param name="serviceStatus">service_status.</param>
        public CHAPS(
            bool? acceptsPayments = false,
            string serviceStatus = null)
        {
            this.AcceptsPayments = acceptsPayments;
            this.ServiceStatus = serviceStatus;
        }

        /// <summary>
        /// Gets or sets AcceptsPayments.
        /// </summary>
        [JsonProperty("accepts_payments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AcceptsPayments { get; set; }

        /// <summary>
        /// Gets or sets ServiceStatus.
        /// </summary>
        [JsonProperty("service_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CHAPS : ({string.Join(", ", toStringOutput)})";
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
            return obj is CHAPS other &&                ((this.AcceptsPayments == null && other.AcceptsPayments == null) || (this.AcceptsPayments?.Equals(other.AcceptsPayments) == true)) &&
                ((this.ServiceStatus == null && other.ServiceStatus == null) || (this.ServiceStatus?.Equals(other.ServiceStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcceptsPayments = {(this.AcceptsPayments == null ? "null" : this.AcceptsPayments.ToString())}");
            toStringOutput.Add($"this.ServiceStatus = {(this.ServiceStatus == null ? "null" : this.ServiceStatus)}");
        }
    }
}