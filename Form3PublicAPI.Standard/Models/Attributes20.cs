// <copyright file="Attributes20.cs" company="APIMatic">
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
    /// Attributes20.
    /// </summary>
    public class Attributes20
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes20"/> class.
        /// </summary>
        public Attributes20()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes20"/> class.
        /// </summary>
        /// <param name="originalInstructionId">original_instruction_id.</param>
        public Attributes20(
            string originalInstructionId)
        {
            this.OriginalInstructionId = originalInstructionId;
        }

        /// <summary>
        /// Gets or sets OriginalInstructionId.
        /// </summary>
        [JsonProperty("original_instruction_id")]
        public string OriginalInstructionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes20 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes20 other &&                ((this.OriginalInstructionId == null && other.OriginalInstructionId == null) || (this.OriginalInstructionId?.Equals(other.OriginalInstructionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OriginalInstructionId = {(this.OriginalInstructionId == null ? "null" : this.OriginalInstructionId)}");
        }
    }
}