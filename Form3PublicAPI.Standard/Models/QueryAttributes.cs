// <copyright file="QueryAttributes.cs" company="APIMatic">
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
    /// QueryAttributes.
    /// </summary>
    public class QueryAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAttributes"/> class.
        /// </summary>
        public QueryAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAttributes"/> class.
        /// </summary>
        /// <param name="queryType">query_type.</param>
        /// <param name="agents">agents.</param>
        /// <param name="autoHandled">auto_handled.</param>
        /// <param name="creatorParty">creator_party.</param>
        /// <param name="messageId">message_id.</param>
        /// <param name="processingDate">processing_date.</param>
        /// <param name="querySubTypes">query_sub_types.</param>
        /// <param name="references">references.</param>
        /// <param name="requestedInformation">requested_information.</param>
        /// <param name="schemeTransactionId">scheme_transaction_id.</param>
        /// <param name="status">status.</param>
        /// <param name="unstructuredMessage">unstructured_message.</param>
        public QueryAttributes(
            Models.QueryTypeEnum queryType,
            List<Models.RequestForInformationAgent> agents = null,
            bool? autoHandled = null,
            Models.RequestForInformationCreatorParty creatorParty = null,
            string messageId = null,
            DateTime? processingDate = null,
            List<string> querySubTypes = null,
            List<Models.RequestForInformationReference> references = null,
            List<Models.RequestForInformationRequestedInformation> requestedInformation = null,
            string schemeTransactionId = null,
            Models.ReportRequestStatusEnum? status = null,
            string unstructuredMessage = null)
        {
            this.Agents = agents;
            this.AutoHandled = autoHandled;
            this.CreatorParty = creatorParty;
            this.MessageId = messageId;
            this.ProcessingDate = processingDate;
            this.QuerySubTypes = querySubTypes;
            this.QueryType = queryType;
            this.References = references;
            this.RequestedInformation = requestedInformation;
            this.SchemeTransactionId = schemeTransactionId;
            this.Status = status;
            this.UnstructuredMessage = unstructuredMessage;
        }

        /// <summary>
        /// Gets or sets Agents.
        /// </summary>
        [JsonProperty("agents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RequestForInformationAgent> Agents { get; set; }

        /// <summary>
        /// Gets or sets AutoHandled.
        /// </summary>
        [JsonProperty("auto_handled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoHandled { get; set; }

        /// <summary>
        /// Gets or sets CreatorParty.
        /// </summary>
        [JsonProperty("creator_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RequestForInformationCreatorParty CreatorParty { get; set; }

        /// <summary>
        /// Gets or sets MessageId.
        /// </summary>
        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets ProcessingDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("processing_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProcessingDate { get; set; }

        /// <summary>
        /// Gets or sets QuerySubTypes.
        /// </summary>
        [JsonProperty("query_sub_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuerySubTypes { get; set; }

        /// <summary>
        /// Gets or sets QueryType.
        /// </summary>
        [JsonProperty("query_type")]
        public Models.QueryTypeEnum QueryType { get; set; }

        /// <summary>
        /// Gets or sets References.
        /// </summary>
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RequestForInformationReference> References { get; set; }

        /// <summary>
        /// Gets or sets RequestedInformation.
        /// </summary>
        [JsonProperty("requested_information", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RequestForInformationRequestedInformation> RequestedInformation { get; set; }

        /// <summary>
        /// Gets or sets SchemeTransactionId.
        /// </summary>
        [JsonProperty("scheme_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemeTransactionId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportRequestStatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets UnstructuredMessage.
        /// </summary>
        [JsonProperty("unstructured_message", NullValueHandling = NullValueHandling.Ignore)]
        public string UnstructuredMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryAttributes other &&                ((this.Agents == null && other.Agents == null) || (this.Agents?.Equals(other.Agents) == true)) &&
                ((this.AutoHandled == null && other.AutoHandled == null) || (this.AutoHandled?.Equals(other.AutoHandled) == true)) &&
                ((this.CreatorParty == null && other.CreatorParty == null) || (this.CreatorParty?.Equals(other.CreatorParty) == true)) &&
                ((this.MessageId == null && other.MessageId == null) || (this.MessageId?.Equals(other.MessageId) == true)) &&
                ((this.ProcessingDate == null && other.ProcessingDate == null) || (this.ProcessingDate?.Equals(other.ProcessingDate) == true)) &&
                ((this.QuerySubTypes == null && other.QuerySubTypes == null) || (this.QuerySubTypes?.Equals(other.QuerySubTypes) == true)) &&
                this.QueryType.Equals(other.QueryType) &&
                ((this.References == null && other.References == null) || (this.References?.Equals(other.References) == true)) &&
                ((this.RequestedInformation == null && other.RequestedInformation == null) || (this.RequestedInformation?.Equals(other.RequestedInformation) == true)) &&
                ((this.SchemeTransactionId == null && other.SchemeTransactionId == null) || (this.SchemeTransactionId?.Equals(other.SchemeTransactionId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.UnstructuredMessage == null && other.UnstructuredMessage == null) || (this.UnstructuredMessage?.Equals(other.UnstructuredMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Agents = {(this.Agents == null ? "null" : $"[{string.Join(", ", this.Agents)} ]")}");
            toStringOutput.Add($"this.AutoHandled = {(this.AutoHandled == null ? "null" : this.AutoHandled.ToString())}");
            toStringOutput.Add($"this.CreatorParty = {(this.CreatorParty == null ? "null" : this.CreatorParty.ToString())}");
            toStringOutput.Add($"this.MessageId = {(this.MessageId == null ? "null" : this.MessageId)}");
            toStringOutput.Add($"this.ProcessingDate = {(this.ProcessingDate == null ? "null" : this.ProcessingDate.ToString())}");
            toStringOutput.Add($"this.QuerySubTypes = {(this.QuerySubTypes == null ? "null" : $"[{string.Join(", ", this.QuerySubTypes)} ]")}");
            toStringOutput.Add($"this.QueryType = {this.QueryType}");
            toStringOutput.Add($"this.References = {(this.References == null ? "null" : $"[{string.Join(", ", this.References)} ]")}");
            toStringOutput.Add($"this.RequestedInformation = {(this.RequestedInformation == null ? "null" : $"[{string.Join(", ", this.RequestedInformation)} ]")}");
            toStringOutput.Add($"this.SchemeTransactionId = {(this.SchemeTransactionId == null ? "null" : this.SchemeTransactionId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.UnstructuredMessage = {(this.UnstructuredMessage == null ? "null" : this.UnstructuredMessage)}");
        }
    }
}