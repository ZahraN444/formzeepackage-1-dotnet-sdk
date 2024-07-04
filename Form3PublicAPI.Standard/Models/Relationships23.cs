// <copyright file="Relationships23.cs" company="APIMatic">
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
    /// Relationships23.
    /// </summary>
    public class Relationships23
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships23"/> class.
        /// </summary>
        public Relationships23()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships23"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentReturn">payment_return.</param>
        /// <param name="returnReversalAdmission">return_reversal_admission.</param>
        public Relationships23(
            Models.RelationshipLinks payment = null,
            Models.RelationshipLinks paymentReturn = null,
            Models.RelationshipLinks returnReversalAdmission = null)
        {
            this.Payment = payment;
            this.PaymentReturn = paymentReturn;
            this.ReturnReversalAdmission = returnReversalAdmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentReturn.
        /// </summary>
        [JsonProperty("payment_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks PaymentReturn { get; set; }

        /// <summary>
        /// Gets or sets ReturnReversalAdmission.
        /// </summary>
        [JsonProperty("return_reversal_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks ReturnReversalAdmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships23 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships23 other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentReturn == null && other.PaymentReturn == null) || (this.PaymentReturn?.Equals(other.PaymentReturn) == true)) &&
                ((this.ReturnReversalAdmission == null && other.ReturnReversalAdmission == null) || (this.ReturnReversalAdmission?.Equals(other.ReturnReversalAdmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentReturn = {(this.PaymentReturn == null ? "null" : this.PaymentReturn.ToString())}");
            toStringOutput.Add($"this.ReturnReversalAdmission = {(this.ReturnReversalAdmission == null ? "null" : this.ReturnReversalAdmission.ToString())}");
        }
    }
}