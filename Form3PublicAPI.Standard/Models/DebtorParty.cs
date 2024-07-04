// <copyright file="DebtorParty.cs" company="APIMatic">
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
    /// DebtorParty.
    /// </summary>
    public class DebtorParty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtorParty"/> class.
        /// </summary>
        public DebtorParty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtorParty"/> class.
        /// </summary>
        /// <param name="accountName">account_name.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="accountProxy">account_proxy.</param>
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
        /// <param name="customerId">customer_id.</param>
        /// <param name="customerIdCode">customer_id_code.</param>
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
        public DebtorParty(
            string accountName = null,
            string accountNumber = null,
            Models.AccountNumberCodeEnum? accountNumberCode = null,
            Models.BeneficiaryDebtorAccountProxy accountProxy = null,
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
            string customerId = null,
            string customerIdCode = null,
            string name = null,
            string organisationIdentification = null,
            string organisationIdentificationCode = null,
            string organisationIdentificationIssuer = null,
            string organisationIdentificationScheme = null,
            List<Models.BeneficiaryDebtorOrganisationIdentification> organisationIdentifications = null,
            string postCode = null,
            Models.PrivateIdentification privateIdentification = null,
            string province = null,
            string streetName = null)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.AccountProxy = accountProxy;
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
            this.CustomerId = customerId;
            this.CustomerIdCode = customerIdCode;
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
        }

        /// <summary>
        /// Name of debtor as given with account
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Debtor account number. Allows upper case and numeric characters.
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
        /// Gets or sets AccountWith.
        /// </summary>
        [JsonProperty("account_with", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryDebtorAccountHoldingEntity AccountWith { get; set; }

        /// <summary>
        /// Additional address line of the Debtor address
        /// </summary>
        [JsonProperty("additional_address_line", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalAddressLine { get; set; }

        /// <summary>
        /// Debtor address
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Debtor birth city
        /// </summary>
        [JsonProperty("birth_city", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCity { get; set; }

        /// <summary>
        /// Debtor birth country. ISO 3166 format country code
        /// </summary>
        [JsonProperty("birth_country", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// Debtor birth date. Formatted according to ISO 8601 format: YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Debtor birth province
        /// </summary>
        [JsonProperty("birth_province", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthProvince { get; set; }

        /// <summary>
        /// Building number of the Debtor address
        /// </summary>
        [JsonProperty("building_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// City/Town of the Debtor address
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Country of debtor address. ISO 3166 format country code"
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Country of residence of the debtor party, ISO 3166 format country code
        /// </summary>
        [JsonProperty("country_of_residence", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryOfResidence { get; set; }

        /// <summary>
        /// SWIFT BIC for ordering customer, either BIC8 or BIC11
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Code for `customer_id`
        /// </summary>
        [JsonProperty("customer_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerIdCode { get; set; }

        /// <summary>
        /// Debtor name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Organisation identification of a debtor, in the case that the debtor is an organisation and not a private person
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
        /// Array for additional ID(s) of debtor organisation
        /// </summary>
        [JsonProperty("organisation_identifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BeneficiaryDebtorOrganisationIdentification> OrganisationIdentifications { get; set; }

        /// <summary>
        /// Post code of the Debtor address
        /// </summary>
        [JsonProperty("post_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets PrivateIdentification.
        /// </summary>
        [JsonProperty("private_identification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrivateIdentification PrivateIdentification { get; set; }

        /// <summary>
        /// Province of the Debtor address
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// Street name of the Debtor address
        /// </summary>
        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DebtorParty : ({string.Join(", ", toStringOutput)})";
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
            return obj is DebtorParty other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.AccountProxy == null && other.AccountProxy == null) || (this.AccountProxy?.Equals(other.AccountProxy) == true)) &&
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
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.CustomerIdCode == null && other.CustomerIdCode == null) || (this.CustomerIdCode?.Equals(other.CustomerIdCode) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.OrganisationIdentification == null && other.OrganisationIdentification == null) || (this.OrganisationIdentification?.Equals(other.OrganisationIdentification) == true)) &&
                ((this.OrganisationIdentificationCode == null && other.OrganisationIdentificationCode == null) || (this.OrganisationIdentificationCode?.Equals(other.OrganisationIdentificationCode) == true)) &&
                ((this.OrganisationIdentificationIssuer == null && other.OrganisationIdentificationIssuer == null) || (this.OrganisationIdentificationIssuer?.Equals(other.OrganisationIdentificationIssuer) == true)) &&
                ((this.OrganisationIdentificationScheme == null && other.OrganisationIdentificationScheme == null) || (this.OrganisationIdentificationScheme?.Equals(other.OrganisationIdentificationScheme) == true)) &&
                ((this.OrganisationIdentifications == null && other.OrganisationIdentifications == null) || (this.OrganisationIdentifications?.Equals(other.OrganisationIdentifications) == true)) &&
                ((this.PostCode == null && other.PostCode == null) || (this.PostCode?.Equals(other.PostCode) == true)) &&
                ((this.PrivateIdentification == null && other.PrivateIdentification == null) || (this.PrivateIdentification?.Equals(other.PrivateIdentification) == true)) &&
                ((this.Province == null && other.Province == null) || (this.Province?.Equals(other.Province) == true)) &&
                ((this.StreetName == null && other.StreetName == null) || (this.StreetName?.Equals(other.StreetName) == true));
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
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId)}");
            toStringOutput.Add($"this.CustomerIdCode = {(this.CustomerIdCode == null ? "null" : this.CustomerIdCode)}");
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
        }
    }
}