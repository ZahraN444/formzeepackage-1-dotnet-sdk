// <copyright file="Relationships1.cs" company="APIMatic">
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
    /// Relationships1.
    /// </summary>
    public class Relationships1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships1"/> class.
        /// </summary>
        public Relationships1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships1"/> class.
        /// </summary>
        /// <param name="adviceSubmission">advice_submission.</param>
        /// <param name="payment">payment.</param>
        public Relationships1(
            Models.RelationshipLinks adviceSubmission = null,
            Models.RelationshipLinks payment = null)
        {
            this.AdviceSubmission = adviceSubmission;
            this.Payment = payment;
        }

        /// <summary>
        /// Gets or sets AdviceSubmission.
        /// </summary>
        [JsonProperty("advice_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks AdviceSubmission { get; set; }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Payment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships1 other &&                ((this.AdviceSubmission == null && other.AdviceSubmission == null) || (this.AdviceSubmission?.Equals(other.AdviceSubmission) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdviceSubmission = {(this.AdviceSubmission == null ? "null" : this.AdviceSubmission.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
        }
    }
}