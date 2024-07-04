// <copyright file="Relationships7.cs" company="APIMatic">
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
    /// Relationships7.
    /// </summary>
    public class Relationships7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships7"/> class.
        /// </summary>
        public Relationships7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships7"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitRecallAdmission">direct_debit_recall_admission.</param>
        /// <param name="directDebitRecallSubmission">direct_debit_recall_submission.</param>
        public Relationships7(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitRecallAdmission2 directDebitRecallAdmission = null,
            Models.DirectDebitRecallSubmission2 directDebitRecallSubmission = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitRecallAdmission = directDebitRecallAdmission;
            this.DirectDebitRecallSubmission = directDebitRecallSubmission;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitRecallAdmission.
        /// </summary>
        [JsonProperty("direct_debit_recall_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitRecallAdmission2 DirectDebitRecallAdmission { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitRecallSubmission.
        /// </summary>
        [JsonProperty("direct_debit_recall_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitRecallSubmission2 DirectDebitRecallSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships7 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitRecallAdmission == null && other.DirectDebitRecallAdmission == null) || (this.DirectDebitRecallAdmission?.Equals(other.DirectDebitRecallAdmission) == true)) &&
                ((this.DirectDebitRecallSubmission == null && other.DirectDebitRecallSubmission == null) || (this.DirectDebitRecallSubmission?.Equals(other.DirectDebitRecallSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitRecallAdmission = {(this.DirectDebitRecallAdmission == null ? "null" : this.DirectDebitRecallAdmission.ToString())}");
            toStringOutput.Add($"this.DirectDebitRecallSubmission = {(this.DirectDebitRecallSubmission == null ? "null" : this.DirectDebitRecallSubmission.ToString())}");
        }
    }
}