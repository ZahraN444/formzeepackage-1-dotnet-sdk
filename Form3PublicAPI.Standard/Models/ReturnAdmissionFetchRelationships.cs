// <copyright file="ReturnAdmissionFetchRelationships.cs" company="APIMatic">
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
    /// ReturnAdmissionFetchRelationships.
    /// </summary>
    public class ReturnAdmissionFetchRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnAdmissionFetchRelationships"/> class.
        /// </summary>
        public ReturnAdmissionFetchRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnAdmissionFetchRelationships"/> class.
        /// </summary>
        /// <param name="beneficiaryAccount">beneficiary_account.</param>
        /// <param name="payment">payment.</param>
        /// <param name="paymentReturn">payment_return.</param>
        /// <param name="validations">validations.</param>
        public ReturnAdmissionFetchRelationships(
            Models.RelationshipReturnAdmissionBeneficiaryAccount beneficiaryAccount = null,
            Models.RelationshipLinks payment = null,
            Models.RelationshipLinks paymentReturn = null,
            Models.RelationshipLinks validations = null)
        {
            this.BeneficiaryAccount = beneficiaryAccount;
            this.Payment = payment;
            this.PaymentReturn = paymentReturn;
            this.Validations = validations;
        }

        /// <summary>
        /// Gets or sets BeneficiaryAccount.
        /// </summary>
        [JsonProperty("beneficiary_account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReturnAdmissionBeneficiaryAccount BeneficiaryAccount { get; set; }

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
        /// Gets or sets Validations.
        /// </summary>
        [JsonProperty("validations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Validations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnAdmissionFetchRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnAdmissionFetchRelationships other &&                ((this.BeneficiaryAccount == null && other.BeneficiaryAccount == null) || (this.BeneficiaryAccount?.Equals(other.BeneficiaryAccount) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentReturn == null && other.PaymentReturn == null) || (this.PaymentReturn?.Equals(other.PaymentReturn) == true)) &&
                ((this.Validations == null && other.Validations == null) || (this.Validations?.Equals(other.Validations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BeneficiaryAccount = {(this.BeneficiaryAccount == null ? "null" : this.BeneficiaryAccount.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentReturn = {(this.PaymentReturn == null ? "null" : this.PaymentReturn.ToString())}");
            toStringOutput.Add($"this.Validations = {(this.Validations == null ? "null" : this.Validations.ToString())}");
        }
    }
}