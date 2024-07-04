// <copyright file="BeneficiaryParty2.cs" company="APIMatic">
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
    /// BeneficiaryParty2.
    /// </summary>
    public class BeneficiaryParty2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryParty2"/> class.
        /// </summary>
        public BeneficiaryParty2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryParty2"/> class.
        /// </summary>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="bankId">bank_id.</param>
        public BeneficiaryParty2(
            string accountNumber,
            string bankId)
        {
            this.AccountNumber = accountNumber;
            this.BankId = bankId;
        }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets BankId.
        /// </summary>
        [JsonProperty("bank_id")]
        public string BankId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BeneficiaryParty2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is BeneficiaryParty2 other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
        }
    }
}