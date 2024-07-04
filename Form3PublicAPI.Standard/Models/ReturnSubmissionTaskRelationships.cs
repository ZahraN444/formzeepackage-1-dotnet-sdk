// <copyright file="ReturnSubmissionTaskRelationships.cs" company="APIMatic">
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
    /// ReturnSubmissionTaskRelationships.
    /// </summary>
    public class ReturnSubmissionTaskRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionTaskRelationships"/> class.
        /// </summary>
        public ReturnSubmissionTaskRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionTaskRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentReturn">payment_return.</param>
        /// <param name="returnSubmission">return_submission.</param>
        public ReturnSubmissionTaskRelationships(
            Models.RelationshipPayments payment = null,
            Models.RelationshipReturns paymentReturn = null,
            Models.RelationshipReturnSubmissions returnSubmission = null)
        {
            this.Payment = payment;
            this.PaymentReturn = paymentReturn;
            this.ReturnSubmission = returnSubmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentReturn.
        /// </summary>
        [JsonProperty("payment_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReturns PaymentReturn { get; set; }

        /// <summary>
        /// Gets or sets ReturnSubmission.
        /// </summary>
        [JsonProperty("return_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReturnSubmissions ReturnSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnSubmissionTaskRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnSubmissionTaskRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentReturn == null && other.PaymentReturn == null) || (this.PaymentReturn?.Equals(other.PaymentReturn) == true)) &&
                ((this.ReturnSubmission == null && other.ReturnSubmission == null) || (this.ReturnSubmission?.Equals(other.ReturnSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentReturn = {(this.PaymentReturn == null ? "null" : this.PaymentReturn.ToString())}");
            toStringOutput.Add($"this.ReturnSubmission = {(this.ReturnSubmission == null ? "null" : this.ReturnSubmission.ToString())}");
        }
    }
}