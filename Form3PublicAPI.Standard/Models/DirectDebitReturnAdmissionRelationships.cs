// <copyright file="DirectDebitReturnAdmissionRelationships.cs" company="APIMatic">
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
    /// DirectDebitReturnAdmissionRelationships.
    /// </summary>
    public class DirectDebitReturnAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitReturnAdmissionRelationships"/> class.
        /// </summary>
        public DirectDebitReturnAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitReturnAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReturn">direct_debit_return.</param>
        public DirectDebitReturnAdmissionRelationships(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitReturn2 directDebitReturn = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReturn = directDebitReturn;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitReturnAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitReturnAdmissionRelationships other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
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