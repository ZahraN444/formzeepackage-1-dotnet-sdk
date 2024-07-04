// <copyright file="Relationships3.cs" company="APIMatic">
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
    /// Relationships3.
    /// </summary>
    public class Relationships3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships3"/> class.
        /// </summary>
        public Relationships3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships3"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="reversalAdmission">reversal_admission.</param>
        /// <param name="reversalSubmission">reversal_submission.</param>
        public Relationships3(
            Models.RelationshipLinks payment = null,
            Models.ReversalAdmission2 reversalAdmission = null,
            Models.RelationshipLinks reversalSubmission = null)
        {
            this.Payment = payment;
            this.ReversalAdmission = reversalAdmission;
            this.ReversalSubmission = reversalSubmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Payment { get; set; }

        /// <summary>
        /// Gets or sets ReversalAdmission.
        /// </summary>
        [JsonProperty("reversal_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReversalAdmission2 ReversalAdmission { get; set; }

        /// <summary>
        /// Gets or sets ReversalSubmission.
        /// </summary>
        [JsonProperty("reversal_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks ReversalSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships3 other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.ReversalAdmission == null && other.ReversalAdmission == null) || (this.ReversalAdmission?.Equals(other.ReversalAdmission) == true)) &&
                ((this.ReversalSubmission == null && other.ReversalSubmission == null) || (this.ReversalSubmission?.Equals(other.ReversalSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.ReversalAdmission = {(this.ReversalAdmission == null ? "null" : this.ReversalAdmission.ToString())}");
            toStringOutput.Add($"this.ReversalSubmission = {(this.ReversalSubmission == null ? "null" : this.ReversalSubmission.ToString())}");
        }
    }
}