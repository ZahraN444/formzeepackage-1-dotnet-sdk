// <copyright file="BranchIdentificationAttributes.cs" company="APIMatic">
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
    /// BranchIdentificationAttributes.
    /// </summary>
    public class BranchIdentificationAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationAttributes"/> class.
        /// </summary>
        public BranchIdentificationAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationAttributes"/> class.
        /// </summary>
        /// <param name="secondaryIdentification">secondary_identification.</param>
        public BranchIdentificationAttributes(
            string secondaryIdentification)
        {
            this.SecondaryIdentification = secondaryIdentification;
        }

        /// <summary>
        /// Used to validate where expecting an exact match against payment's reference information.
        /// </summary>
        [JsonProperty("secondary_identification")]
        public string SecondaryIdentification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BranchIdentificationAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is BranchIdentificationAttributes other &&                ((this.SecondaryIdentification == null && other.SecondaryIdentification == null) || (this.SecondaryIdentification?.Equals(other.SecondaryIdentification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SecondaryIdentification = {(this.SecondaryIdentification == null ? "null" : this.SecondaryIdentification)}");
        }
    }
}