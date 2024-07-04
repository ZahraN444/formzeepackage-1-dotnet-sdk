// <copyright file="PaymentAdmissionTaskRelationships.cs" company="APIMatic">
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
    /// PaymentAdmissionTaskRelationships.
    /// </summary>
    public class PaymentAdmissionTaskRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdmissionTaskRelationships"/> class.
        /// </summary>
        public PaymentAdmissionTaskRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdmissionTaskRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentAdmission">payment_admission.</param>
        /// <param name="paymentAdmissionTask">payment_admission_task.</param>
        public PaymentAdmissionTaskRelationships(
            Models.RelationshipPayments payment = null,
            Models.RelationshipPaymentAdmissions paymentAdmission = null,
            Models.RelationshipPaymentAdmissionTask paymentAdmissionTask = null)
        {
            this.Payment = payment;
            this.PaymentAdmission = paymentAdmission;
            this.PaymentAdmissionTask = paymentAdmissionTask;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentAdmission.
        /// </summary>
        [JsonProperty("payment_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPaymentAdmissions PaymentAdmission { get; set; }

        /// <summary>
        /// Gets or sets PaymentAdmissionTask.
        /// </summary>
        [JsonProperty("payment_admission_task", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPaymentAdmissionTask PaymentAdmissionTask { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentAdmissionTaskRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentAdmissionTaskRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentAdmission == null && other.PaymentAdmission == null) || (this.PaymentAdmission?.Equals(other.PaymentAdmission) == true)) &&
                ((this.PaymentAdmissionTask == null && other.PaymentAdmissionTask == null) || (this.PaymentAdmissionTask?.Equals(other.PaymentAdmissionTask) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentAdmission = {(this.PaymentAdmission == null ? "null" : this.PaymentAdmission.ToString())}");
            toStringOutput.Add($"this.PaymentAdmissionTask = {(this.PaymentAdmissionTask == null ? "null" : this.PaymentAdmissionTask.ToString())}");
        }
    }
}