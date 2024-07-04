// <copyright file="ReturnPaymentRelationships.cs" company="APIMatic">
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
    /// ReturnPaymentRelationships.
    /// </summary>
    public class ReturnPaymentRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPaymentRelationships"/> class.
        /// </summary>
        public ReturnPaymentRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPaymentRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="returnAdmission">return_admission.</param>
        /// <param name="returnReversal">return_reversal.</param>
        /// <param name="returnSubmission">return_submission.</param>
        public ReturnPaymentRelationships(
            Models.RelationshipPayments payment = null,
            Models.ReturnAdmission2 returnAdmission = null,
            Models.RelationshipLinks returnReversal = null,
            Models.ReturnSubmission2 returnSubmission = null)
        {
            this.Payment = payment;
            this.ReturnAdmission = returnAdmission;
            this.ReturnReversal = returnReversal;
            this.ReturnSubmission = returnSubmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets ReturnAdmission.
        /// </summary>
        [JsonProperty("return_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnAdmission2 ReturnAdmission { get; set; }

        /// <summary>
        /// Gets or sets ReturnReversal.
        /// </summary>
        [JsonProperty("return_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks ReturnReversal { get; set; }

        /// <summary>
        /// Gets or sets ReturnSubmission.
        /// </summary>
        [JsonProperty("return_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnSubmission2 ReturnSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnPaymentRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnPaymentRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.ReturnAdmission == null && other.ReturnAdmission == null) || (this.ReturnAdmission?.Equals(other.ReturnAdmission) == true)) &&
                ((this.ReturnReversal == null && other.ReturnReversal == null) || (this.ReturnReversal?.Equals(other.ReturnReversal) == true)) &&
                ((this.ReturnSubmission == null && other.ReturnSubmission == null) || (this.ReturnSubmission?.Equals(other.ReturnSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.ReturnAdmission = {(this.ReturnAdmission == null ? "null" : this.ReturnAdmission.ToString())}");
            toStringOutput.Add($"this.ReturnReversal = {(this.ReturnReversal == null ? "null" : this.ReturnReversal.ToString())}");
            toStringOutput.Add($"this.ReturnSubmission = {(this.ReturnSubmission == null ? "null" : this.ReturnSubmission.ToString())}");
        }
    }
}