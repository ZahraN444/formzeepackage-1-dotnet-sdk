// <copyright file="AccountAttributesPrivateIdentification.cs" company="APIMatic">
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
    /// AccountAttributesPrivateIdentification.
    /// </summary>
    public class AccountAttributesPrivateIdentification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesPrivateIdentification"/> class.
        /// </summary>
        public AccountAttributesPrivateIdentification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesPrivateIdentification"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="birthCountry">birth_country.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="identification">identification.</param>
        /// <param name="identificationIssuer">identification_issuer.</param>
        /// <param name="identificationScheme">identification_scheme.</param>
        /// <param name="identificationSchemeCode">identification_scheme_code.</param>
        public AccountAttributesPrivateIdentification(
            List<string> address = null,
            string birthCountry = null,
            DateTime? birthDate = null,
            string city = null,
            string country = null,
            string identification = null,
            string identificationIssuer = null,
            string identificationScheme = null,
            string identificationSchemeCode = null)
        {
            this.Address = address;
            this.BirthCountry = birthCountry;
            this.BirthDate = birthDate;
            this.City = city;
            this.Country = country;
            this.Identification = identification;
            this.IdentificationIssuer = identificationIssuer;
            this.IdentificationScheme = identificationScheme;
            this.IdentificationSchemeCode = identificationSchemeCode;
        }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Gets or sets BirthCountry.
        /// </summary>
        [JsonProperty("birth_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// Customer birth date
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BirthDate { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountAttributesPrivateIdentification : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountAttributesPrivateIdentification other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.BirthCountry == null && other.BirthCountry == null) || (this.BirthCountry?.Equals(other.BirthCountry) == true)) &&
                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Identification == null && other.Identification == null) || (this.Identification?.Equals(other.Identification) == true)) &&
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
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : $"[{string.Join(", ", this.Address)} ]")}");
            toStringOutput.Add($"this.BirthCountry = {(this.BirthCountry == null ? "null" : this.BirthCountry)}");
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate.ToString())}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Identification = {(this.Identification == null ? "null" : this.Identification)}");
            toStringOutput.Add($"this.IdentificationIssuer = {(this.IdentificationIssuer == null ? "null" : this.IdentificationIssuer)}");
            toStringOutput.Add($"this.IdentificationScheme = {(this.IdentificationScheme == null ? "null" : this.IdentificationScheme)}");
            toStringOutput.Add($"this.IdentificationSchemeCode = {(this.IdentificationSchemeCode == null ? "null" : this.IdentificationSchemeCode)}");
        }
    }
}