// <copyright file="Fx.cs" company="APIMatic">
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
    /// Fx.
    /// </summary>
    public class Fx
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fx"/> class.
        /// </summary>
        public Fx()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fx"/> class.
        /// </summary>
        /// <param name="contractReference">contract_reference.</param>
        /// <param name="exchangeRate">exchange_rate.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="originalCurrency">original_currency.</param>
        public Fx(
            string contractReference = null,
            string exchangeRate = null,
            string originalAmount = null,
            string originalCurrency = null)
        {
            this.ContractReference = contractReference;
            this.ExchangeRate = exchangeRate;
            this.OriginalAmount = originalAmount;
            this.OriginalCurrency = originalCurrency;
        }

        /// <summary>
        /// Reference to the foreign exchange contract associated with the transaction
        /// </summary>
        [JsonProperty("contract_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractReference { get; set; }

        /// <summary>
        /// Factor used to convert an amount from the instructed currency into the transaction currency: i.e. to convert the `fx.original_amount`, expressed in the `fx.original_currency`, to `amount` specified in `currency`. Decimal value, represented as a string, maximum length 12. Must be > 0.
        /// </summary>
        [JsonProperty("exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as instructed by the initiating party. Decimal value. Must be > 0.
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// Currency of `original_amount`. Currency code as defined in ISO 4217.
        /// </summary>
        [JsonProperty("original_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalCurrency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Fx : ({string.Join(", ", toStringOutput)})";
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
            return obj is Fx other &&                ((this.ContractReference == null && other.ContractReference == null) || (this.ContractReference?.Equals(other.ContractReference) == true)) &&
                ((this.ExchangeRate == null && other.ExchangeRate == null) || (this.ExchangeRate?.Equals(other.ExchangeRate) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.OriginalCurrency == null && other.OriginalCurrency == null) || (this.OriginalCurrency?.Equals(other.OriginalCurrency) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContractReference = {(this.ContractReference == null ? "null" : this.ContractReference)}");
            toStringOutput.Add($"this.ExchangeRate = {(this.ExchangeRate == null ? "null" : this.ExchangeRate)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.OriginalCurrency = {(this.OriginalCurrency == null ? "null" : this.OriginalCurrency)}");
        }
    }
}