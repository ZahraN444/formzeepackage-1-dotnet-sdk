// <copyright file="Relationships5.cs" company="APIMatic">
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
    /// Relationships5.
    /// </summary>
    public class Relationships5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships5"/> class.
        /// </summary>
        public Relationships5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships5"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitDecisionAdmission">direct_debit_decision_admission.</param>
        /// <param name="directDebitDecisionSubmission">direct_debit_decision_submission.</param>
        public Relationships5(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitDecisionAdmission2 directDebitDecisionAdmission = null,
            Models.DirectDebitDecisionSubmission2 directDebitDecisionSubmission = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitDecisionAdmission = directDebitDecisionAdmission;
            this.DirectDebitDecisionSubmission = directDebitDecisionSubmission;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitDecisionAdmission.
        /// </summary>
        [JsonProperty("direct_debit_decision_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDecisionAdmission2 DirectDebitDecisionAdmission { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitDecisionSubmission.
        /// </summary>
        [JsonProperty("direct_debit_decision_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDecisionSubmission2 DirectDebitDecisionSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships5 other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitDecisionAdmission == null && other.DirectDebitDecisionAdmission == null) || (this.DirectDebitDecisionAdmission?.Equals(other.DirectDebitDecisionAdmission) == true)) &&
                ((this.DirectDebitDecisionSubmission == null && other.DirectDebitDecisionSubmission == null) || (this.DirectDebitDecisionSubmission?.Equals(other.DirectDebitDecisionSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitDecisionAdmission = {(this.DirectDebitDecisionAdmission == null ? "null" : this.DirectDebitDecisionAdmission.ToString())}");
            toStringOutput.Add($"this.DirectDebitDecisionSubmission = {(this.DirectDebitDecisionSubmission == null ? "null" : this.DirectDebitDecisionSubmission.ToString())}");
        }
    }
}