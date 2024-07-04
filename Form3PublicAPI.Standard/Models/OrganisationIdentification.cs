// <copyright file="OrganisationIdentification.cs" company="APIMatic">
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
    /// OrganisationIdentification.
    /// </summary>
    public class OrganisationIdentification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationIdentification"/> class.
        /// </summary>
        public OrganisationIdentification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationIdentification"/> class.
        /// </summary>
        /// <param name="identification">identification.</param>
        /// <param name="identificationCode">identification_code.</param>
        /// <param name="identificationIssuer">identification_issuer.</param>
        public OrganisationIdentification(
            string identification = null,
            string identificationCode = null,
            string identificationIssuer = null)
        {
            this.Identification = identification;
            this.IdentificationCode = identificationCode;
            this.IdentificationIssuer = identificationIssuer;
        }

        /// <summary>
        /// Gets or sets Identification.
        /// </summary>
        [JsonProperty("identification", NullValueHandling = NullValueHandling.Ignore)]
        public string Identification { get; set; }

        /// <summary>
        /// Gets or sets IdentificationCode.
        /// </summary>
        [JsonProperty("identification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets IdentificationIssuer.
        /// </summary>
        [JsonProperty("identification_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationIssuer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrganisationIdentification : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrganisationIdentification other &&                ((this.Identification == null && other.Identification == null) || (this.Identification?.Equals(other.Identification) == true)) &&
                ((this.IdentificationCode == null && other.IdentificationCode == null) || (this.IdentificationCode?.Equals(other.IdentificationCode) == true)) &&
                ((this.IdentificationIssuer == null && other.IdentificationIssuer == null) || (this.IdentificationIssuer?.Equals(other.IdentificationIssuer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identification = {(this.Identification == null ? "null" : this.Identification)}");
            toStringOutput.Add($"this.IdentificationCode = {(this.IdentificationCode == null ? "null" : this.IdentificationCode)}");
            toStringOutput.Add($"this.IdentificationIssuer = {(this.IdentificationIssuer == null ? "null" : this.IdentificationIssuer)}");
        }
    }
}