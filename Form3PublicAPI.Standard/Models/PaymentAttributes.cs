// <copyright file="PaymentAttributes.cs" company="APIMatic">
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
    /// PaymentAttributes.
    /// </summary>
    public class PaymentAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAttributes"/> class.
        /// </summary>
        public PaymentAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAttributes"/> class.
        /// </summary>
        /// <param name="agents">agents.</param>
        /// <param name="amount">amount.</param>
        /// <param name="batchBookingIndicator">batch_booking_indicator.</param>
        /// <param name="batchId">batch_id.</param>
        /// <param name="batchType">batch_type.</param>
        /// <param name="beneficiaryParty">beneficiary_party.</param>
        /// <param name="categoryPurpose">category_purpose.</param>
        /// <param name="categoryPurposeCoded">category_purpose_coded.</param>
        /// <param name="chargesInformation">charges_information.</param>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="debtorParty">debtor_party.</param>
        /// <param name="endToEndReference">end_to_end_reference.</param>
        /// <param name="fileNumber">file_number.</param>
        /// <param name="fx">fx.</param>
        /// <param name="instructionId">instruction_id.</param>
        /// <param name="intermediaryBank">intermediary_bank.</param>
        /// <param name="numericReference">numeric_reference.</param>
        /// <param name="paymentAcceptanceDatetime">payment_acceptance_datetime.</param>
        /// <param name="paymentPurpose">payment_purpose.</param>
        /// <param name="paymentPurposeCoded">payment_purpose_coded.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="receiversCorrespondent">receivers_correspondent.</param>
        /// <param name="reference">reference.</param>
        /// <param name="references">references.</param>
        /// <param name="regulatoryReporting">regulatory_reporting.</param>
        /// <param name="reimbursement">reimbursement.</param>
        /// <param name="remittanceInformation">remittance_information.</param>
        /// <param name="schemePaymentSubType">scheme_payment_sub_type.</param>
        /// <param name="schemePaymentType">scheme_payment_type.</param>
        /// <param name="schemeProcessingDate">scheme_processing_date.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        /// <param name="sendersCorrespondent">senders_correspondent.</param>
        /// <param name="settlement">settlement.</param>
        /// <param name="structuredReference">structured_reference.</param>
        /// <param name="swift">swift.</param>
        /// <param name="ultimateBeneficiary">ultimate_beneficiary.</param>
        /// <param name="ultimateDebtor">ultimate_debtor.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        /// <param name="userDefinedData">user_defined_data.</param>
        public PaymentAttributes(
            List<Models.Agent> agents = null,
            string amount = null,
            string batchBookingIndicator = null,
            string batchId = null,
            string batchType = null,
            Models.BeneficiaryParty1 beneficiaryParty = null,
            string categoryPurpose = null,
            string categoryPurposeCoded = null,
            Models.ChargesInformation chargesInformation = null,
            string clearingId = null,
            string currency = null,
            Models.DebtorParty debtorParty = null,
            string endToEndReference = null,
            string fileNumber = null,
            Models.Fx fx = null,
            string instructionId = null,
            Models.IntermediaryBankAccountHoldingEntity intermediaryBank = null,
            string numericReference = null,
            DateTime? paymentAcceptanceDatetime = null,
            string paymentPurpose = null,
            string paymentPurposeCoded = null,
            string paymentScheme = null,
            string paymentType = null,
            DateTime? processingDate = null,
            Models.ReceiversCorrespondentAccountHoldingEntity receiversCorrespondent = null,
            string reference = null,
            List<Models.Reference> references = null,
            string regulatoryReporting = null,
            Models.ReimbursementAccountHoldingEntity reimbursement = null,
            string remittanceInformation = null,
            string schemePaymentSubType = null,
            string schemePaymentType = null,
            DateTime? schemeProcessingDate = null,
            string schemeTransactionId = null,
            Models.SendersCorrespondentAccountHoldingEntity sendersCorrespondent = null,
            Models.Settlement settlement = null,
            Models.StructuredReference structuredReference = null,
            Models.Swift swift = null,
            Models.UltimateEntity ultimateBeneficiary = null,
            Models.UltimateEntity ultimateDebtor = null,
            string uniqueSchemeId = null,
            List<Models.UserDefinedData> userDefinedData = null)
        {
            this.Agents = agents;
            this.Amount = amount;
            this.BatchBookingIndicator = batchBookingIndicator;
            this.BatchId = batchId;
            this.BatchType = batchType;
            this.BeneficiaryParty = beneficiaryParty;
            this.CategoryPurpose = categoryPurpose;
            this.CategoryPurposeCoded = categoryPurposeCoded;
            this.ChargesInformation = chargesInformation;
            this.ClearingId = clearingId;
            this.Currency = currency;
            this.DebtorParty = debtorParty;
            this.EndToEndReference = endToEndReference;
            this.FileNumber = fileNumber;
            this.Fx = fx;
            this.InstructionId = instructionId;
            this.IntermediaryBank = intermediaryBank;
            this.NumericReference = numericReference;
            this.PaymentAcceptanceDatetime = paymentAcceptanceDatetime;
            this.PaymentPurpose = paymentPurpose;
            this.PaymentPurposeCoded = paymentPurposeCoded;
            this.PaymentScheme = paymentScheme;
            this.PaymentType = paymentType;
            this.ProcessingDate = processingDate;
            this.ReceiversCorrespondent = receiversCorrespondent;
            this.Reference = reference;
            this.References = references;
            this.RegulatoryReporting = regulatoryReporting;
            this.Reimbursement = reimbursement;
            this.RemittanceInformation = remittanceInformation;
            this.SchemePaymentSubType = schemePaymentSubType;
            this.SchemePaymentType = schemePaymentType;
            this.SchemeProcessingDate = schemeProcessingDate;
            this.SchemeTransactionId = schemeTransactionId;
            this.SendersCorrespondent = sendersCorrespondent;
            this.Settlement = settlement;
            this.StructuredReference = structuredReference;
            this.Swift = swift;
            this.UltimateBeneficiary = ultimateBeneficiary;
            this.UltimateDebtor = ultimateDebtor;
            this.UniqueSchemeId = uniqueSchemeId;
            this.UserDefinedData = userDefinedData;
        }

        /// <summary>
        /// Block to represent a Financial Institution/agent in the payment chain
        /// </summary>
        [JsonProperty("agents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Agent> Agents { get; set; }

        /// <summary>
        /// Amount of money moved between the instructing agent and instructed agent
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets BatchBookingIndicator.
        /// </summary>
        [JsonProperty("batch_booking_indicator", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchBookingIndicator { get; set; }

        /// <summary>
        /// Gets or sets BatchId.
        /// </summary>
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or sets BatchType.
        /// </summary>
        [JsonProperty("batch_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchType { get; set; }

        /// <summary>
        /// Gets or sets BeneficiaryParty.
        /// </summary>
        [JsonProperty("beneficiary_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryParty1 BeneficiaryParty { get; set; }

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
        /// Gets or sets ChargesInformation.
        /// </summary>
        [JsonProperty("charges_information", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargesInformation ChargesInformation { get; set; }

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
        public Models.DebtorParty DebtorParty { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
        /// </summary>
        [JsonProperty("end_to_end_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string EndToEndReference { get; set; }

        /// <summary>
        /// Gets or sets FileNumber.
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNumber { get; set; }

        /// <summary>
        /// Gets or sets Fx.
        /// </summary>
        [JsonProperty("fx", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fx Fx { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the initiating party to unambiguously identify the transaction. This identification is an point-to-point reference and is passed on, unchanged, throughout the entire chain. Cannot include leading, trailing or internal spaces.
        /// </summary>
        [JsonProperty("instruction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstructionId { get; set; }

        /// <summary>
        /// Gets or sets IntermediaryBank.
        /// </summary>
        [JsonProperty("intermediary_bank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntermediaryBankAccountHoldingEntity IntermediaryBank { get; set; }

        /// <summary>
        /// Numeric reference field, see scheme specific descriptions for usage
        /// </summary>
        [JsonProperty("numeric_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericReference { get; set; }

        /// <summary>
        /// Timestamp of when the payment instruction meets the set processing conditions. Format: YYYY-MM-DDThh:mm:ss:mmm+hh:mm
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_acceptance_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaymentAcceptanceDatetime { get; set; }

        /// <summary>
        /// Purpose of the payment in a proprietary form
        /// </summary>
        [JsonProperty("payment_purpose", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentPurpose { get; set; }

        /// <summary>
        /// Purpose of the payment in a coded form
        /// </summary>
        [JsonProperty("payment_purpose_coded", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentPurposeCoded { get; set; }

        /// <summary>
        /// Clearing infrastructure through which the payment instruction is to be processed. Default for given organisation ID is used if left empty. Has to be a valid [scheme identifier](http://draft-api-docs.form3.tech/api.html#enumerations-schemes).
        /// </summary>
        [JsonProperty("payment_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentScheme { get; set; }

        /// <summary>
        /// Gets or sets PaymentType.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Date on which the payment is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets ReceiversCorrespondent.
        /// </summary>
        [JsonProperty("receivers_correspondent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReceiversCorrespondentAccountHoldingEntity ReceiversCorrespondent { get; set; }

        /// <summary>
        /// Payment reference for beneficiary use
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// Block to represent a list of references
        /// </summary>
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Reference> References { get; set; }

        /// <summary>
        /// Regulatory reporting information
        /// </summary>
        [JsonProperty("regulatory_reporting", NullValueHandling = NullValueHandling.Ignore)]
        public string RegulatoryReporting { get; set; }

        /// <summary>
        /// Gets or sets Reimbursement.
        /// </summary>
        [JsonProperty("reimbursement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReimbursementAccountHoldingEntity Reimbursement { get; set; }

        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts receivable system provided by the debtor for the beneficiary.
        /// </summary>
        [JsonProperty("remittance_information", NullValueHandling = NullValueHandling.Ignore)]
        public string RemittanceInformation { get; set; }

        /// <summary>
        /// The scheme specific payment [sub type](http://api-docs.form3.tech/api.html#enumerations-scheme-specific-payment-sub-types)
        /// </summary>
        [JsonProperty("scheme_payment_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemePaymentSubType { get; set; }

        /// <summary>
        /// The [scheme-specific payment type](#enumerations-scheme-payment-types)
        /// </summary>
        [JsonProperty("scheme_payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemePaymentType { get; set; }

        /// <summary>
        /// Date on which the payment is processed by the scheme. Only used if different from `processing_date`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("scheme_processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SchemeProcessingDate { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// Gets or sets SendersCorrespondent.
        /// </summary>
        [JsonProperty("senders_correspondent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SendersCorrespondentAccountHoldingEntity SendersCorrespondent { get; set; }

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
        /// Gets or sets Swift.
        /// </summary>
        [JsonProperty("swift", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Swift Swift { get; set; }

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

        /// <summary>
        /// All purpose list of key-value pairs specific data stored on the payment.
        /// </summary>
        [JsonProperty("user_defined_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDefinedData> UserDefinedData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentAttributes other &&                ((this.Agents == null && other.Agents == null) || (this.Agents?.Equals(other.Agents) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.BatchBookingIndicator == null && other.BatchBookingIndicator == null) || (this.BatchBookingIndicator?.Equals(other.BatchBookingIndicator) == true)) &&
                ((this.BatchId == null && other.BatchId == null) || (this.BatchId?.Equals(other.BatchId) == true)) &&
                ((this.BatchType == null && other.BatchType == null) || (this.BatchType?.Equals(other.BatchType) == true)) &&
                ((this.BeneficiaryParty == null && other.BeneficiaryParty == null) || (this.BeneficiaryParty?.Equals(other.BeneficiaryParty) == true)) &&
                ((this.CategoryPurpose == null && other.CategoryPurpose == null) || (this.CategoryPurpose?.Equals(other.CategoryPurpose) == true)) &&
                ((this.CategoryPurposeCoded == null && other.CategoryPurposeCoded == null) || (this.CategoryPurposeCoded?.Equals(other.CategoryPurposeCoded) == true)) &&
                ((this.ChargesInformation == null && other.ChargesInformation == null) || (this.ChargesInformation?.Equals(other.ChargesInformation) == true)) &&
                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.DebtorParty == null && other.DebtorParty == null) || (this.DebtorParty?.Equals(other.DebtorParty) == true)) &&
                ((this.EndToEndReference == null && other.EndToEndReference == null) || (this.EndToEndReference?.Equals(other.EndToEndReference) == true)) &&
                ((this.FileNumber == null && other.FileNumber == null) || (this.FileNumber?.Equals(other.FileNumber) == true)) &&
                ((this.Fx == null && other.Fx == null) || (this.Fx?.Equals(other.Fx) == true)) &&
                ((this.InstructionId == null && other.InstructionId == null) || (this.InstructionId?.Equals(other.InstructionId) == true)) &&
                ((this.IntermediaryBank == null && other.IntermediaryBank == null) || (this.IntermediaryBank?.Equals(other.IntermediaryBank) == true)) &&
                ((this.NumericReference == null && other.NumericReference == null) || (this.NumericReference?.Equals(other.NumericReference) == true)) &&
                ((this.PaymentAcceptanceDatetime == null && other.PaymentAcceptanceDatetime == null) || (this.PaymentAcceptanceDatetime?.Equals(other.PaymentAcceptanceDatetime) == true)) &&
                ((this.PaymentPurpose == null && other.PaymentPurpose == null) || (this.PaymentPurpose?.Equals(other.PaymentPurpose) == true)) &&
                ((this.PaymentPurposeCoded == null && other.PaymentPurposeCoded == null) || (this.PaymentPurposeCoded?.Equals(other.PaymentPurposeCoded) == true)) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.ReceiversCorrespondent == null && other.ReceiversCorrespondent == null) || (this.ReceiversCorrespondent?.Equals(other.ReceiversCorrespondent) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.RegulatoryReporting == null && other.RegulatoryReporting == null) || (this.RegulatoryReporting?.Equals(other.RegulatoryReporting) == true)) &&
                ((this.Reimbursement == null && other.Reimbursement == null) || (this.Reimbursement?.Equals(other.Reimbursement) == true)) &&
                ((this.RemittanceInformation == null && other.RemittanceInformation == null) || (this.RemittanceInformation?.Equals(other.RemittanceInformation) == true)) &&
                ((this.SchemePaymentSubType == null && other.SchemePaymentSubType == null) || (this.SchemePaymentSubType?.Equals(other.SchemePaymentSubType) == true)) &&
                ((this.SchemePaymentType == null && other.SchemePaymentType == null) || (this.SchemePaymentType?.Equals(other.SchemePaymentType) == true)) &&
                ((this.SchemeProcessingDate == null && other.SchemeProcessingDate == null) || (this.SchemeProcessingDate?.Equals(other.SchemeProcessingDate) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true)) &&
                ((this.SendersCorrespondent == null && other.SendersCorrespondent == null) || (this.SendersCorrespondent?.Equals(other.SendersCorrespondent) == true)) &&
                ((this.Settlement == null && other.Settlement == null) || (this.Settlement?.Equals(other.Settlement) == true)) &&
                ((this.StructuredReference == null && other.StructuredReference == null) || (this.StructuredReference?.Equals(other.StructuredReference) == true)) &&
                ((this.Swift == null && other.Swift == null) || (this.Swift?.Equals(other.Swift) == true)) &&
                ((this.UltimateBeneficiary == null && other.UltimateBeneficiary == null) || (this.UltimateBeneficiary?.Equals(other.UltimateBeneficiary) == true)) &&
                ((this.UltimateDebtor == null && other.UltimateDebtor == null) || (this.UltimateDebtor?.Equals(other.UltimateDebtor) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true)) &&
                ((this.UserDefinedData == null && other.UserDefinedData == null) || (this.UserDefinedData?.Equals(other.UserDefinedData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Agents = {(this.Agents == null ? "null" : $"[{string.Join(", ", this.Agents)} ]")}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.BatchBookingIndicator = {(this.BatchBookingIndicator == null ? "null" : this.BatchBookingIndicator)}");
            toStringOutput.Add($"this.BatchId = {(this.BatchId == null ? "null" : this.BatchId)}");
            toStringOutput.Add($"this.BatchType = {(this.BatchType == null ? "null" : this.BatchType)}");
            toStringOutput.Add($"this.BeneficiaryParty = {(this.BeneficiaryParty == null ? "null" : this.BeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.CategoryPurpose = {(this.CategoryPurpose == null ? "null" : this.CategoryPurpose)}");
            toStringOutput.Add($"this.CategoryPurposeCoded = {(this.CategoryPurposeCoded == null ? "null" : this.CategoryPurposeCoded)}");
            toStringOutput.Add($"this.ChargesInformation = {(this.ChargesInformation == null ? "null" : this.ChargesInformation.ToString())}");
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.DebtorParty = {(this.DebtorParty == null ? "null" : this.DebtorParty.ToString())}");
            toStringOutput.Add($"this.EndToEndReference = {(this.EndToEndReference == null ? "null" : this.EndToEndReference)}");
            toStringOutput.Add($"this.FileNumber = {(this.FileNumber == null ? "null" : this.FileNumber)}");
            toStringOutput.Add($"this.Fx = {(this.Fx == null ? "null" : this.Fx.ToString())}");
            toStringOutput.Add($"this.InstructionId = {(this.InstructionId == null ? "null" : this.InstructionId)}");
            toStringOutput.Add($"this.IntermediaryBank = {(this.IntermediaryBank == null ? "null" : this.IntermediaryBank.ToString())}");
            toStringOutput.Add($"this.NumericReference = {(this.NumericReference == null ? "null" : this.NumericReference)}");
            toStringOutput.Add($"this.PaymentAcceptanceDatetime = {(this.PaymentAcceptanceDatetime == null ? "null" : this.PaymentAcceptanceDatetime.ToString())}");
            toStringOutput.Add($"this.PaymentPurpose = {(this.PaymentPurpose == null ? "null" : this.PaymentPurpose)}");
            toStringOutput.Add($"this.PaymentPurposeCoded = {(this.PaymentPurposeCoded == null ? "null" : this.PaymentPurposeCoded)}");
            toStringOutput.Add($"this.PaymentScheme = {(this.PaymentScheme == null ? "null" : this.PaymentScheme)}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.ReceiversCorrespondent = {(this.ReceiversCorrespondent == null ? "null" : this.ReceiversCorrespondent.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : $"[{string.Join(", ", this.References)} ]")}");
            toStringOutput.Add($"this.RegulatoryReporting = {(this.RegulatoryReporting == null ? "null" : this.RegulatoryReporting)}");
            toStringOutput.Add($"this.Reimbursement = {(this.Reimbursement == null ? "null" : this.Reimbursement.ToString())}");
            toStringOutput.Add($"this.RemittanceInformation = {(this.RemittanceInformation == null ? "null" : this.RemittanceInformation)}");
            toStringOutput.Add($"this.SchemePaymentSubType = {(this.SchemePaymentSubType == null ? "null" : this.SchemePaymentSubType)}");
            toStringOutput.Add($"this.SchemePaymentType = {(this.SchemePaymentType == null ? "null" : this.SchemePaymentType)}");
            toStringOutput.Add($"this.SchemeProcessingDate = {(this.SchemeProcessingDate == null ? "null" : this.SchemeProcessingDate.ToString())}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
            toStringOutput.Add($"this.SendersCorrespondent = {(this.SendersCorrespondent == null ? "null" : this.SendersCorrespondent.ToString())}");
            toStringOutput.Add($"this.Settlement = {(this.Settlement == null ? "null" : this.Settlement.ToString())}");
            toStringOutput.Add($"this.StructuredReference = {(this.StructuredReference == null ? "null" : this.StructuredReference.ToString())}");
            toStringOutput.Add($"this.Swift = {(this.Swift == null ? "null" : this.Swift.ToString())}");
            toStringOutput.Add($"this.UltimateBeneficiary = {(this.UltimateBeneficiary == null ? "null" : this.UltimateBeneficiary.ToString())}");
            toStringOutput.Add($"this.UltimateDebtor = {(this.UltimateDebtor == null ? "null" : this.UltimateDebtor.ToString())}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
            toStringOutput.Add($"this.UserDefinedData = {(this.UserDefinedData == null ? "null" : $"[{string.Join(", ", this.UserDefinedData)} ]")}");
        }
    }
}