// <copyright file="BranchAttributes.cs" company="APIMatic">
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
    /// BranchAttributes.
    /// </summary>
    public class BranchAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAttributes"/> class.
        /// </summary>
        public BranchAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAttributes"/> class.
        /// </summary>
        /// <param name="bankId">bank_id.</param>
        /// <param name="bankIdCode">bank_id_code.</param>
        /// <param name="acceptanceQualifier">acceptance_qualifier.</param>
        /// <param name="referenceMask">reference_mask.</param>
        /// <param name="userDefinedData">user_defined_data.</param>
        /// <param name="validationType">validation_type.</param>
        public BranchAttributes(
            string bankId,
            string bankIdCode,
            Models.AcceptanceQualifierEnum? acceptanceQualifier = null,
            string referenceMask = null,
            List<Models.UserDefinedData> userDefinedData = null,
            Models.BranchValidationTypeEnum? validationType = null)
        {
            this.AcceptanceQualifier = acceptanceQualifier;
            this.BankId = bankId;
            this.BankIdCode = bankIdCode;
            this.ReferenceMask = referenceMask;
            this.UserDefinedData = userDefinedData;
            this.ValidationType = validationType;
        }

        /// <summary>
        /// All accepted payments will receive the matching qualifier code
        /// </summary>
        [JsonProperty("acceptance_qualifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AcceptanceQualifierEnum? AcceptanceQualifier { get; set; }

        /// <summary>
        /// Local country bank identifier. In the UK this is the sort code.
        /// </summary>
        [JsonProperty("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// ISO 20022 code used to identify the type of bank ID being used
        /// </summary>
        [JsonProperty("bank_id_code")]
        public string BankIdCode { get; set; }

        /// <summary>
        /// if present – has effect of making secondary reference in payment mandatory
        /// </summary>
        [JsonProperty("reference_mask", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceMask { get; set; }

        /// <summary>
        /// All purpose list of key-value pairs to store specific data.
        /// </summary>
        [JsonProperty("user_defined_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDefinedData> UserDefinedData { get; set; }

        /// <summary>
        /// optional validation to apply to the branch
        /// </summary>
        [JsonProperty("validation_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BranchValidationTypeEnum? ValidationType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BranchAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is BranchAttributes other &&                ((this.AcceptanceQualifier == null && other.AcceptanceQualifier == null) || (this.AcceptanceQualifier?.Equals(other.AcceptanceQualifier) == true)) &&
                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true)) &&
                ((this.BankIdCode == null && other.BankIdCode == null) || (this.BankIdCode?.Equals(other.BankIdCode) == true)) &&
                ((this.ReferenceMask == null && other.ReferenceMask == null) || (this.ReferenceMask?.Equals(other.ReferenceMask) == true)) &&
                ((this.UserDefinedData == null && other.UserDefinedData == null) || (this.UserDefinedData?.Equals(other.UserDefinedData) == true)) &&
                ((this.ValidationType == null && other.ValidationType == null) || (this.ValidationType?.Equals(other.ValidationType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcceptanceQualifier = {(this.AcceptanceQualifier == null ? "null" : this.AcceptanceQualifier.ToString())}");
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
            toStringOutput.Add($"this.BankIdCode = {(this.BankIdCode == null ? "null" : this.BankIdCode)}");
            toStringOutput.Add($"this.ReferenceMask = {(this.ReferenceMask == null ? "null" : this.ReferenceMask)}");
            toStringOutput.Add($"this.UserDefinedData = {(this.UserDefinedData == null ? "null" : $"[{string.Join(", ", this.UserDefinedData)} ]")}");
            toStringOutput.Add($"this.ValidationType = {(this.ValidationType == null ? "null" : this.ValidationType.ToString())}");
        }
    }
}