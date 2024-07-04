// <copyright file="Relationships12.cs" company="APIMatic">
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
    /// Relationships12.
    /// </summary>
    public class Relationships12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships12"/> class.
        /// </summary>
        public Relationships12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships12"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReturn">direct_debit_return.</param>
        /// <param name="directDebitReturnReversal">direct_debit_return_reversal.</param>
        public Relationships12(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitReturn2 directDebitReturn = null,
            Models.DirectDebitReturnReversal2 directDebitReturnReversal = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReturn = directDebitReturn;
            this.DirectDebitReturnReversal = directDebitReturnReversal;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturn.
        /// </summary>
        [JsonProperty("direct_debit_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturn2 DirectDebitReturn { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturnReversal.
        /// </summary>
        [JsonProperty("direct_debit_return_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnReversal2 DirectDebitReturnReversal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships12 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships12 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitReturn == null && other.DirectDebitReturn == null) || (this.DirectDebitReturn?.Equals(other.DirectDebitReturn) == true)) &&
                ((this.DirectDebitReturnReversal == null && other.DirectDebitReturnReversal == null) || (this.DirectDebitReturnReversal?.Equals(other.DirectDebitReturnReversal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturn = {(this.DirectDebitReturn == null ? "null" : this.DirectDebitReturn.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturnReversal = {(this.DirectDebitReturnReversal == null ? "null" : this.DirectDebitReturnReversal.ToString())}");
        }
    }
}