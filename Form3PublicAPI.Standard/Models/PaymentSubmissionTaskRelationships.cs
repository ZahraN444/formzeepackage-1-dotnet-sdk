// <copyright file="PaymentSubmissionTaskRelationships.cs" company="APIMatic">
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
    /// PaymentSubmissionTaskRelationships.
    /// </summary>
    public class PaymentSubmissionTaskRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSubmissionTaskRelationships"/> class.
        /// </summary>
        public PaymentSubmissionTaskRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSubmissionTaskRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentSubmission">payment_submission.</param>
        public PaymentSubmissionTaskRelationships(
            Models.RelationshipPayments payment = null,
            Models.RelationshipPaymentSubmissions paymentSubmission = null)
        {
            this.Payment = payment;
            this.PaymentSubmission = paymentSubmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentSubmission.
        /// </summary>
        [JsonProperty("payment_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPaymentSubmissions PaymentSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentSubmissionTaskRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentSubmissionTaskRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentSubmission == null && other.PaymentSubmission == null) || (this.PaymentSubmission?.Equals(other.PaymentSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentSubmission = {(this.PaymentSubmission == null ? "null" : this.PaymentSubmission.ToString())}");
        }
    }
}