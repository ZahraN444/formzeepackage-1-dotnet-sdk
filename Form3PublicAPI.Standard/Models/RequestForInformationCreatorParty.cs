// <copyright file="RequestForInformationCreatorParty.cs" company="APIMatic">
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
    /// RequestForInformationCreatorParty.
    /// </summary>
    public class RequestForInformationCreatorParty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationCreatorParty"/> class.
        /// </summary>
        public RequestForInformationCreatorParty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationCreatorParty"/> class.
        /// </summary>
        /// <param name="birthCity">birth_city.</param>
        /// <param name="birthCountry">birth_country.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="birthProvince">birth_province.</param>
        /// <param name="name">name.</param>
        /// <param name="organisationIdentification">organisation_identification.</param>
        /// <param name="organisationIdentificationCode">organisation_identification_code.</param>
        /// <param name="organisationIdentificationIssuer">organisation_identification_issuer.</param>
        /// <param name="organisationIdentifications">organisation_identifications.</param>
        /// <param name="privateIdentification">private_identification.</param>
        /// <param name="telephoneNumber">telephone_number.</param>
        public RequestForInformationCreatorParty(
            string birthCity = null,
            string birthCountry = null,
            string birthDate = null,
            string birthProvince = null,
            string name = null,
            string organisationIdentification = null,
            string organisationIdentificationCode = null,
            string organisationIdentificationIssuer = null,
            List<Models.OrganisationIdentification> organisationIdentifications = null,
            Models.PrivateIdentification1 privateIdentification = null,
            string telephoneNumber = null)
        {
            this.BirthCity = birthCity;
            this.BirthCountry = birthCountry;
            this.BirthDate = birthDate;
            this.BirthProvince = birthProvince;
            this.Name = name;
            this.OrganisationIdentification = organisationIdentification;
            this.OrganisationIdentificationCode = organisationIdentificationCode;
            this.OrganisationIdentificationIssuer = organisationIdentificationIssuer;
            this.OrganisationIdentifications = organisationIdentifications;
            this.PrivateIdentification = privateIdentification;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// Gets or sets BirthCity.
        /// </summary>
        [JsonProperty("birth_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCity { get; set; }

        /// <summary>
        /// Gets or sets BirthCountry.
        /// </summary>
        [JsonProperty("birth_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// Gets or sets BirthDate.
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or sets BirthProvince.
        /// </summary>
        [JsonProperty("birth_province", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthProvince { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets OrganisationIdentification.
        /// </summary>
        [JsonProperty("organisation_identification", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentification { get; set; }

        /// <summary>
        /// Gets or sets OrganisationIdentificationCode.
        /// </summary>
        [JsonProperty("organisation_identification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets OrganisationIdentificationIssuer.
        /// </summary>
        [JsonProperty("organisation_identification_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentificationIssuer { get; set; }

        /// <summary>
        /// Gets or sets OrganisationIdentifications.
        /// </summary>
        [JsonProperty("organisation_identifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrganisationIdentification> OrganisationIdentifications { get; set; }

        /// <summary>
        /// Gets or sets PrivateIdentification.
        /// </summary>
        [JsonProperty("private_identification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrivateIdentification1 PrivateIdentification { get; set; }

        /// <summary>
        /// Gets or sets TelephoneNumber.
        /// </summary>
        [JsonProperty("telephone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequestForInformationCreatorParty : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequestForInformationCreatorParty other &&                ((this.BirthCity == null && other.BirthCity == null) || (this.BirthCity?.Equals(other.BirthCity) == true)) &&
                ((this.BirthCountry == null && other.BirthCountry == null) || (this.BirthCountry?.Equals(other.BirthCountry) == true)) &&
                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.BirthProvince == null && other.BirthProvince == null) || (this.BirthProvince?.Equals(other.BirthProvince) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.OrganisationIdentification == null && other.OrganisationIdentification == null) || (this.OrganisationIdentification?.Equals(other.OrganisationIdentification) == true)) &&
                ((this.OrganisationIdentificationCode == null && other.OrganisationIdentificationCode == null) || (this.OrganisationIdentificationCode?.Equals(other.OrganisationIdentificationCode) == true)) &&
                ((this.OrganisationIdentificationIssuer == null && other.OrganisationIdentificationIssuer == null) || (this.OrganisationIdentificationIssuer?.Equals(other.OrganisationIdentificationIssuer) == true)) &&
                ((this.OrganisationIdentifications == null && other.OrganisationIdentifications == null) || (this.OrganisationIdentifications?.Equals(other.OrganisationIdentifications) == true)) &&
                ((this.PrivateIdentification == null && other.PrivateIdentification == null) || (this.PrivateIdentification?.Equals(other.PrivateIdentification) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BirthCity = {(this.BirthCity == null ? "null" : this.BirthCity)}");
            toStringOutput.Add($"this.BirthCountry = {(this.BirthCountry == null ? "null" : this.BirthCountry)}");
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate)}");
            toStringOutput.Add($"this.BirthProvince = {(this.BirthProvince == null ? "null" : this.BirthProvince)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.OrganisationIdentification = {(this.OrganisationIdentification == null ? "null" : this.OrganisationIdentification)}");
            toStringOutput.Add($"this.OrganisationIdentificationCode = {(this.OrganisationIdentificationCode == null ? "null" : this.OrganisationIdentificationCode)}");
            toStringOutput.Add($"this.OrganisationIdentificationIssuer = {(this.OrganisationIdentificationIssuer == null ? "null" : this.OrganisationIdentificationIssuer)}");
            toStringOutput.Add($"this.OrganisationIdentifications = {(this.OrganisationIdentifications == null ? "null" : $"[{string.Join(", ", this.OrganisationIdentifications)} ]")}");
            toStringOutput.Add($"this.PrivateIdentification = {(this.PrivateIdentification == null ? "null" : this.PrivateIdentification.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
        }
    }
}