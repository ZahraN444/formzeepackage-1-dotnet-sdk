// <copyright file="Relationships18.cs" company="APIMatic">
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
    /// Relationships18.
    /// </summary>
    public class Relationships18
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships18"/> class.
        /// </summary>
        public Relationships18()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships18"/> class.
        /// </summary>
        /// <param name="mandate">mandate.</param>
        /// <param name="mandateReturn">mandate_return.</param>
        public Relationships18(
            Models.Mandate2 mandate = null,
            Models.MandateReturn2 mandateReturn = null)
        {
            this.Mandate = mandate;
            this.MandateReturn = mandateReturn;
        }

        /// <summary>
        /// Gets or sets Mandate.
        /// </summary>
        [JsonProperty("mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mandate2 Mandate { get; set; }

        /// <summary>
        /// Gets or sets MandateReturn.
        /// </summary>
        [JsonProperty("mandate_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateReturn2 MandateReturn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships18 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships18 other &&                ((this.Mandate == null && other.Mandate == null) || (this.Mandate?.Equals(other.Mandate) == true)) &&
                ((this.MandateReturn == null && other.MandateReturn == null) || (this.MandateReturn?.Equals(other.MandateReturn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mandate = {(this.Mandate == null ? "null" : this.Mandate.ToString())}");
            toStringOutput.Add($"this.MandateReturn = {(this.MandateReturn == null ? "null" : this.MandateReturn.ToString())}");
        }
    }
}