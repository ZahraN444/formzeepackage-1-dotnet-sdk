// <copyright file="Swift.cs" company="APIMatic">
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
    /// Swift.
    /// </summary>
    public class Swift
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Swift"/> class.
        /// </summary>
        public Swift()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Swift"/> class.
        /// </summary>
        /// <param name="bankOperationCode">bank_operation_code.</param>
        /// <param name="header">header.</param>
        /// <param name="instructionCode">instruction_code.</param>
        /// <param name="senderReceiverInformation">sender_receiver_information.</param>
        /// <param name="timeIndication">time_indication.</param>
        public Swift(
            string bankOperationCode = null,
            Models.Header header = null,
            string instructionCode = null,
            string senderReceiverInformation = null,
            string timeIndication = null)
        {
            this.BankOperationCode = bankOperationCode;
            this.Header = header;
            this.InstructionCode = instructionCode;
            this.SenderReceiverInformation = senderReceiverInformation;
            this.TimeIndication = timeIndication;
        }

        /// <summary>
        /// SWIFT service level
        /// </summary>
        [JsonProperty("bank_operation_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankOperationCode { get; set; }

        /// <summary>
        /// Gets or sets Header.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Header Header { get; set; }

        /// <summary>
        /// A SWIFT instruction code
        /// </summary>
        [JsonProperty("instruction_code", NullValueHandling = NullValueHandling.Ignore)]
        public string InstructionCode { get; set; }

        /// <summary>
        /// This field specifies additional information for the Receiver or other party specified.
        /// </summary>
        [JsonProperty("sender_receiver_information", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderReceiverInformation { get; set; }

        /// <summary>
        /// This repetitive field specifies one or several time indication(s) related to the processing of the payment instruction.
        /// </summary>
        [JsonProperty("time_indication", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeIndication { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Swift : ({string.Join(", ", toStringOutput)})";
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
            return obj is Swift other &&                ((this.BankOperationCode == null && other.BankOperationCode == null) || (this.BankOperationCode?.Equals(other.BankOperationCode) == true)) &&
                ((this.Header == null && other.Header == null) || (this.Header?.Equals(other.Header) == true)) &&
                ((this.InstructionCode == null && other.InstructionCode == null) || (this.InstructionCode?.Equals(other.InstructionCode) == true)) &&
                ((this.SenderReceiverInformation == null && other.SenderReceiverInformation == null) || (this.SenderReceiverInformation?.Equals(other.SenderReceiverInformation) == true)) &&
                ((this.TimeIndication == null && other.TimeIndication == null) || (this.TimeIndication?.Equals(other.TimeIndication) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankOperationCode = {(this.BankOperationCode == null ? "null" : this.BankOperationCode)}");
            toStringOutput.Add($"this.Header = {(this.Header == null ? "null" : this.Header.ToString())}");
            toStringOutput.Add($"this.InstructionCode = {(this.InstructionCode == null ? "null" : this.InstructionCode)}");
            toStringOutput.Add($"this.SenderReceiverInformation = {(this.SenderReceiverInformation == null ? "null" : this.SenderReceiverInformation)}");
            toStringOutput.Add($"this.TimeIndication = {(this.TimeIndication == null ? "null" : this.TimeIndication)}");
        }
    }
}