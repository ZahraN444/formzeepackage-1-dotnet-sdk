// <copyright file="SchemeMessageAttributes.cs" company="APIMatic">
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
    /// SchemeMessageAttributes.
    /// </summary>
    public class SchemeMessageAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageAttributes"/> class.
        /// </summary>
        public SchemeMessageAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageAttributes"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="entries">entries.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="schemeMessageType">scheme_message_type.</param>
        /// <param name="uniqueSchemeId">unique_scheme_id.</param>
        public SchemeMessageAttributes(
            DateTime date,
            List<Models.SchemeMessageEntryItem> entries,
            Models.PaymentSchemeEnum paymentScheme,
            string schemeMessageType,
            string uniqueSchemeId = null)
        {
            this.Date = date;
            this.Entries = entries;
            this.PaymentScheme = paymentScheme;
            this.SchemeMessageType = schemeMessageType;
            this.UniqueSchemeId = uniqueSchemeId;
        }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets Entries.
        /// </summary>
        [JsonProperty("entries")]
        public List<Models.SchemeMessageEntryItem> Entries { get; set; }

        /// <summary>
        /// Gets or sets PaymentScheme.
        /// </summary>
        [JsonProperty("payment_scheme")]
        public Models.PaymentSchemeEnum PaymentScheme { get; set; }

        /// <summary>
        /// Gets or sets SchemeMessageType.
        /// </summary>
        [JsonProperty("scheme_message_type")]
        public string SchemeMessageType { get; set; }

        /// <summary>
        /// Gets or sets UniqueSchemeId.
        /// </summary>
        [JsonProperty("unique_scheme_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSchemeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeMessageAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeMessageAttributes other &&                this.Date.Equals(other.Date) &&
                ((this.Entries == null && other.Entries == null) || (this.Entries?.Equals(other.Entries) == true)) &&
                this.PaymentScheme.Equals(other.PaymentScheme) &&
                ((this.SchemeMessageType == null && other.SchemeMessageType == null) || (this.SchemeMessageType?.Equals(other.SchemeMessageType) == true)) &&
                ((this.UniqueSchemeId == null && other.UniqueSchemeId == null) || (this.UniqueSchemeId?.Equals(other.UniqueSchemeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {this.Date}");
            toStringOutput.Add($"this.Entries = {(this.Entries == null ? "null" : $"[{string.Join(", ", this.Entries)} ]")}");
            toStringOutput.Add($"this.PaymentScheme = {this.PaymentScheme}");
            toStringOutput.Add($"this.SchemeMessageType = {(this.SchemeMessageType == null ? "null" : this.SchemeMessageType)}");
            toStringOutput.Add($"this.UniqueSchemeId = {(this.UniqueSchemeId == null ? "null" : this.UniqueSchemeId)}");
        }
    }
}