// <copyright file="Relationships14.cs" company="APIMatic">
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
    /// Relationships14.
    /// </summary>
    public class Relationships14
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships14"/> class.
        /// </summary>
        public Relationships14()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships14"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitReversalAdmission">direct_debit_reversal_admission.</param>
        /// <param name="directDebitReversalSubmission">direct_debit_reversal_submission.</param>
        public Relationships14(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitReversalAdmission2 directDebitReversalAdmission = null,
            Models.DirectDebitReversalSubmission2 directDebitReversalSubmission = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitReversalAdmission = directDebitReversalAdmission;
            this.DirectDebitReversalSubmission = directDebitReversalSubmission;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReversalAdmission.
        /// </summary>
        [JsonProperty("direct_debit_reversal_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReversalAdmission2 DirectDebitReversalAdmission { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReversalSubmission.
        /// </summary>
        [JsonProperty("direct_debit_reversal_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReversalSubmission2 DirectDebitReversalSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships14 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships14 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitReversalAdmission == null && other.DirectDebitReversalAdmission == null) || (this.DirectDebitReversalAdmission?.Equals(other.DirectDebitReversalAdmission) == true)) &&
                ((this.DirectDebitReversalSubmission == null && other.DirectDebitReversalSubmission == null) || (this.DirectDebitReversalSubmission?.Equals(other.DirectDebitReversalSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitReversalAdmission = {(this.DirectDebitReversalAdmission == null ? "null" : this.DirectDebitReversalAdmission.ToString())}");
            toStringOutput.Add($"this.DirectDebitReversalSubmission = {(this.DirectDebitReversalSubmission == null ? "null" : this.DirectDebitReversalSubmission.ToString())}");
        }
    }
}