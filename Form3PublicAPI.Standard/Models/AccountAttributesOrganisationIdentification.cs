// <copyright file="AccountAttributesOrganisationIdentification.cs" company="APIMatic">
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
    /// AccountAttributesOrganisationIdentification.
    /// </summary>
    public class AccountAttributesOrganisationIdentification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesOrganisationIdentification"/> class.
        /// </summary>
        public AccountAttributesOrganisationIdentification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesOrganisationIdentification"/> class.
        /// </summary>
        /// <param name="actors">actors.</param>
        /// <param name="address">address.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="identification">identification.</param>
        /// <param name="identificationIssuer">identification_issuer.</param>
        /// <param name="identificationScheme">identification_scheme.</param>
        /// <param name="identificationSchemeCode">identification_scheme_code.</param>
        /// <param name="registrationNumber">registration_number.</param>
        /// <param name="taxResidency">tax_residency.</param>
        public AccountAttributesOrganisationIdentification(
            List<Models.AccountAttributesOrganisationIdentificationActor> actors = null,
            List<string> address = null,
            string city = null,
            string country = null,
            string identification = null,
            string identificationIssuer = null,
            string identificationScheme = null,
            string identificationSchemeCode = null,
            string registrationNumber = null,
            string taxResidency = null)
        {
            this.Actors = actors;
            this.Address = address;
            this.City = city;
            this.Country = country;
            this.Identification = identification;
            this.IdentificationIssuer = identificationIssuer;
            this.IdentificationScheme = identificationScheme;
            this.IdentificationSchemeCode = identificationSchemeCode;
            this.RegistrationNumber = registrationNumber;
            this.TaxResidency = taxResidency;
        }

        /// <summary>
        /// Gets or sets Actors.
        /// </summary>
        [JsonProperty("actors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountAttributesOrganisationIdentificationActor> Actors { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Identification.
        /// </summary>
        [JsonProperty("identification", NullValueHandling = NullValueHandling.Ignore)]
        public string Identification { get; set; }

        /// <summary>
        /// Gets or sets IdentificationIssuer.
        /// </summary>
        [JsonProperty("identification_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationIssuer { get; set; }

        /// <summary>
        /// Gets or sets IdentificationScheme.
        /// </summary>
        [JsonProperty("identification_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationScheme { get; set; }

        /// <summary>
        /// Gets or sets IdentificationSchemeCode.
        /// </summary>
        [JsonProperty("identification_scheme_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationSchemeCode { get; set; }

        /// <summary>
        /// Gets or sets RegistrationNumber.
        /// </summary>
        [JsonProperty("registration_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// ISO 3166-1 code used to identify the domicile of the account
        /// </summary>
        [JsonProperty("tax_residency", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxResidency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountAttributesOrganisationIdentification : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountAttributesOrganisationIdentification other &&                ((this.Actors == null && other.Actors == null) || (this.Actors?.Equals(other.Actors) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Identification == null && other.Identification == null) || (this.Identification?.Equals(other.Identification) == true)) &&
                ((this.IdentificationIssuer == null && other.IdentificationIssuer == null) || (this.IdentificationIssuer?.Equals(other.IdentificationIssuer) == true)) &&
                ((this.IdentificationScheme == null && other.IdentificationScheme == null) || (this.IdentificationScheme?.Equals(other.IdentificationScheme) == true)) &&
                ((this.IdentificationSchemeCode == null && other.IdentificationSchemeCode == null) || (this.IdentificationSchemeCode?.Equals(other.IdentificationSchemeCode) == true)) &&
                ((this.RegistrationNumber == null && other.RegistrationNumber == null) || (this.RegistrationNumber?.Equals(other.RegistrationNumber) == true)) &&
                ((this.TaxResidency == null && other.TaxResidency == null) || (this.TaxResidency?.Equals(other.TaxResidency) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Actors = {(this.Actors == null ? "null" : $"[{string.Join(", ", this.Actors)} ]")}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : $"[{string.Join(", ", this.Address)} ]")}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Identification = {(this.Identification == null ? "null" : this.Identification)}");
            toStringOutput.Add($"this.IdentificationIssuer = {(this.IdentificationIssuer == null ? "null" : this.IdentificationIssuer)}");
            toStringOutput.Add($"this.IdentificationScheme = {(this.IdentificationScheme == null ? "null" : this.IdentificationScheme)}");
            toStringOutput.Add($"this.IdentificationSchemeCode = {(this.IdentificationSchemeCode == null ? "null" : this.IdentificationSchemeCode)}");
            toStringOutput.Add($"this.RegistrationNumber = {(this.RegistrationNumber == null ? "null" : this.RegistrationNumber)}");
            toStringOutput.Add($"this.TaxResidency = {(this.TaxResidency == null ? "null" : this.TaxResidency)}");
        }
    }
}