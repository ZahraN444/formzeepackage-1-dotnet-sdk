// <copyright file="Links.cs" company="APIMatic">
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
    /// Links.
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Links"/> class.
        /// </summary>
        public Links()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Links"/> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="first">first.</param>
        /// <param name="last">last.</param>
        /// <param name="next">next.</param>
        /// <param name="prev">prev.</param>
        public Links(
            string self,
            string first = null,
            string last = null,
            string next = null,
            string prev = null)
        {
            this.First = first;
            this.Last = last;
            this.Next = next;
            this.Prev = prev;
            this.Self = self;
        }

        /// <summary>
        /// Link to the first resource in the list
        /// </summary>
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public string First { get; set; }

        /// <summary>
        /// Link to the last resource in the list
        /// </summary>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        public string Last { get; set; }

        /// <summary>
        /// Link to the next resource in the list
        /// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }

        /// <summary>
        /// Link to the previous resource in the list
        /// </summary>
        [JsonProperty("prev", NullValueHandling = NullValueHandling.Ignore)]
        public string Prev { get; set; }

        /// <summary>
        /// Link to this resource type
        /// </summary>
        [JsonProperty("self")]
        public string Self { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Links : ({string.Join(", ", toStringOutput)})";
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
            return obj is Links other &&                ((this.First == null && other.First == null) || (this.First?.Equals(other.First) == true)) &&
                ((this.Last == null && other.Last == null) || (this.Last?.Equals(other.Last) == true)) &&
                ((this.Next == null && other.Next == null) || (this.Next?.Equals(other.Next) == true)) &&
                ((this.Prev == null && other.Prev == null) || (this.Prev?.Equals(other.Prev) == true)) &&
                ((this.Self == null && other.Self == null) || (this.Self?.Equals(other.Self) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.First = {(this.First == null ? "null" : this.First)}");
            toStringOutput.Add($"this.Last = {(this.Last == null ? "null" : this.Last)}");
            toStringOutput.Add($"this.Next = {(this.Next == null ? "null" : this.Next)}");
            toStringOutput.Add($"this.Prev = {(this.Prev == null ? "null" : this.Prev)}");
            toStringOutput.Add($"this.Self = {(this.Self == null ? "null" : this.Self)}");
        }
    }
}