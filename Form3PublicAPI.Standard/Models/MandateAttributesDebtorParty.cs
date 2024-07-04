// <copyright file="MandateAttributesDebtorParty.cs" company="APIMatic">
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
    /// MandateAttributesDebtorParty.
    /// </summary>
    public class MandateAttributesDebtorParty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandateAttributesDebtorParty"/> class.
        /// </summary>
        public MandateAttributesDebtorParty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MandateAttributesDebtorParty"/> class.
        /// </summary>
        /// <param name="accountName">account_name.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="accountWith">account_with.</param>
        /// <param name="address">address.</param>
        /// <param name="country">country.</param>
        public MandateAttributesDebtorParty(
            string accountName = null,
            string accountNumber = null,
            Models.AccountNumberCodeEnum? accountNumberCode = null,
            Models.AccountHoldingEntity accountWith = null,
            List<string> address = null,
            string country = null)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.AccountWith = accountWith;
            this.Address = address;
            this.Country = country;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets AccountNumber.
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
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MandateAttributesDebtorParty : ({string.Join(", ", toStringOutput)})";
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
            return obj is MandateAttributesDebtorParty other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.AccountWith == null && other.AccountWith == null) || (this.AccountWith?.Equals(other.AccountWith) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true));
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
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
        }
    }
}