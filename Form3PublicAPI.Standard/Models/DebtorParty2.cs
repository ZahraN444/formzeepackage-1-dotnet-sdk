// <copyright file="DebtorParty2.cs" company="APIMatic">
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
    /// DebtorParty2.
    /// </summary>
    public class DebtorParty2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtorParty2"/> class.
        /// </summary>
        public DebtorParty2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtorParty2"/> class.
        /// </summary>
        /// <param name="accountName">account_name.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="accountWith">account_with.</param>
        /// <param name="address">address.</param>
        /// <param name="buildingNumber">building_number.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
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
        public DebtorParty2(
            string accountName = null,
            string accountNumber = null,
            Models.AccountNumberCodeEnum? accountNumberCode = null,
            Models.AccountHoldingEntity accountWith = null,
            List<string> address = null,
            string buildingNumber = null,
            string city = null,
            string country = null,
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
            this.AccountWith = accountWith;
            this.Address = address;
            this.BuildingNumber = buildingNumber;
            this.City = city;
            this.Country = country;
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
        /// Information about the financial institution servicing the account.
        /// </summary>
        [JsonProperty("account_with", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountHoldingEntity AccountWith { get; set; }

        /// <summary>
        /// Debtor address
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

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
        /// Debtor name
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
        /// Array for additional ID(s) of ultimate organisation
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

            return $"DebtorParty2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is DebtorParty2 other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.AccountWith == null && other.AccountWith == null) || (this.AccountWith?.Equals(other.AccountWith) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.BuildingNumber == null && other.BuildingNumber == null) || (this.BuildingNumber?.Equals(other.BuildingNumber) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
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
            toStringOutput.Add($"this.AccountWith = {(this.AccountWith == null ? "null" : this.AccountWith.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : $"[{string.Join(", ", this.Address)} ]")}");
            toStringOutput.Add($"this.BuildingNumber = {(this.BuildingNumber == null ? "null" : this.BuildingNumber)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
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