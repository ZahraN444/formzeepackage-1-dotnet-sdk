// <copyright file="Attributes50.cs" company="APIMatic">
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
    /// Attributes50.
    /// </summary>
    public class Attributes50
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes50"/> class.
        /// </summary>
        public Attributes50()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes50"/> class.
        /// </summary>
        /// <param name="auto">auto.</param>
        public Attributes50(
            bool? auto = null)
        {
            this.Auto = auto;
        }

        /// <summary>
        /// Gets or sets Auto.
        /// </summary>
        [JsonProperty("auto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes50 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes50 other &&                ((this.Auto == null && other.Auto == null) || (this.Auto?.Equals(other.Auto) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Auto = {(this.Auto == null ? "null" : this.Auto.ToString())}");
        }
    }
}