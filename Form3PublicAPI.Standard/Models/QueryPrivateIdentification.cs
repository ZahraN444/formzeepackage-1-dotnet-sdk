// <copyright file="QueryPrivateIdentification.cs" company="APIMatic">
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
    /// QueryPrivateIdentification.
    /// </summary>
    public class QueryPrivateIdentification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPrivateIdentification"/> class.
        /// </summary>
        public QueryPrivateIdentification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPrivateIdentification"/> class.
        /// </summary>
        /// <param name="identification">identification.</param>
        /// <param name="identificationIssuer">identification_issuer.</param>
        /// <param name="identificationScheme">identification_scheme.</param>
        /// <param name="identificationSchemeCode">identification_scheme_code.</param>
        public QueryPrivateIdentification(
            string identification = null,
            string identificationIssuer = null,
            string identificationScheme = null,
            string identificationSchemeCode = null)
        {
            this.Identification = identification;
            this.IdentificationIssuer = identificationIssuer;
            this.IdentificationScheme = identificationScheme;
            this.IdentificationSchemeCode = identificationSchemeCode;
        }

        /// <summary>
        /// Private Identification of an debtor/beneficiary or ultimate debtor/beneficiary
        /// </summary>
        [JsonProperty("identification", NullValueHandling = NullValueHandling.Ignore)]
        public string Identification { get; set; }

        /// <summary>
        /// Issuer of the `identification`
        /// </summary>
        [JsonProperty("identification_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationIssuer { get; set; }

        /// <summary>
        /// Scheme of the `identification`
        /// </summary>
        [JsonProperty("identification_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationScheme { get; set; }

        /// <summary>
        /// The code that specifies the type of `identification`
        /// </summary>
        [JsonProperty("identification_scheme_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationSchemeCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryPrivateIdentification : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryPrivateIdentification other &&                ((this.Identification == null && other.Identification == null) || (this.Identification?.Equals(other.Identification) == true)) &&
                ((this.IdentificationIssuer == null && other.IdentificationIssuer == null) || (this.IdentificationIssuer?.Equals(other.IdentificationIssuer) == true)) &&
                ((this.IdentificationScheme == null && other.IdentificationScheme == null) || (this.IdentificationScheme?.Equals(other.IdentificationScheme) == true)) &&
                ((this.IdentificationSchemeCode == null && other.IdentificationSchemeCode == null) || (this.IdentificationSchemeCode?.Equals(other.IdentificationSchemeCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identification = {(this.Identification == null ? "null" : this.Identification)}");
            toStringOutput.Add($"this.IdentificationIssuer = {(this.IdentificationIssuer == null ? "null" : this.IdentificationIssuer)}");
            toStringOutput.Add($"this.IdentificationScheme = {(this.IdentificationScheme == null ? "null" : this.IdentificationScheme)}");
            toStringOutput.Add($"this.IdentificationSchemeCode = {(this.IdentificationSchemeCode == null ? "null" : this.IdentificationSchemeCode)}");
        }
    }
}