// <copyright file="DirectDebitReturnReversalAdmissionCreation.cs" company="APIMatic">
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
    /// DirectDebitReturnReversalAdmissionCreation.
    /// </summary>
    public class DirectDebitReturnReversalAdmissionCreation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitReturnReversalAdmissionCreation"/> class.
        /// </summary>
        public DirectDebitReturnReversalAdmissionCreation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitReturnReversalAdmissionCreation"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public DirectDebitReturnReversalAdmissionCreation(
            Models.DirectDebitReturnReversalAdmission data = null)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnReversalAdmission Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitReturnReversalAdmissionCreation : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitReturnReversalAdmissionCreation other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}