// <copyright file="Attributes13.cs" company="APIMatic">
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
    /// Attributes13.
    /// </summary>
    public class Attributes13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes13"/> class.
        /// </summary>
        public Attributes13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes13"/> class.
        /// </summary>
        /// <param name="userDefinedData">user_defined_data.</param>
        public Attributes13(
            List<Models.UserDefinedData> userDefinedData = null)
        {
            this.UserDefinedData = userDefinedData;
        }

        /// <summary>
        /// All purpose list of key-value pairs.
        /// </summary>
        [JsonProperty("user_defined_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDefinedData> UserDefinedData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes13 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes13 other &&                ((this.UserDefinedData == null && other.UserDefinedData == null) || (this.UserDefinedData?.Equals(other.UserDefinedData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserDefinedData = {(this.UserDefinedData == null ? "null" : $"[{string.Join(", ", this.UserDefinedData)} ]")}");
        }
    }
}