// <copyright file="QueryBeneficiaryDebtorOrganisationIdentification.cs" company="APIMatic">
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
    /// QueryBeneficiaryDebtorOrganisationIdentification.
    /// </summary>
    public class QueryBeneficiaryDebtorOrganisationIdentification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBeneficiaryDebtorOrganisationIdentification"/> class.
        /// </summary>
        public QueryBeneficiaryDebtorOrganisationIdentification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBeneficiaryDebtorOrganisationIdentification"/> class.
        /// </summary>
        /// <param name="identification">identification.</param>
        /// <param name="identificationCode">identification_code.</param>
        /// <param name="identificationIssuer">identification_issuer.</param>
        /// <param name="identificationScheme">identification_scheme.</param>
        public QueryBeneficiaryDebtorOrganisationIdentification(
            string identification = null,
            string identificationCode = null,
            string identificationIssuer = null,
            string identificationScheme = null)
        {
            this.Identification = identification;
            this.IdentificationCode = identificationCode;
            this.IdentificationIssuer = identificationIssuer;
            this.IdentificationScheme = identificationScheme;
        }

        /// <summary>
        /// Another ID of the organisation
        /// </summary>
        [JsonProperty("identification", NullValueHandling = NullValueHandling.Ignore)]
        public string Identification { get; set; }

        /// <summary>
        /// Code for the type of other ID of organisation
        /// </summary>
        [JsonProperty("identification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Issuer of the other ID of organisation
        /// </summary>
        [JsonProperty("identification_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationIssuer { get; set; }

        /// <summary>
        /// Custom internal code for the type of other ID of organisation
        /// </summary>
        [JsonProperty("identification_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationScheme { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryBeneficiaryDebtorOrganisationIdentification : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryBeneficiaryDebtorOrganisationIdentification other &&                ((this.Identification == null && other.Identification == null) || (this.Identification?.Equals(other.Identification) == true)) &&
                ((this.IdentificationCode == null && other.IdentificationCode == null) || (this.IdentificationCode?.Equals(other.IdentificationCode) == true)) &&
                ((this.IdentificationIssuer == null && other.IdentificationIssuer == null) || (this.IdentificationIssuer?.Equals(other.IdentificationIssuer) == true)) &&
                ((this.IdentificationScheme == null && other.IdentificationScheme == null) || (this.IdentificationScheme?.Equals(other.IdentificationScheme) == true));
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
            toStringOutput.Add($"this.IdentificationScheme = {(this.IdentificationScheme == null ? "null" : this.IdentificationScheme)}");
        }
    }
}