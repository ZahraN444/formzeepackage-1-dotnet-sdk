// <copyright file="ReturnReversalAdmissionRelationships.cs" company="APIMatic">
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
    /// ReturnReversalAdmissionRelationships.
    /// </summary>
    public class ReturnReversalAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnReversalAdmissionRelationships"/> class.
        /// </summary>
        public ReturnReversalAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnReversalAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentReturn">payment_return.</param>
        /// <param name="paymentReturnReversal">payment_return_reversal.</param>
        public ReturnReversalAdmissionRelationships(
            Models.RelationshipPayments payment = null,
            Models.RelationshipReturns paymentReturn = null,
            Models.RelationshipReturnReversals paymentReturnReversal = null)
        {
            this.Payment = payment;
            this.PaymentReturn = paymentReturn;
            this.PaymentReturnReversal = paymentReturnReversal;
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
        /// Gets or sets PaymentReturnReversal.
        /// </summary>
        [JsonProperty("payment_return_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReturnReversals PaymentReturnReversal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnReversalAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnReversalAdmissionRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentReturn == null && other.PaymentReturn == null) || (this.PaymentReturn?.Equals(other.PaymentReturn) == true)) &&
                ((this.PaymentReturnReversal == null && other.PaymentReturnReversal == null) || (this.PaymentReturnReversal?.Equals(other.PaymentReturnReversal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentReturn = {(this.PaymentReturn == null ? "null" : this.PaymentReturn.ToString())}");
            toStringOutput.Add($"this.PaymentReturnReversal = {(this.PaymentReturnReversal == null ? "null" : this.PaymentReturnReversal.ToString())}");
        }
    }
}