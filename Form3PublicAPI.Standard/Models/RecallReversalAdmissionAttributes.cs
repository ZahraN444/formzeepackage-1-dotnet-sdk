// <copyright file="RecallReversalAdmissionAttributes.cs" company="APIMatic">
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
    /// RecallReversalAdmissionAttributes.
    /// </summary>
    public class RecallReversalAdmissionAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecallReversalAdmissionAttributes"/> class.
        /// </summary>
        public RecallReversalAdmissionAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecallReversalAdmissionAttributes"/> class.
        /// </summary>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="sourceGateway">source_gateway.</param>
        public RecallReversalAdmissionAttributes(
            string schemeStatusCode = null,
            string sourceGateway = null)
        {
            this.SchemeStatusCode = schemeStatusCode;
            this.SourceGateway = sourceGateway;
        }

        /// <summary>
        /// Scheme-specific status code
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// Gets or sets SourceGateway.
        /// </summary>
        [JsonProperty("source_gateway", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceGateway { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecallReversalAdmissionAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is RecallReversalAdmissionAttributes other &&                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SourceGateway == null && other.SourceGateway == null) || (this.SourceGateway?.Equals(other.SourceGateway) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SourceGateway = {(this.SourceGateway == null ? "null" : this.SourceGateway)}");
        }
    }
}