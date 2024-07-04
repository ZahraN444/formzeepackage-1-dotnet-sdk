// <copyright file="Relationships10.cs" company="APIMatic">
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
    /// Relationships10.
    /// </summary>
    public class Relationships10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships10"/> class.
        /// </summary>
        public Relationships10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships10"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReturnAdmission">direct_debit_return_admission.</param>
        /// <param name="directDebitReturnReversal">direct_debit_return_reversal.</param>
        /// <param name="directDebitReturnSubmission">direct_debit_return_submission.</param>
        public Relationships10(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitReturnAdmission2 directDebitReturnAdmission = null,
            Models.DirectDebitReturnReversal2 directDebitReturnReversal = null,
            Models.DirectDebitReturnSubmission2 directDebitReturnSubmission = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReturnAdmission = directDebitReturnAdmission;
            this.DirectDebitReturnReversal = directDebitReturnReversal;
            this.DirectDebitReturnSubmission = directDebitReturnSubmission;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturnAdmission.
        /// </summary>
        [JsonProperty("direct_debit_return_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnAdmission2 DirectDebitReturnAdmission { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturnReversal.
        /// </summary>
        [JsonProperty("direct_debit_return_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnReversal2 DirectDebitReturnReversal { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturnSubmission.
        /// </summary>
        [JsonProperty("direct_debit_return_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnSubmission2 DirectDebitReturnSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships10 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitReturnAdmission == null && other.DirectDebitReturnAdmission == null) || (this.DirectDebitReturnAdmission?.Equals(other.DirectDebitReturnAdmission) == true)) &&
                ((this.DirectDebitReturnReversal == null && other.DirectDebitReturnReversal == null) || (this.DirectDebitReturnReversal?.Equals(other.DirectDebitReturnReversal) == true)) &&
                ((this.DirectDebitReturnSubmission == null && other.DirectDebitReturnSubmission == null) || (this.DirectDebitReturnSubmission?.Equals(other.DirectDebitReturnSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturnAdmission = {(this.DirectDebitReturnAdmission == null ? "null" : this.DirectDebitReturnAdmission.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturnReversal = {(this.DirectDebitReturnReversal == null ? "null" : this.DirectDebitReturnReversal.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturnSubmission = {(this.DirectDebitReturnSubmission == null ? "null" : this.DirectDebitReturnSubmission.ToString())}");
        }
    }
}