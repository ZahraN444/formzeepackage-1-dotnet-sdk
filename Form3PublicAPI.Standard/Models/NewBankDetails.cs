// <copyright file="NewBankDetails.cs" company="APIMatic">
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
    /// NewBankDetails.
    /// </summary>
    public class NewBankDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBankDetails"/> class.
        /// </summary>
        public NewBankDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewBankDetails"/> class.
        /// </summary>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="accountWith">account_with.</param>
        /// <param name="rollNumber">roll_number.</param>
        public NewBankDetails(
            string accountNumber = null,
            Models.AccountNumberCodeEnum? accountNumberCode = null,
            Models.AccountHoldingEntity accountWith = null,
            string rollNumber = null)
        {
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.AccountWith = accountWith;
            this.RollNumber = rollNumber;
        }

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
        /// Gets or sets RollNumber.
        /// </summary>
        [JsonProperty("roll_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RollNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NewBankDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is NewBankDetails other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.AccountWith == null && other.AccountWith == null) || (this.AccountWith?.Equals(other.AccountWith) == true)) &&
                ((this.RollNumber == null && other.RollNumber == null) || (this.RollNumber?.Equals(other.RollNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountNumberCode = {(this.AccountNumberCode == null ? "null" : this.AccountNumberCode.ToString())}");
            toStringOutput.Add($"this.AccountWith = {(this.AccountWith == null ? "null" : this.AccountWith.ToString())}");
            toStringOutput.Add($"this.RollNumber = {(this.RollNumber == null ? "null" : this.RollNumber)}");
        }
    }
}