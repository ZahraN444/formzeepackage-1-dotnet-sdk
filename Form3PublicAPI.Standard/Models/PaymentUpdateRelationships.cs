// <copyright file="PaymentUpdateRelationships.cs" company="APIMatic">
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
    /// PaymentUpdateRelationships.
    /// </summary>
    public class PaymentUpdateRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUpdateRelationships"/> class.
        /// </summary>
        public PaymentUpdateRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUpdateRelationships"/> class.
        /// </summary>
        /// <param name="beneficiary">beneficiary.</param>
        /// <param name="beneficiaryAccount">beneficiary_account.</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="debtorAccount">debtor_account.</param>
        /// <param name="forwardingPayment">forwarding_payment.</param>
        /// <param name="fxDeal">fx_deal.</param>
        /// <param name="paymentAdmission">payment_admission.</param>
        /// <param name="paymentAdvice">payment_advice.</param>
        /// <param name="paymentRecall">payment_recall.</param>
        /// <param name="paymentReturn">payment_return.</param>
        /// <param name="paymentReversal">payment_reversal.</param>
        /// <param name="paymentSubmission">payment_submission.</param>
        public PaymentUpdateRelationships(
            Models.Beneficiary beneficiary = null,
            Models.BeneficiaryAccount beneficiaryAccount = null,
            Models.Debtor debtor = null,
            Models.DebtorAccount debtorAccount = null,
            Models.ForwardingPayment1 forwardingPayment = null,
            Models.FxDeal fxDeal = null,
            Models.PaymentAdmission2 paymentAdmission = null,
            Models.PaymentAdvice1 paymentAdvice = null,
            Models.PaymentRecall paymentRecall = null,
            Models.PaymentReturn paymentReturn = null,
            Models.PaymentReversal paymentReversal = null,
            Models.PaymentSubmission2 paymentSubmission = null)
        {
            this.Beneficiary = beneficiary;
            this.BeneficiaryAccount = beneficiaryAccount;
            this.Debtor = debtor;
            this.DebtorAccount = debtorAccount;
            this.ForwardingPayment = forwardingPayment;
            this.FxDeal = fxDeal;
            this.PaymentAdmission = paymentAdmission;
            this.PaymentAdvice = paymentAdvice;
            this.PaymentRecall = paymentRecall;
            this.PaymentReturn = paymentReturn;
            this.PaymentReversal = paymentReversal;
            this.PaymentSubmission = paymentSubmission;
        }

        /// <summary>
        /// Gets or sets Beneficiary.
        /// </summary>
        [JsonProperty("beneficiary", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Beneficiary Beneficiary { get; set; }

        /// <summary>
        /// Gets or sets BeneficiaryAccount.
        /// </summary>
        [JsonProperty("beneficiary_account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryAccount BeneficiaryAccount { get; set; }

        /// <summary>
        /// Gets or sets Debtor.
        /// </summary>
        [JsonProperty("debtor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Debtor Debtor { get; set; }

        /// <summary>
        /// Gets or sets DebtorAccount.
        /// </summary>
        [JsonProperty("debtor_account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DebtorAccount DebtorAccount { get; set; }

        /// <summary>
        /// Gets or sets ForwardingPayment.
        /// </summary>
        [JsonProperty("forwarding_payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ForwardingPayment1 ForwardingPayment { get; set; }

        /// <summary>
        /// Gets or sets FxDeal.
        /// </summary>
        [JsonProperty("fx_deal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FxDeal FxDeal { get; set; }

        /// <summary>
        /// Gets or sets PaymentAdmission.
        /// </summary>
        [JsonProperty("payment_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdmission2 PaymentAdmission { get; set; }

        /// <summary>
        /// Gets or sets PaymentAdvice.
        /// </summary>
        [JsonProperty("payment_advice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdvice1 PaymentAdvice { get; set; }

        /// <summary>
        /// Gets or sets PaymentRecall.
        /// </summary>
        [JsonProperty("payment_recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentRecall PaymentRecall { get; set; }

        /// <summary>
        /// Gets or sets PaymentReturn.
        /// </summary>
        [JsonProperty("payment_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentReturn PaymentReturn { get; set; }

        /// <summary>
        /// Gets or sets PaymentReversal.
        /// </summary>
        [JsonProperty("payment_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentReversal PaymentReversal { get; set; }

        /// <summary>
        /// Gets or sets PaymentSubmission.
        /// </summary>
        [JsonProperty("payment_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentSubmission2 PaymentSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentUpdateRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentUpdateRelationships other &&                ((this.Beneficiary == null && other.Beneficiary == null) || (this.Beneficiary?.Equals(other.Beneficiary) == true)) &&
                ((this.BeneficiaryAccount == null && other.BeneficiaryAccount == null) || (this.BeneficiaryAccount?.Equals(other.BeneficiaryAccount) == true)) &&
                ((this.Debtor == null && other.Debtor == null) || (this.Debtor?.Equals(other.Debtor) == true)) &&
                ((this.DebtorAccount == null && other.DebtorAccount == null) || (this.DebtorAccount?.Equals(other.DebtorAccount) == true)) &&
                ((this.ForwardingPayment == null && other.ForwardingPayment == null) || (this.ForwardingPayment?.Equals(other.ForwardingPayment) == true)) &&
                ((this.FxDeal == null && other.FxDeal == null) || (this.FxDeal?.Equals(other.FxDeal) == true)) &&
                ((this.PaymentAdmission == null && other.PaymentAdmission == null) || (this.PaymentAdmission?.Equals(other.PaymentAdmission) == true)) &&
                ((this.PaymentAdvice == null && other.PaymentAdvice == null) || (this.PaymentAdvice?.Equals(other.PaymentAdvice) == true)) &&
                ((this.PaymentRecall == null && other.PaymentRecall == null) || (this.PaymentRecall?.Equals(other.PaymentRecall) == true)) &&
                ((this.PaymentReturn == null && other.PaymentReturn == null) || (this.PaymentReturn?.Equals(other.PaymentReturn) == true)) &&
                ((this.PaymentReversal == null && other.PaymentReversal == null) || (this.PaymentReversal?.Equals(other.PaymentReversal) == true)) &&
                ((this.PaymentSubmission == null && other.PaymentSubmission == null) || (this.PaymentSubmission?.Equals(other.PaymentSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Beneficiary = {(this.Beneficiary == null ? "null" : this.Beneficiary.ToString())}");
            toStringOutput.Add($"this.BeneficiaryAccount = {(this.BeneficiaryAccount == null ? "null" : this.BeneficiaryAccount.ToString())}");
            toStringOutput.Add($"this.Debtor = {(this.Debtor == null ? "null" : this.Debtor.ToString())}");
            toStringOutput.Add($"this.DebtorAccount = {(this.DebtorAccount == null ? "null" : this.DebtorAccount.ToString())}");
            toStringOutput.Add($"this.ForwardingPayment = {(this.ForwardingPayment == null ? "null" : this.ForwardingPayment.ToString())}");
            toStringOutput.Add($"this.FxDeal = {(this.FxDeal == null ? "null" : this.FxDeal.ToString())}");
            toStringOutput.Add($"this.PaymentAdmission = {(this.PaymentAdmission == null ? "null" : this.PaymentAdmission.ToString())}");
            toStringOutput.Add($"this.PaymentAdvice = {(this.PaymentAdvice == null ? "null" : this.PaymentAdvice.ToString())}");
            toStringOutput.Add($"this.PaymentRecall = {(this.PaymentRecall == null ? "null" : this.PaymentRecall.ToString())}");
            toStringOutput.Add($"this.PaymentReturn = {(this.PaymentReturn == null ? "null" : this.PaymentReturn.ToString())}");
            toStringOutput.Add($"this.PaymentReversal = {(this.PaymentReversal == null ? "null" : this.PaymentReversal.ToString())}");
            toStringOutput.Add($"this.PaymentSubmission = {(this.PaymentSubmission == null ? "null" : this.PaymentSubmission.ToString())}");
        }
    }
}