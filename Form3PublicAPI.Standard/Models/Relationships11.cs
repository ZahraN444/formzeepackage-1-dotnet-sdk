// <copyright file="Relationships11.cs" company="APIMatic">
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
    /// Relationships11.
    /// </summary>
    public class Relationships11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships11"/> class.
        /// </summary>
        public Relationships11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships11"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReturn">direct_debit_return.</param>
        /// <param name="directDebitReturnReversalAdmission">direct_debit_return_reversal_admission.</param>
        public Relationships11(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitReturn2 directDebitReturn = null,
            Models.DirectDebitReturnReversalAdmission2 directDebitReturnReversalAdmission = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReturn = directDebitReturn;
            this.DirectDebitReturnReversalAdmission = directDebitReturnReversalAdmission;
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
        /// Gets or sets DirectDebitReturnReversalAdmission.
        /// </summary>
        [JsonProperty("direct_debit_return_reversal_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnReversalAdmission2 DirectDebitReturnReversalAdmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships11 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships11 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitReturn == null && other.DirectDebitReturn == null) || (this.DirectDebitReturn?.Equals(other.DirectDebitReturn) == true)) &&
                ((this.DirectDebitReturnReversalAdmission == null && other.DirectDebitReturnReversalAdmission == null) || (this.DirectDebitReturnReversalAdmission?.Equals(other.DirectDebitReturnReversalAdmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturn = {(this.DirectDebitReturn == null ? "null" : this.DirectDebitReturn.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturnReversalAdmission = {(this.DirectDebitReturnReversalAdmission == null ? "null" : this.DirectDebitReturnReversalAdmission.ToString())}");
        }
    }
}