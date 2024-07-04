// <copyright file="Relationships15.cs" company="APIMatic">
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
    /// Relationships15.
    /// </summary>
    public class Relationships15
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships15"/> class.
        /// </summary>
        public Relationships15()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships15"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReversal">direct_debit_reversal.</param>
        public Relationships15(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitReversal2 directDebitReversal = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReversal = directDebitReversal;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReversal.
        /// </summary>
        [JsonProperty("direct_debit_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReversal2 DirectDebitReversal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships15 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships15 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitReversal == null && other.DirectDebitReversal == null) || (this.DirectDebitReversal?.Equals(other.DirectDebitReversal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitReversal = {(this.DirectDebitReversal == null ? "null" : this.DirectDebitReversal.ToString())}");
        }
    }
}