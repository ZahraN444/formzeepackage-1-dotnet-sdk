// <copyright file="Relationships21.cs" company="APIMatic">
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
    /// Relationships21.
    /// </summary>
    public class Relationships21
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships21"/> class.
        /// </summary>
        public Relationships21()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships21"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="recall">recall.</param>
        /// <param name="reversalAdmission">reversal_admission.</param>
        public Relationships21(
            Models.RelationshipLinks payment = null,
            Models.RelationshipLinks recall = null,
            Models.RelationshipLinks reversalAdmission = null)
        {
            this.Payment = payment;
            this.Recall = recall;
            this.ReversalAdmission = reversalAdmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Payment { get; set; }

        /// <summary>
        /// Gets or sets Recall.
        /// </summary>
        [JsonProperty("recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Recall { get; set; }

        /// <summary>
        /// Gets or sets ReversalAdmission.
        /// </summary>
        [JsonProperty("reversal_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks ReversalAdmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships21 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships21 other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Recall == null && other.Recall == null) || (this.Recall?.Equals(other.Recall) == true)) &&
                ((this.ReversalAdmission == null && other.ReversalAdmission == null) || (this.ReversalAdmission?.Equals(other.ReversalAdmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Recall = {(this.Recall == null ? "null" : this.Recall.ToString())}");
            toStringOutput.Add($"this.ReversalAdmission = {(this.ReversalAdmission == null ? "null" : this.ReversalAdmission.ToString())}");
        }
    }
}