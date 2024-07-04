// <copyright file="DuplicateTransactionInformation.cs" company="APIMatic">
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
    /// DuplicateTransactionInformation.
    /// </summary>
    public class DuplicateTransactionInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateTransactionInformation"/> class.
        /// </summary>
        public DuplicateTransactionInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateTransactionInformation"/> class.
        /// </summary>
        /// <param name="endToEndReference">end_to_end_reference.</param>
        /// <param name="references">references.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        public DuplicateTransactionInformation(
            string endToEndReference = null,
            List<Models.QueryReference> references = null,
            string schemeTransactionId = null)
        {
            this.EndToEndReference = endToEndReference;
            this.References = references;
            this.SchemeTransactionId = schemeTransactionId;
        }

        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
        /// </summary>
        [JsonProperty("end_to_end_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string EndToEndReference { get; set; }

        /// <summary>
        /// Reference for the duplicated payment for this Exception and Investigation case.
        /// </summary>
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.QueryReference> References { get; set; }

        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DuplicateTransactionInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is DuplicateTransactionInformation other &&                ((this.EndToEndReference == null && other.EndToEndReference == null) || (this.EndToEndReference?.Equals(other.EndToEndReference) == true)) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EndToEndReference = {(this.EndToEndReference == null ? "null" : this.EndToEndReference)}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : $"[{string.Join(", ", this.References)} ]")}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
        }
    }
}