// <copyright file="DirectDebitWithReturn.cs" company="APIMatic">
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
    /// DirectDebitWithReturn.
    /// </summary>
    public class DirectDebitWithReturn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitWithReturn"/> class.
        /// </summary>
        public DirectDebitWithReturn()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitWithReturn"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReturn">direct_debit_return.</param>
        public DirectDebitWithReturn(
            Models.DirectDebit directDebit = null,
            Models.DirectDebitReturn directDebitReturn = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReturn = directDebitReturn;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturn.
        /// </summary>
        [JsonProperty("direct_debit_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturn DirectDebitReturn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitWithReturn : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitWithReturn other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitReturn == null && other.DirectDebitReturn == null) || (this.DirectDebitReturn?.Equals(other.DirectDebitReturn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturn = {(this.DirectDebitReturn == null ? "null" : this.DirectDebitReturn.ToString())}");
        }
    }
}