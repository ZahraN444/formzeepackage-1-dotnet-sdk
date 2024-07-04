// <copyright file="Attributes23.cs" company="APIMatic">
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
    /// Attributes23.
    /// </summary>
    public class Attributes23
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes23"/> class.
        /// </summary>
        public Attributes23()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes23"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="beneficiaryParty">beneficiary_party.</param>
        /// <param name="categoryPurpose">category_purpose.</param>
        /// <param name="categoryPurposeCoded">category_purpose_coded.</param>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="debtorParty">debtor_party.</param>
        /// <param name="endToEndReference">end_to_end_reference.</param>
        /// <param name="instructionId">instruction_id.</param>
        /// <param name="mandateAmendmentIndicator">mandate_amendment_indicator.</param>
        /// <param name="mandateId">mandate_id.</param>
        /// <param name="mandateSignatureDate">mandate_signature_date.</param>
        /// <param name="numericReference">numeric_reference.</param>
        /// <param name="paymentPurposeCoded">payment_purpose_coded.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="reference">reference.</param>
        /// <param name="remittanceInformation">remittance_information.</param>
        /// <param name="schemePaymentType">scheme_payment_type.</param>
        /// <param name="schemeProcessingDate">scheme_processing_date.</param>
        /// <param name="schemeStatus">scheme_status.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        /// <param name="settlement">settlement.</param>
        /// <param name="structuredReference">structured_reference.</param>
        /// <param name="ultimateBeneficiary">ultimate_beneficiary.</param>
        /// <param name="ultimateDebtor">ultimate_debtor.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        public Attributes23(
            string amount = null,
            Models.BeneficiaryParty3 beneficiaryParty = null,
            string categoryPurpose = null,
            string categoryPurposeCoded = null,
            string clearingId = null,
            string currency = null,
            Models.DebtorParty2 debtorParty = null,
            string endToEndReference = null,
            string instructionId = null,
            bool? mandateAmendmentIndicator = null,
            string mandateId = null,
            DateTime? mandateSignatureDate = null,
            string numericReference = null,
            string paymentPurposeCoded = null,
            string paymentScheme = null,
            DateTime? processingDate = null,
            string reference = null,
            string remittanceInformation = null,
            string schemePaymentType = null,
            DateTime? schemeProcessingDate = null,
            Models.SchemeStatusEnum? schemeStatus = null,
            string schemeTransactionId = null,
            Models.Settlement settlement = null,
            Models.StructuredReference structuredReference = null,
            Models.UltimateEntity ultimateBeneficiary = null,
            Models.UltimateEntity ultimateDebtor = null,
            string uniqueSchemeId = null)
        {
            this.Amount = amount;
            this.BeneficiaryParty = beneficiaryParty;
            this.CategoryPurpose = categoryPurpose;
            this.CategoryPurposeCoded = categoryPurposeCoded;
            this.ClearingId = clearingId;
            this.Currency = currency;
            this.DebtorParty = debtorParty;
            this.EndToEndReference = endToEndReference;
            this.InstructionId = instructionId;
            this.MandateAmendmentIndicator = mandateAmendmentIndicator;
            this.MandateId = mandateId;
            this.MandateSignatureDate = mandateSignatureDate;
            this.NumericReference = numericReference;
            this.PaymentPurposeCoded = paymentPurposeCoded;
            this.PaymentScheme = paymentScheme;
            this.ProcessingDate = processingDate;
            this.Reference = reference;
            this.RemittanceInformation = remittanceInformation;
            this.SchemePaymentType = schemePaymentType;
            this.SchemeProcessingDate = schemeProcessingDate;
            this.SchemeStatus = schemeStatus;
            this.SchemeTransactionId = schemeTransactionId;
            this.Settlement = settlement;
            this.StructuredReference = structuredReference;
            this.UltimateBeneficiary = ultimateBeneficiary;
            this.UltimateDebtor = ultimateDebtor;
            this.UniqueSchemeId = uniqueSchemeId;
        }

        /// <summary>
        /// Amount of money moved between the instructing agent and instructed agent
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets BeneficiaryParty.
        /// </summary>
        [JsonProperty("beneficiary_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryParty3 BeneficiaryParty { get; set; }

        /// <summary>
        /// Category purpose in proprietary form. Specifies the high level purpose of the instruction. Cannot be used at the same time as `category_purpose_coded`.
        /// </summary>
        [JsonProperty("category_purpose", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryPurpose { get; set; }

        /// <summary>
        /// Category purpose in a coded form. Specifies the high level purpose of the instruction. Cannot be used at the same time as `category_purpose`.
        /// </summary>
        [JsonProperty("category_purpose_coded", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryPurposeCoded { get; set; }

        /// <summary>
        /// Unique identifier for organisations collecting payments
        /// </summary>
        [JsonProperty("clearing_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingId { get; set; }

        /// <summary>
        /// Currency of the transaction amount. Currency code as defined in [ISO 4217](http://www.iso.org/iso/home/standards/currency_codes.htm)
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets DebtorParty.
        /// </summary>
        [JsonProperty("debtor_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DebtorParty2 DebtorParty { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
        /// </summary>
        [JsonProperty("end_to_end_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string EndToEndReference { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the initiating party to unambiguously identify the transaction. This identification is an point-to-point reference and is passed on, unchanged, throughout the entire chain. Cannot include leading, trailing or internal spaces.
        /// </summary>
        [JsonProperty("instruction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstructionId { get; set; }

        /// <summary>
        /// Indicator notifying whether the underlying mandate is amended or not
        /// </summary>
        [JsonProperty("mandate_amendment_indicator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MandateAmendmentIndicator { get; set; }

        /// <summary>
        /// Original mandate id.
        /// </summary>
        [JsonProperty("mandate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MandateId { get; set; }

        /// <summary>
        /// Date on which the direct debit mandate has been signed by the debtor.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("mandate_signature_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MandateSignatureDate { get; set; }

        /// <summary>
        /// Numeric reference field, see scheme specific descriptions for usage
        /// </summary>
        [JsonProperty("numeric_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericReference { get; set; }

        /// <summary>
        /// Purpose of the direct debit in a coded form
        /// </summary>
        [JsonProperty("payment_purpose_coded", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentPurposeCoded { get; set; }

        /// <summary>
        /// Clearing infrastructure through which the operation instruction is to be processed. Default for given organisation ID is used if left empty. Has to be a valid [scheme identifier](http://draft-api-docs.form3.tech/api.html#enumerations-schemes).
        /// </summary>
        [JsonProperty("payment_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentScheme { get; set; }

        /// <summary>
        /// Date on which the operation is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Payment reference for beneficiary use
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts receivable system provided by the debtor for the beneficiary.
        /// </summary>
        [JsonProperty("remittance_information", NullValueHandling = NullValueHandling.Ignore)]
        public string RemittanceInformation { get; set; }

        /// <summary>
        /// The [scheme-specific payment type](#enumerations-scheme-payment-types)
        /// </summary>
        [JsonProperty("scheme_payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemePaymentType { get; set; }

        /// <summary>
        /// Date on which the operation is processed by the scheme. Formatted according to ISO 8601 format: YYYY-MM-DD. Only used if different from `processing_date`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("scheme_processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SchemeProcessingDate { get; set; }

        /// <summary>
        /// This reference is used by the receiving party to identify whether the related DDI would have been electronic (AUDDIS) or paper‐based.
        /// </summary>
        [JsonProperty("scheme_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeStatusEnum? SchemeStatus { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// Specifies the details on how the settlement of the transaction between the instructing agent and the instructed agent is completed
        /// </summary>
        [JsonProperty("settlement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Settlement Settlement { get; set; }

        /// <summary>
        /// Gets or sets StructuredReference.
        /// </summary>
        [JsonProperty("structured_reference", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StructuredReference StructuredReference { get; set; }

        /// <summary>
        /// Gets or sets UltimateBeneficiary.
        /// </summary>
        [JsonProperty("ultimate_beneficiary", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UltimateEntity UltimateBeneficiary { get; set; }

        /// <summary>
        /// Gets or sets UltimateDebtor.
        /// </summary>
        [JsonProperty("ultimate_debtor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UltimateEntity UltimateDebtor { get; set; }

        /// <summary>
        /// The scheme-specific unique transaction ID. Populated by the scheme.
        /// </summary>
        [JsonProperty("unique_scheme_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSchemeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes23 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes23 other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.BeneficiaryParty == null && other.BeneficiaryParty == null) || (this.BeneficiaryParty?.Equals(other.BeneficiaryParty) == true)) &&
                ((this.CategoryPurpose == null && other.CategoryPurpose == null) || (this.CategoryPurpose?.Equals(other.CategoryPurpose) == true)) &&
                ((this.CategoryPurposeCoded == null && other.CategoryPurposeCoded == null) || (this.CategoryPurposeCoded?.Equals(other.CategoryPurposeCoded) == true)) &&
                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.DebtorParty == null && other.DebtorParty == null) || (this.DebtorParty?.Equals(other.DebtorParty) == true)) &&
                ((this.EndToEndReference == null && other.EndToEndReference == null) || (this.EndToEndReference?.Equals(other.EndToEndReference) == true)) &&
                ((this.InstructionId == null && other.InstructionId == null) || (this.InstructionId?.Equals(other.InstructionId) == true)) &&
                ((this.MandateAmendmentIndicator == null && other.MandateAmendmentIndicator == null) || (this.MandateAmendmentIndicator?.Equals(other.MandateAmendmentIndicator) == true)) &&
                ((this.MandateId == null && other.MandateId == null) || (this.MandateId?.Equals(other.MandateId) == true)) &&
                ((this.MandateSignatureDate == null && other.MandateSignatureDate == null) || (this.MandateSignatureDate?.Equals(other.MandateSignatureDate) == true)) &&
                ((this.NumericReference == null && other.NumericReference == null) || (this.NumericReference?.Equals(other.NumericReference) == true)) &&
                ((this.PaymentPurposeCoded == null && other.PaymentPurposeCoded == null) || (this.PaymentPurposeCoded?.Equals(other.PaymentPurposeCoded) == true)) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.RemittanceInformation == null && other.RemittanceInformation == null) || (this.RemittanceInformation?.Equals(other.RemittanceInformation) == true)) &&
                ((this.SchemePaymentType == null && other.SchemePaymentType == null) || (this.SchemePaymentType?.Equals(other.SchemePaymentType) == true)) &&
                ((this.SchemeProcessingDate == null && other.SchemeProcessingDate == null) || (this.SchemeProcessingDate?.Equals(other.SchemeProcessingDate) == true)) &&
                ((this.SchemeStatus == null && other.SchemeStatus == null) || (this.SchemeStatus?.Equals(other.SchemeStatus) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true)) &&
                ((this.Settlement == null && other.Settlement == null) || (this.Settlement?.Equals(other.Settlement) == true)) &&
                ((this.StructuredReference == null && other.StructuredReference == null) || (this.StructuredReference?.Equals(other.StructuredReference) == true)) &&
                ((this.UltimateBeneficiary == null && other.UltimateBeneficiary == null) || (this.UltimateBeneficiary?.Equals(other.UltimateBeneficiary) == true)) &&
                ((this.UltimateDebtor == null && other.UltimateDebtor == null) || (this.UltimateDebtor?.Equals(other.UltimateDebtor) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.BeneficiaryParty = {(this.BeneficiaryParty == null ? "null" : this.BeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.CategoryPurpose = {(this.CategoryPurpose == null ? "null" : this.CategoryPurpose)}");
            toStringOutput.Add($"this.CategoryPurposeCoded = {(this.CategoryPurposeCoded == null ? "null" : this.CategoryPurposeCoded)}");
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.DebtorParty = {(this.DebtorParty == null ? "null" : this.DebtorParty.ToString())}");
            toStringOutput.Add($"this.EndToEndReference = {(this.EndToEndReference == null ? "null" : this.EndToEndReference)}");
            toStringOutput.Add($"this.InstructionId = {(this.InstructionId == null ? "null" : this.InstructionId)}");
            toStringOutput.Add($"this.MandateAmendmentIndicator = {(this.MandateAmendmentIndicator == null ? "null" : this.MandateAmendmentIndicator.ToString())}");
            toStringOutput.Add($"this.MandateId = {(this.MandateId == null ? "null" : this.MandateId)}");
            toStringOutput.Add($"this.MandateSignatureDate = {(this.MandateSignatureDate == null ? "null" : this.MandateSignatureDate.ToString())}");
            toStringOutput.Add($"this.NumericReference = {(this.NumericReference == null ? "null" : this.NumericReference)}");
            toStringOutput.Add($"this.PaymentPurposeCoded = {(this.PaymentPurposeCoded == null ? "null" : this.PaymentPurposeCoded)}");
            toStringOutput.Add($"this.PaymentScheme = {(this.PaymentScheme == null ? "null" : this.PaymentScheme)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.RemittanceInformation = {(this.RemittanceInformation == null ? "null" : this.RemittanceInformation)}");
            toStringOutput.Add($"this.SchemePaymentType = {(this.SchemePaymentType == null ? "null" : this.SchemePaymentType)}");
            toStringOutput.Add($"this.SchemeProcessingDate = {(this.SchemeProcessingDate == null ? "null" : this.SchemeProcessingDate.ToString())}");
            toStringOutput.Add($"this.SchemeStatus = {(this.SchemeStatus == null ? "null" : this.SchemeStatus.ToString())}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
            toStringOutput.Add($"this.Settlement = {(this.Settlement == null ? "null" : this.Settlement.ToString())}");
            toStringOutput.Add($"this.StructuredReference = {(this.StructuredReference == null ? "null" : this.StructuredReference.ToString())}");
            toStringOutput.Add($"this.UltimateBeneficiary = {(this.UltimateBeneficiary == null ? "null" : this.UltimateBeneficiary.ToString())}");
            toStringOutput.Add($"this.UltimateDebtor = {(this.UltimateDebtor == null ? "null" : this.UltimateDebtor.ToString())}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
        }
    }
}