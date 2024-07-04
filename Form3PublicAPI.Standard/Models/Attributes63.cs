// <copyright file="Attributes63.cs" company="APIMatic">
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
    /// Attributes63.
    /// </summary>
    public class Attributes63
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes63"/> class.
        /// </summary>
        public Attributes63()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes63"/> class.
        /// </summary>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        public Attributes63(
            string schemeStatusCode = null,
            string schemeStatusCodeDescription = null)
        {
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
        }

        /// <summary>
        /// Scheme-specific status code. Refer to individual scheme where applicable
        /// </summary>
        [JsonProperty("scheme_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// [Description](http://draft-api-docs.form3.tech/api.html#enumerations-scheme-status-codes-for-bacs) of scheme_status_code
        /// </summary>
        [JsonProperty("scheme_status_code_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeStatusCodeDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes63 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes63 other &&                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
        }
    }
}