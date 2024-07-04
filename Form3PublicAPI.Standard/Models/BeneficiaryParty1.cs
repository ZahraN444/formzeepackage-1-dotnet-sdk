// <copyright file="BeneficiaryParty1.cs" company="APIMatic">
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
    /// BeneficiaryParty1.
    /// </summary>
    public class BeneficiaryParty1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryParty1"/> class.
        /// </summary>
        public BeneficiaryParty1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryParty1"/> class.
        /// </summary>
        /// <param name="accountName">account_name.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="accountProxy">account_proxy.</param>
        /// <param name="accountType">account_type.</param>
        /// <param name="accountWith">account_with.</param>
        /// <param name="additionalAddressLine">additional_address_line.</param>
        /// <param name="address">address.</param>
        /// <param name="birthCity">birth_city.</param>
        /// <param name="birthCountry">birth_country.</param>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="birthProvince">birth_province.</param>
        /// <param name="buildingNumber">building_number.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="countryOfResidence">country_of_residence.</param>
        /// <param name="name">name.</param>
        /// <param name="organisationIdentification">organisation_identification.</param>
        /// <param name="organisationIdentificationCode">organisation_identification_code.</param>
        /// <param name="organisationIdentificationIssuer">organisation_identification_issuer.</param>
        /// <param name="organisationIdentificationScheme">organisation_identification_scheme.</param>
        /// <param name="organisationIdentifications">organisation_identifications.</param>
        /// <param name="postCode">post_code.</param>
        /// <param name="privateIdentification">private_identification.</param>
        /// <param name="province">province.</param>
        /// <param name="streetName">street_name.</param>
        /// <param name="telephoneNumber">telephone_number.</param>
        public BeneficiaryParty1(
            string accountName = null,
            string accountNumber = null,
            Models.AccountNumberCodeEnum? accountNumberCode = null,
            Models.BeneficiaryDebtorAccountProxy accountProxy = null,
            int? accountType = null,
            Models.BeneficiaryDebtorAccountHoldingEntity accountWith = null,
            string additionalAddressLine = null,
            List<string> address = null,
            string birthCity = null,
            string birthCountry = null,
            DateTime? birthDate = null,
            string birthProvince = null,
            string buildingNumber = null,
            string city = null,
            string country = null,
            string countryOfResidence = null,
            string name = null,
            string organisationIdentification = null,
            string organisationIdentificationCode = null,
            string organisationIdentificationIssuer = null,
            string organisationIdentificationScheme = null,
            List<Models.BeneficiaryDebtorOrganisationIdentification> organisationIdentifications = null,
            string postCode = null,
            Models.PrivateIdentification privateIdentification = null,
            string province = null,
            string streetName = null,
            string telephoneNumber = null)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.AccountProxy = accountProxy;
            this.AccountType = accountType;
            this.AccountWith = accountWith;
            this.AdditionalAddressLine = additionalAddressLine;
            this.Address = address;
            this.BirthCity = birthCity;
            this.BirthCountry = birthCountry;
            this.BirthDate = birthDate;
            this.BirthProvince = birthProvince;
            this.BuildingNumber = buildingNumber;
            this.City = city;
            this.Country = country;
            this.CountryOfResidence = countryOfResidence;
            this.Name = name;
            this.OrganisationIdentification = organisationIdentification;
            this.OrganisationIdentificationCode = organisationIdentificationCode;
            this.OrganisationIdentificationIssuer = organisationIdentificationIssuer;
            this.OrganisationIdentificationScheme = organisationIdentificationScheme;
            this.OrganisationIdentifications = organisationIdentifications;
            this.PostCode = postCode;
            this.PrivateIdentification = privateIdentification;
            this.Province = province;
            this.StreetName = streetName;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// Name of beneficiary as given with account
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Beneficiary account number
        /// </summary>
        [JsonProperty("account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The type of identification given at `account_number` attribute
        /// </summary>
        [JsonProperty("account_number_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountNumberCodeEnum? AccountNumberCode { get; set; }

        /// <summary>
        /// Gets or sets AccountProxy.
        /// </summary>
        [JsonProperty("account_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryDebtorAccountProxy AccountProxy { get; set; }

        /// <summary>
        /// The type of the account given with `beneficiary_party.account_number`. Single digit number. Only required if requested by the beneficiary party. Defaults to 0.
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountType { get; set; }

        /// <summary>
        /// Gets or sets AccountWith.
        /// </summary>
        [JsonProperty("account_with", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryDebtorAccountHoldingEntity AccountWith { get; set; }

        /// <summary>
        /// Additional address line of the beneficiary address
        /// </summary>
        [JsonProperty("additional_address_line", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalAddressLine { get; set; }

        /// <summary>
        /// Beneficiary address
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Beneficiary birth city
        /// </summary>
        [JsonProperty("birth_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCity { get; set; }

        /// <summary>
        /// Beneficiary birth country, ISO 3166 format country code
        /// </summary>
        [JsonProperty("birth_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// Beneficiary birth date. Formatted according to ISO 8601 format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Beneficiary birth province
        /// </summary>
        [JsonProperty("birth_province", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthProvince { get; set; }

        /// <summary>
        /// Building number of the beneficiary address
        /// </summary>
        [JsonProperty("building_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// City/Town of the Beneficiary address
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Country of the beneficiary address, ISO 3166 format country code
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Country of residence of the beneficiary party, ISO 3166 format country code
        /// </summary>
        [JsonProperty("country_of_residence", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryOfResidence { get; set; }

        /// <summary>
        /// Beneficiary name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Organisation identification of a beneficiary, used in the case that the beneficiary is an organisation and not a private person
        /// </summary>
        [JsonProperty("organisation_identification", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentification { get; set; }

        /// <summary>
        /// The code that specifies the type of `organisation_identification`
        /// </summary>
        [JsonProperty("organisation_identification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentificationCode { get; set; }

        /// <summary>
        /// Issuer of the `organisation_identification`
        /// </summary>
        [JsonProperty("organisation_identification_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentificationIssuer { get; set; }

        /// <summary>
        /// The code that specifies the scheme of `organisation_identification`
        /// </summary>
        [JsonProperty("organisation_identification_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationIdentificationScheme { get; set; }

        /// <summary>
        /// Array for additional ID(s) of beneficiary organisation
        /// </summary>
        [JsonProperty("organisation_identifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BeneficiaryDebtorOrganisationIdentification> OrganisationIdentifications { get; set; }

        /// <summary>
        /// Post code of the beneficiary address
        /// </summary>
        [JsonProperty("post_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets PrivateIdentification.
        /// </summary>
        [JsonProperty("private_identification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrivateIdentification PrivateIdentification { get; set; }

        /// <summary>
        /// Province of the beneficiary address
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// Street name of the beneficiary address
        /// </summary>
        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }

        /// <summary>
        /// Beneficiary phone number
        /// </summary>
        [JsonProperty("telephone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BeneficiaryParty1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is BeneficiaryParty1 other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.AccountProxy == null && other.AccountProxy == null) || (this.AccountProxy?.Equals(other.AccountProxy) == true)) &&
                ((this.AccountType == null && other.AccountType == null) || (this.AccountType?.Equals(other.AccountType) == true)) &&
                ((this.AccountWith == null && other.AccountWith == null) || (this.AccountWith?.Equals(other.AccountWith) == true)) &&
                ((this.AdditionalAddressLine == null && other.AdditionalAddressLine == null) || (this.AdditionalAddressLine?.Equals(other.AdditionalAddressLine) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.BirthCity == null && other.BirthCity == null) || (this.BirthCity?.Equals(other.BirthCity) == true)) &&
                ((this.BirthCountry == null && other.BirthCountry == null) || (this.BirthCountry?.Equals(other.BirthCountry) == true)) &&
                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.BirthProvince == null && other.BirthProvince == null) || (this.BirthProvince?.Equals(other.BirthProvince) == true)) &&
                ((this.BuildingNumber == null && other.BuildingNumber == null) || (this.BuildingNumber?.Equals(other.BuildingNumber) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.CountryOfResidence == null && other.CountryOfResidence == null) || (this.CountryOfResidence?.Equals(other.CountryOfResidence) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.OrganisationIdentification == null && other.OrganisationIdentification == null) || (this.OrganisationIdentification?.Equals(other.OrganisationIdentification) == true)) &&
                ((this.OrganisationIdentificationCode == null && other.OrganisationIdentificationCode == null) || (this.OrganisationIdentificationCode?.Equals(other.OrganisationIdentificationCode) == true)) &&
                ((this.OrganisationIdentificationIssuer == null && other.OrganisationIdentificationIssuer == null) || (this.OrganisationIdentificationIssuer?.Equals(other.OrganisationIdentificationIssuer) == true)) &&
                ((this.OrganisationIdentificationScheme == null && other.OrganisationIdentificationScheme == null) || (this.OrganisationIdentificationScheme?.Equals(other.OrganisationIdentificationScheme) == true)) &&
                ((this.OrganisationIdentifications == null && other.OrganisationIdentifications == null) || (this.OrganisationIdentifications?.Equals(other.OrganisationIdentifications) == true)) &&
                ((this.PostCode == null && other.PostCode == null) || (this.PostCode?.Equals(other.PostCode) == true)) &&
                ((this.PrivateIdentification == null && other.PrivateIdentification == null) || (this.PrivateIdentification?.Equals(other.PrivateIdentification) == true)) &&
                ((this.Province == null && other.Province == null) || (this.Province?.Equals(other.Province) == true)) &&
                ((this.StreetName == null && other.StreetName == null) || (this.StreetName?.Equals(other.StreetName) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountNumberCode = {(this.AccountNumberCode == null ? "null" : this.AccountNumberCode.ToString())}");
            toStringOutput.Add($"this.AccountProxy = {(this.AccountProxy == null ? "null" : this.AccountProxy.ToString())}");
            toStringOutput.Add($"this.AccountType = {(this.AccountType == null ? "null" : this.AccountType.ToString())}");
            toStringOutput.Add($"this.AccountWith = {(this.AccountWith == null ? "null" : this.AccountWith.ToString())}");
            toStringOutput.Add($"this.AdditionalAddressLine = {(this.AdditionalAddressLine == null ? "null" : this.AdditionalAddressLine)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : $"[{string.Join(", ", this.Address)} ]")}");
            toStringOutput.Add($"this.BirthCity = {(this.BirthCity == null ? "null" : this.BirthCity)}");
            toStringOutput.Add($"this.BirthCountry = {(this.BirthCountry == null ? "null" : this.BirthCountry)}");
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate.ToString())}");
            toStringOutput.Add($"this.BirthProvince = {(this.BirthProvince == null ? "null" : this.BirthProvince)}");
            toStringOutput.Add($"this.BuildingNumber = {(this.BuildingNumber == null ? "null" : this.BuildingNumber)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.CountryOfResidence = {(this.CountryOfResidence == null ? "null" : this.CountryOfResidence)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.OrganisationIdentification = {(this.OrganisationIdentification == null ? "null" : this.OrganisationIdentification)}");
            toStringOutput.Add($"this.OrganisationIdentificationCode = {(this.OrganisationIdentificationCode == null ? "null" : this.OrganisationIdentificationCode)}");
            toStringOutput.Add($"this.OrganisationIdentificationIssuer = {(this.OrganisationIdentificationIssuer == null ? "null" : this.OrganisationIdentificationIssuer)}");
            toStringOutput.Add($"this.OrganisationIdentificationScheme = {(this.OrganisationIdentificationScheme == null ? "null" : this.OrganisationIdentificationScheme)}");
            toStringOutput.Add($"this.OrganisationIdentifications = {(this.OrganisationIdentifications == null ? "null" : $"[{string.Join(", ", this.OrganisationIdentifications)} ]")}");
            toStringOutput.Add($"this.PostCode = {(this.PostCode == null ? "null" : this.PostCode)}");
            toStringOutput.Add($"this.PrivateIdentification = {(this.PrivateIdentification == null ? "null" : this.PrivateIdentification.ToString())}");
            toStringOutput.Add($"this.Province = {(this.Province == null ? "null" : this.Province)}");
            toStringOutput.Add($"this.StreetName = {(this.StreetName == null ? "null" : this.StreetName)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
        }
    }
}