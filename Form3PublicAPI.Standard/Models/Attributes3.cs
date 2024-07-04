// <copyright file="Attributes3.cs" company="APIMatic">
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
    /// Attributes3.
    /// </summary>
    public class Attributes3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes3"/> class.
        /// </summary>
        public Attributes3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes3"/> class.
        /// </summary>
        /// <param name="beneficiaryParty">beneficiary_party.</param>
        /// <param name="reasonCode">reason_code.</param>
        public Attributes3(
            Models.BeneficiaryParty beneficiaryParty = null,
            string reasonCode = null)
        {
            this.BeneficiaryParty = beneficiaryParty;
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// Gets or sets BeneficiaryParty.
        /// </summary>
        [JsonProperty("beneficiary_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BeneficiaryParty BeneficiaryParty { get; set; }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes3 other &&                ((this.BeneficiaryParty == null && other.BeneficiaryParty == null) || (this.BeneficiaryParty?.Equals(other.BeneficiaryParty) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BeneficiaryParty = {(this.BeneficiaryParty == null ? "null" : this.BeneficiaryParty.ToString())}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
        }
    }
}