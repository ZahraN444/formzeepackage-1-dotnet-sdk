// <copyright file="QueryResponseInformation.cs" company="APIMatic">
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
    /// QueryResponseInformation.
    /// </summary>
    public class QueryResponseInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseInformation"/> class.
        /// </summary>
        public QueryResponseInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseInformation"/> class.
        /// </summary>
        /// <param name="beneficiaryParty">beneficiary_party.</param>
        /// <param name="correctionTransactionInformation">correction_transaction_information.</param>
        /// <param name="debtorParty">debtor_party.</param>
        /// <param name="duplicateTransactionInformation">duplicate_transaction_information.</param>
        /// <param name="paymentTypeInformation">payment_type_information.</param>
        /// <param name="references">references.</param>
        /// <param name="ultimateBeneficiaryParty">ultimate_beneficiary_party.</param>
        /// <param name="ultimateDebtorParty">ultimate_debtor_party.</param>
        public QueryResponseInformation(
            Models.QueryBeneficiaryDebtorParty beneficiaryParty = null,
            Models.CorrectionTransactionInformation correctionTransactionInformation = null,
            Models.QueryBeneficiaryDebtorParty debtorParty = null,
            Models.DuplicateTransactionInformation duplicateTransactionInformation = null,
            Models.PaymentTypeInformation paymentTypeInformation = null,
            List<Models.QueryReference> references = null,
            Models.QueryUltimateEntity ultimateBeneficiaryParty = null,
            Models.QueryUltimateEntity ultimateDebtorParty = null)
        {
            this.BeneficiaryParty = beneficiaryParty;
            this.CorrectionTransactionInformation = correctionTransactionInformation;
            this.DebtorParty = debtorParty;
            this.DuplicateTransactionInformation = duplicateTransactionInformation;
            this.PaymentTypeInformation = paymentTypeInformation;
            this.References = references;
            this.UltimateBeneficiaryParty = ultimateBeneficiaryParty;
            this.UltimateDebtorParty = ultimateDebtorParty;
        }

        /// <summary>
        /// Gets or sets BeneficiaryParty.
        /// </summary>
        [JsonProperty("beneficiary_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryBeneficiaryDebtorParty BeneficiaryParty { get; set; }

        /// <summary>
        /// References a transaction initiated to fix the case under investigation.
        /// </summary>
        [JsonProperty("correction_transaction_information", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CorrectionTransactionInformation CorrectionTransactionInformation { get; set; }

        /// <summary>
        /// Gets or sets DebtorParty.
        /// </summary>
        [JsonProperty("debtor_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryBeneficiaryDebtorParty DebtorParty { get; set; }

        /// <summary>
        /// Gets or sets DuplicateTransactionInformation.
        /// </summary>
        [JsonProperty("duplicate_transaction_information", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DuplicateTransactionInformation DuplicateTransactionInformation { get; set; }

        /// <summary>
        /// Set of elements used to further specify the type of transaction.
        /// </summary>
        [JsonProperty("payment_type_information", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentTypeInformation PaymentTypeInformation { get; set; }

        /// <summary>
        /// Reference for the case ID associated to this Exception and Investigation case.
        /// </summary>
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.QueryReference> References { get; set; }

        /// <summary>
        /// Gets or sets UltimateBeneficiaryParty.
        /// </summary>
        [JsonProperty("ultimate_beneficiary_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryUltimateEntity UltimateBeneficiaryParty { get; set; }

        /// <summary>
        /// Gets or sets UltimateDebtorParty.
        /// </summary>
        [JsonProperty("ultimate_debtor_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryUltimateEntity UltimateDebtorParty { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseInformation other &&                ((this.BeneficiaryParty == null && other.BeneficiaryParty == null) || (this.BeneficiaryParty?.Equals(other.BeneficiaryParty) == true)) &&
                ((this.CorrectionTransactionInformation == null && other.CorrectionTransactionInformation == null) || (this.CorrectionTransactionInformation?.Equals(other.CorrectionTransactionInformation) == true)) &&
                ((this.DebtorParty == null && other.DebtorParty == null) || (this.DebtorParty?.Equals(other.DebtorParty) == true)) &&
                ((this.DuplicateTransactionInformation == null && other.DuplicateTransactionInformation == null) || (this.DuplicateTransactionInformation?.Equals(other.DuplicateTransactionInformation) == true)) &&
                ((this.PaymentTypeInformation == null && other.PaymentTypeInformation == null) || (this.PaymentTypeInformation?.Equals(other.PaymentTypeInformation) == true)) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.UltimateBeneficiaryParty == null && other.UltimateBeneficiaryParty == null) || (this.UltimateBeneficiaryParty?.Equals(other.UltimateBeneficiaryParty) == true)) &&
                ((this.UltimateDebtorParty == null && other.UltimateDebtorParty == null) || (this.UltimateDebtorParty?.Equals(other.UltimateDebtorParty) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BeneficiaryParty = {(this.BeneficiaryParty == null ? "null" : this.BeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.CorrectionTransactionInformation = {(this.CorrectionTransactionInformation == null ? "null" : this.CorrectionTransactionInformation.ToString())}");
            toStringOutput.Add($"this.DebtorParty = {(this.DebtorParty == null ? "null" : this.DebtorParty.ToString())}");
            toStringOutput.Add($"this.DuplicateTransactionInformation = {(this.DuplicateTransactionInformation == null ? "null" : this.DuplicateTransactionInformation.ToString())}");
            toStringOutput.Add($"this.PaymentTypeInformation = {(this.PaymentTypeInformation == null ? "null" : this.PaymentTypeInformation.ToString())}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : $"[{string.Join(", ", this.References)} ]")}");
            toStringOutput.Add($"this.UltimateBeneficiaryParty = {(this.UltimateBeneficiaryParty == null ? "null" : this.UltimateBeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.UltimateDebtorParty = {(this.UltimateDebtorParty == null ? "null" : this.UltimateDebtorParty.ToString())}");
        }
    }
}