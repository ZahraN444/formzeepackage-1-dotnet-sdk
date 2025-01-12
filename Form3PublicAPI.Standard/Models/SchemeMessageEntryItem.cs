// <copyright file="SchemeMessageEntryItem.cs" company="APIMatic">
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
    /// SchemeMessageEntryItem.
    /// </summary>
    public class SchemeMessageEntryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageEntryItem"/> class.
        /// </summary>
        public SchemeMessageEntryItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageEntryItem"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="mValue">value.</param>
        public SchemeMessageEntryItem(
            string key,
            string mValue = null)
        {
            this.Key = key;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeMessageEntryItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeMessageEntryItem other &&                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}