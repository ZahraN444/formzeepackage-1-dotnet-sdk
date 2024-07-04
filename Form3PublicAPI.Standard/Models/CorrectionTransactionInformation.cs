// <copyright file="CorrectionTransactionInformation.cs" company="APIMatic">
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
    /// CorrectionTransactionInformation.
    /// </summary>
    public class CorrectionTransactionInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionTransactionInformation"/> class.
        /// </summary>
        public CorrectionTransactionInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionTransactionInformation"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="endToEndReference">end_to_end_reference.</param>
        /// <param name="instructionId">instruction_id.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="references">references.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        public CorrectionTransactionInformation(
            string amount = null,
            string currency = null,
            string endToEndReference = null,
            string instructionId = null,
            DateTime? processingDate = null,
            List<Models.QueryReference> references = null,
            string schemeTransactionId = null,
            string uniqueSchemeId = null)
        {
            this.Amount = amount;
            this.Currency = currency;
            this.EndToEndReference = endToEndReference;
            this.InstructionId = instructionId;
            this.ProcessingDate = processingDate;
            this.References = references;
            this.SchemeTransactionId = schemeTransactionId;
            this.UniqueSchemeId = uniqueSchemeId;
        }

        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Currency of the transaction amount. Currency code as defined in [ISO 4217](https://www.iso.org/iso/home/standards/currency_codes.htm)
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
        /// </summary>
        [JsonProperty("end_to_end_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string EndToEndReference { get; set; }

        /// <summary>
        /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.
        /// </summary>
        [JsonProperty("instruction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstructionId { get; set; }

        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Reference for the corrective payment for this query case.
        /// </summary>
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.QueryReference> References { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// The scheme-specific unique transaction ID to unambiguously identify the message. Populated by the scheme.
        /// </summary>
        [JsonProperty("unique_scheme_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSchemeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CorrectionTransactionInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is CorrectionTransactionInformation other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.EndToEndReference == null && other.EndToEndReference == null) || (this.EndToEndReference?.Equals(other.EndToEndReference) == true)) &&
                ((this.InstructionId == null && other.InstructionId == null) || (this.InstructionId?.Equals(other.InstructionId) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.EndToEndReference = {(this.EndToEndReference == null ? "null" : this.EndToEndReference)}");
            toStringOutput.Add($"this.InstructionId = {(this.InstructionId == null ? "null" : this.InstructionId)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : $"[{string.Join(", ", this.References)} ]")}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
        }
    }
}