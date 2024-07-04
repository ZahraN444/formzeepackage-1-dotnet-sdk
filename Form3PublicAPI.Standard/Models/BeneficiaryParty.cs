// <copyright file="BeneficiaryParty.cs" company="APIMatic">
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
    /// BeneficiaryParty.
    /// </summary>
    public class BeneficiaryParty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryParty"/> class.
        /// </summary>
        public BeneficiaryParty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryParty"/> class.
        /// </summary>
        /// <param name="newBankDetails">new_bank_details.</param>
        public BeneficiaryParty(
            Models.NewBankDetails newBankDetails = null)
        {
            this.NewBankDetails = newBankDetails;
        }

        /// <summary>
        /// Gets or sets NewBankDetails.
        /// </summary>
        [JsonProperty("new_bank_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NewBankDetails NewBankDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BeneficiaryParty : ({string.Join(", ", toStringOutput)})";
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
            return obj is BeneficiaryParty other &&                ((this.NewBankDetails == null && other.NewBankDetails == null) || (this.NewBankDetails?.Equals(other.NewBankDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NewBankDetails = {(this.NewBankDetails == null ? "null" : this.NewBankDetails.ToString())}");
        }
    }
}