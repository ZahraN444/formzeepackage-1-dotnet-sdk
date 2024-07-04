// <copyright file="Relationships2.cs" company="APIMatic">
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
    /// Relationships2.
    /// </summary>
    public class Relationships2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships2"/> class.
        /// </summary>
        public Relationships2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships2"/> class.
        /// </summary>
        /// <param name="beneficiaryAccount">beneficiary_account.</param>
        /// <param name="payment">payment.</param>
        /// <param name="paymentAdmissionTask">payment_admission_task.</param>
        public Relationships2(
            Models.RelationshipPaymentAdmissionBeneficiaryAccount beneficiaryAccount = null,
            Models.RelationshipPayments payment = null,
            Models.RelationshipPaymentAdmissionTasks paymentAdmissionTask = null)
        {
            this.BeneficiaryAccount = beneficiaryAccount;
            this.Payment = payment;
            this.PaymentAdmissionTask = paymentAdmissionTask;
        }

        /// <summary>
        /// Gets or sets BeneficiaryAccount.
        /// </summary>
        [JsonProperty("beneficiary_account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPaymentAdmissionBeneficiaryAccount BeneficiaryAccount { get; set; }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentAdmissionTask.
        /// </summary>
        [JsonProperty("payment_admission_task", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPaymentAdmissionTasks PaymentAdmissionTask { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships2 other &&                ((this.BeneficiaryAccount == null && other.BeneficiaryAccount == null) || (this.BeneficiaryAccount?.Equals(other.BeneficiaryAccount) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentAdmissionTask == null && other.PaymentAdmissionTask == null) || (this.PaymentAdmissionTask?.Equals(other.PaymentAdmissionTask) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BeneficiaryAccount = {(this.BeneficiaryAccount == null ? "null" : this.BeneficiaryAccount.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentAdmissionTask = {(this.PaymentAdmissionTask == null ? "null" : this.PaymentAdmissionTask.ToString())}");
        }
    }
}