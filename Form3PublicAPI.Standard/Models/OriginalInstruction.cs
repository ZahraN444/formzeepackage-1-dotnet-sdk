// <copyright file="OriginalInstruction.cs" company="APIMatic">
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
    /// OriginalInstruction.
    /// </summary>
    public class OriginalInstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginalInstruction"/> class.
        /// </summary>
        public OriginalInstruction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OriginalInstruction"/> class.
        /// </summary>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="reference">reference.</param>
        public OriginalInstruction(
            string clearingId,
            string reference)
        {
            this.ClearingId = clearingId;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or sets ClearingId.
        /// </summary>
        [JsonProperty("clearing_id")]
        public string ClearingId { get; set; }

        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OriginalInstruction : ({string.Join(", ", toStringOutput)})";
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
            return obj is OriginalInstruction other &&                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
        }
    }
}