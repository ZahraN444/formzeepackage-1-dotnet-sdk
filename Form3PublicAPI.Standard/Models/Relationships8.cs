// <copyright file="Relationships8.cs" company="APIMatic">
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
    /// Relationships8.
    /// </summary>
    public class Relationships8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships8"/> class.
        /// </summary>
        public Relationships8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships8"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitRecall">direct_debit_recall.</param>
        public Relationships8(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitRecall2 directDebitRecall = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitRecall = directDebitRecall;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitRecall.
        /// </summary>
        [JsonProperty("direct_debit_recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitRecall2 DirectDebitRecall { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships8 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships8 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitRecall == null && other.DirectDebitRecall == null) || (this.DirectDebitRecall?.Equals(other.DirectDebitRecall) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitRecall = {(this.DirectDebitRecall == null ? "null" : this.DirectDebitRecall.ToString())}");
        }
    }
}