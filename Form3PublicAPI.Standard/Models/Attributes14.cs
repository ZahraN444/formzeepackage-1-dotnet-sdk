// <copyright file="Attributes14.cs" company="APIMatic">
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
    /// Attributes14.
    /// </summary>
    public class Attributes14
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes14"/> class.
        /// </summary>
        public Attributes14()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes14"/> class.
        /// </summary>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        /// <param name="sourceGateway">source_gateway.</param>
        /// <param name="status">status.</param>
        public Attributes14(
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null,
            string sourceGateway = null,
            Models.ReversalAdmissionStatusEnum? status = null)
        {
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
            this.SourceGateway = sourceGateway;
            this.Status = status;
        }

        /// <summary>
        /// Scheme-specific status code. Refer to scheme documentation where available.
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// Description of `scheme_status_code`
        /// </summary>
        [JsonProperty("scheme_status_code_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCodeDescription { get; set; }

        /// <summary>
        /// Gets or sets SourceGateway.
        /// </summary>
        [JsonProperty("source_gateway", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceGateway { get; set; }

        /// <summary>
        /// Status of the reversal admission
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReversalAdmissionStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes14 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes14 other &&                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true)) &&
                ((this.SourceGateway == null && other.SourceGateway == null) || (this.SourceGateway?.Equals(other.SourceGateway) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
            toStringOutput.Add($"this.SourceGateway = {(this.SourceGateway == null ? "null" : this.SourceGateway)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}