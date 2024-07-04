// <copyright file="QueryResponseCharges.cs" company="APIMatic">
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
    /// QueryResponseCharges.
    /// </summary>
    public class QueryResponseCharges
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseCharges"/> class.
        /// </summary>
        public QueryResponseCharges()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseCharges"/> class.
        /// </summary>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        public QueryResponseCharges(
            string accountNumber = null,
            string accountNumberCode = null,
            string amount = null,
            string currency = null)
        {
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.Amount = amount;
            this.Currency = currency;
        }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets AccountNumberCode.
        /// </summary>
        [JsonProperty("account_number_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumberCode { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseCharges : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseCharges other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberCode == null && other.AccountNumberCode == null) || (this.AccountNumberCode?.Equals(other.AccountNumberCode) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountNumberCode = {(this.AccountNumberCode == null ? "null" : this.AccountNumberCode)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
        }
    }
}