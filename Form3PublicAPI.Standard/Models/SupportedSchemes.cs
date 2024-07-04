// <copyright file="SupportedSchemes.cs" company="APIMatic">
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
    /// SupportedSchemes.
    /// </summary>
    public class SupportedSchemes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedSchemes"/> class.
        /// </summary>
        public SupportedSchemes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedSchemes"/> class.
        /// </summary>
        /// <param name="bACS">BACS.</param>
        /// <param name="cCC">CCC.</param>
        /// <param name="cHAPS">CHAPS.</param>
        /// <param name="fPS">FPS.</param>
        public SupportedSchemes(
            Models.BACS bACS = null,
            Models.CCC cCC = null,
            Models.CHAPS cHAPS = null,
            Models.FPS fPS = null)
        {
            this.BACS = bACS;
            this.CCC = cCC;
            this.CHAPS = cHAPS;
            this.FPS = fPS;
        }

        /// <summary>
        /// Gets or sets BACS.
        /// </summary>
        [JsonProperty("BACS", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BACS BACS { get; set; }

        /// <summary>
        /// Gets or sets CCC.
        /// </summary>
        [JsonProperty("CCC", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CCC CCC { get; set; }

        /// <summary>
        /// Gets or sets CHAPS.
        /// </summary>
        [JsonProperty("CHAPS", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CHAPS CHAPS { get; set; }

        /// <summary>
        /// Gets or sets FPS.
        /// </summary>
        [JsonProperty("FPS", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FPS FPS { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SupportedSchemes : ({string.Join(", ", toStringOutput)})";
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
            return obj is SupportedSchemes other &&                ((this.BACS == null && other.BACS == null) || (this.BACS?.Equals(other.BACS) == true)) &&
                ((this.CCC == null && other.CCC == null) || (this.CCC?.Equals(other.CCC) == true)) &&
                ((this.CHAPS == null && other.CHAPS == null) || (this.CHAPS?.Equals(other.CHAPS) == true)) &&
                ((this.FPS == null && other.FPS == null) || (this.FPS?.Equals(other.FPS) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BACS = {(this.BACS == null ? "null" : this.BACS.ToString())}");
            toStringOutput.Add($"this.CCC = {(this.CCC == null ? "null" : this.CCC.ToString())}");
            toStringOutput.Add($"this.CHAPS = {(this.CHAPS == null ? "null" : this.CHAPS.ToString())}");
            toStringOutput.Add($"this.FPS = {(this.FPS == null ? "null" : this.FPS.ToString())}");
        }
    }
}