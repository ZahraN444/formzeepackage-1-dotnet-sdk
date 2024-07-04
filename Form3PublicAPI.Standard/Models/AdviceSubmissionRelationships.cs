// <copyright file="AdviceSubmissionRelationships.cs" company="APIMatic">
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
    /// AdviceSubmissionRelationships.
    /// </summary>
    public class AdviceSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdviceSubmissionRelationships"/> class.
        /// </summary>
        public AdviceSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdviceSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="advice">advice.</param>
        /// <param name="payment">payment.</param>
        public AdviceSubmissionRelationships(
            Models.RelationshipAdvices advice = null,
            Models.RelationshipPayments payment = null)
        {
            this.Advice = advice;
            this.Payment = payment;
        }

        /// <summary>
        /// Gets or sets Advice.
        /// </summary>
        [JsonProperty("advice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipAdvices Advice { get; set; }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdviceSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdviceSubmissionRelationships other &&                ((this.Advice == null && other.Advice == null) || (this.Advice?.Equals(other.Advice) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Advice = {(this.Advice == null ? "null" : this.Advice.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
        }
    }
}