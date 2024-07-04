// <copyright file="ForwardedPayment.cs" company="APIMatic">
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
    /// ForwardedPayment.
    /// </summary>
    public class ForwardedPayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardedPayment"/> class.
        /// </summary>
        public ForwardedPayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardedPayment"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ForwardedPayment(
            List<Models.RelationshipData> data = null)
        {
            this.Data = data;
        }

        /// <summary>
        /// Array of Inbound Payments that triggered the creation of this Forwarding Payment.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RelationshipData> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ForwardedPayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is ForwardedPayment other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}