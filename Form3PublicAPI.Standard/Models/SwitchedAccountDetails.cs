// <copyright file="SwitchedAccountDetails.cs" company="APIMatic">
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
    /// SwitchedAccountDetails.
    /// </summary>
    public class SwitchedAccountDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchedAccountDetails"/> class.
        /// </summary>
        public SwitchedAccountDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchedAccountDetails"/> class.
        /// </summary>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="accountWith">account_with.</param>
        /// <param name="switchedEffectiveDate">switched_effective_date.</param>
        /// <param name="accountType">account_type.</param>
        public SwitchedAccountDetails(
            string accountNumber,
            string accountNumberCode,
            Models.AccountHoldingEntity accountWith,
            DateTime switchedEffectiveDate,
            int? accountType = 0)
        {
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.AccountType = accountType;
            this.AccountWith = accountWith;
            this.SwitchedEffectiveDate = switchedEffectiveDate;
        }

        /// <summary>
        /// Switched account number. Must be a UK account number, maximum length 8 characters.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// ISO 20022 code used to identify the type of account number being used
        /// </summary>
        [JsonProperty("account_number_code")]
        public string AccountNumberCode { get; set; }

        /// <summary>
        /// The type of the account provided in account_number. Only required if requested by the beneficiary party.
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountType { get; set; }

        /// <summary>
        /// Information about the financial institution servicing the account.
        /// </summary>
        [JsonProperty("account_with")]
        public Models.AccountHoldingEntity AccountWith { get; set; }

        /// <summary>
        /// Starting date for the account to be effectively switched
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("switched_effective_date")]
        public DateTime SwitchedEffectiveDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SwitchedAccountDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is SwitchedAccountDetails other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.AccountType == null && other.AccountType == null) || (this.AccountType?.Equals(other.AccountType) == true)) &&
                ((this.AccountWith == null && other.AccountWith == null) || (this.AccountWith?.Equals(other.AccountWith) == true)) &&
                this.SwitchedEffectiveDate.Equals(other.SwitchedEffectiveDate);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountNumberCode = {(this.AccountNumberCode == null ? "null" : this.AccountNumberCode)}");
            toStringOutput.Add($"this.AccountType = {(this.AccountType == null ? "null" : this.AccountType.ToString())}");
            toStringOutput.Add($"this.AccountWith = {(this.AccountWith == null ? "null" : this.AccountWith.ToString())}");
            toStringOutput.Add($"this.SwitchedEffectiveDate = {this.SwitchedEffectiveDate}");
        }
    }
}