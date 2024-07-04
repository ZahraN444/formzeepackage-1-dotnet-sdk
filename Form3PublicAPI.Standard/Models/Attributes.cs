// <copyright file="Attributes.cs" company="APIMatic">
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
    /// Attributes.
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        public Attributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        /// <param name="acceptanceQualifier">acceptance_qualifier.</param>
        /// <param name="accountClassification">account_classification.</param>
        /// <param name="accountMatchingOptOut">account_matching_opt_out.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="alternativeBankAccountNames">alternative_bank_account_names.</param>
        /// <param name="alternativeNames">alternative_names.</param>
        /// <param name="bankAccountName">bank_account_name.</param>
        /// <param name="bankId">bank_id.</param>
        /// <param name="bankIdCode">bank_id_code.</param>
        /// <param name="baseCurrency">base_currency.</param>
        /// <param name="bic">bic.</param>
        /// <param name="country">country.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="iban">iban.</param>
        /// <param name="jointAccount">joint_account.</param>
        /// <param name="name">name.</param>
        /// <param name="nameMatchingStatus">name_matching_status.</param>
        /// <param name="organisationIdentification">organisation_identification.</param>
        /// <param name="privateIdentification">private_identification.</param>
        /// <param name="processingService">processing_service.</param>
        /// <param name="referenceMask">reference_mask.</param>
        /// <param name="secondaryIdentification">secondary_identification.</param>
        /// <param name="status">status.</param>
        /// <param name="statusReason">status_reason.</param>
        /// <param name="switched">switched.</param>
        /// <param name="switchedAccountDetails">switched_account_details.</param>
        /// <param name="title">title.</param>
        /// <param name="userDefinedData">user_defined_data.</param>
        /// <param name="userDefinedInformation">user_defined_information.</param>
        /// <param name="validationType">validation_type.</param>
        public Attributes(
            Models.AcceptanceQualifierEnum? acceptanceQualifier = null,
            Models.AccountClassification1Enum? accountClassification = null,
            bool? accountMatchingOptOut = null,
            string accountNumber = null,
            List<string> alternativeBankAccountNames = null,
            List<string> alternativeNames = null,
            string bankAccountName = null,
            string bankId = null,
            string bankIdCode = null,
            string baseCurrency = null,
            string bic = null,
            string country = null,
            string customerId = null,
            string firstName = null,
            string iban = null,
            bool? jointAccount = null,
            List<string> name = null,
            Models.NameMatchingStatusEnum? nameMatchingStatus = null,
            Models.AccountAttributesOrganisationIdentification organisationIdentification = null,
            Models.AccountAttributesPrivateIdentification privateIdentification = null,
            string processingService = null,
            string referenceMask = null,
            string secondaryIdentification = null,
            Models.StatusEnum? status = null,
            Models.StatusReasonEnum? statusReason = null,
            bool? switched = null,
            Models.SwitchedAccountDetails switchedAccountDetails = null,
            string title = null,
            List<Models.UserDefinedData> userDefinedData = null,
            string userDefinedInformation = null,
            Models.ValidationTypeEnum? validationType = null)
        {
            this.AcceptanceQualifier = acceptanceQualifier;
            this.AccountClassification = accountClassification;
            this.AccountMatchingOptOut = accountMatchingOptOut;
            this.AccountNumber = accountNumber;
            this.AlternativeBankAccountNames = alternativeBankAccountNames;
            this.AlternativeNames = alternativeNames;
            this.BankAccountName = bankAccountName;
            this.BankId = bankId;
            this.BankIdCode = bankIdCode;
            this.BaseCurrency = baseCurrency;
            this.Bic = bic;
            this.Country = country;
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.Iban = iban;
            this.JointAccount = jointAccount;
            this.Name = name;
            this.NameMatchingStatus = nameMatchingStatus;
            this.OrganisationIdentification = organisationIdentification;
            this.PrivateIdentification = privateIdentification;
            this.ProcessingService = processingService;
            this.ReferenceMask = referenceMask;
            this.SecondaryIdentification = secondaryIdentification;
            this.Status = status;
            this.StatusReason = statusReason;
            this.Switched = switched;
            this.SwitchedAccountDetails = switchedAccountDetails;
            this.Title = title;
            this.UserDefinedData = userDefinedData;
            this.UserDefinedInformation = userDefinedInformation;
            this.ValidationType = validationType;
        }

        /// <summary>
        /// All accepted payments will receive the matching qualifier code
        /// </summary>
        [JsonProperty("acceptance_qualifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AcceptanceQualifierEnum? AcceptanceQualifier { get; set; }

        /// <summary>
        /// Is the account business or personal?
        /// </summary>
        [JsonProperty("account_classification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountClassification1Enum? AccountClassification { get; set; }

        /// <summary>
        /// - deprecated - Is the account opted out of account matching, e.g. CoP?
        /// </summary>
        [JsonProperty("account_matching_opt_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccountMatchingOptOut { get; set; }

        /// <summary>
        /// Account number of the account. A unique number will automatically be generated if not provided.
        /// </summary>
        [JsonProperty("account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// - deprecated - Alternative account names. Used for Confirmation of Payee matching.
        /// </summary>
        [JsonProperty("alternative_bank_account_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlternativeBankAccountNames { get; set; }

        /// <summary>
        /// Alternative names. Used for Confirmation of Payee matching.
        /// </summary>
        [JsonProperty("alternative_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlternativeNames { get; set; }

        /// <summary>
        /// - deprecated - Primary account name. Used for Confirmation of Payee matching. Required if confirmation_of_payee_enabled is true for the organisation.
        /// </summary>
        [JsonProperty("bank_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountName { get; set; }

        /// <summary>
        /// Local country bank identifier. In the UK this is the sort code.
        /// </summary>
        [JsonProperty("bank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BankId { get; set; }

        /// <summary>
        /// ISO 20022 code used to identify the type of bank ID being used
        /// </summary>
        [JsonProperty("bank_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIdCode { get; set; }

        /// <summary>
        /// ISO 4217 code used to identify the base currency of the account
        /// </summary>
        [JsonProperty("base_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// SWIFT BIC in either 8 or 11 character format
        /// </summary>
        [JsonProperty("bic", NullValueHandling = NullValueHandling.Ignore)]
        public string Bic { get; set; }

        /// <summary>
        /// ISO 3166-1 code used to identify the domicile of the account
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// A free-format reference that can be used to link this account to an external system
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// - deprecated - Customer first name.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// IBAN of the account. Will be calculated from other fields if not supplied.
        /// </summary>
        [JsonProperty("iban", NullValueHandling = NullValueHandling.Ignore)]
        public string Iban { get; set; }

        /// <summary>
        /// Is the account joint?
        /// </summary>
        [JsonProperty("joint_account", NullValueHandling = NullValueHandling.Ignore)]
        public bool? JointAccount { get; set; }

        /// <summary>
        /// Account holder names (for example title, first name, last name). Used for Confirmation of Payee matching.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// Describes the status of the account for name matching via CoP. The value determines the code with which Form3 responds to matched CoP requests to this account.
        /// </summary>
        [JsonProperty("name_matching_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NameMatchingStatusEnum? NameMatchingStatus { get; set; }

        /// <summary>
        /// Gets or sets OrganisationIdentification.
        /// </summary>
        [JsonProperty("organisation_identification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountAttributesOrganisationIdentification OrganisationIdentification { get; set; }

        /// <summary>
        /// Gets or sets PrivateIdentification.
        /// </summary>
        [JsonProperty("private_identification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountAttributesPrivateIdentification PrivateIdentification { get; set; }

        /// <summary>
        /// - deprecated - Accounting system or service. It will be added to each payment received to an account.
        /// </summary>
        [JsonProperty("processing_service", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessingService { get; set; }

        /// <summary>
        /// When set will apply a validation mask on the payment reference to each payment received to an account.
        /// </summary>
        [JsonProperty("reference_mask", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceMask { get; set; }

        /// <summary>
        /// Secondary identification, e.g. building society roll number. Used for Confirmation of Payee.
        /// </summary>
        [JsonProperty("secondary_identification", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryIdentification { get; set; }

        /// <summary>
        /// Current status of the account
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StatusEnum? Status { get; set; }

        /// <summary>
        /// Used to determine appropriate scheme or internal payment reject code. Account status field must be set to closed to use this functionality.
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StatusReasonEnum? StatusReason { get; set; }

        /// <summary>
        /// - deprecated - Indicates whether the account has been switched using the Current Account Switch Service.
        /// </summary>
        [JsonProperty("switched", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Switched { get; set; }

        /// <summary>
        /// Alternate Account details to use in case the account has been switched away from this organisation.
        /// </summary>
        [JsonProperty("switched_account_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SwitchedAccountDetails SwitchedAccountDetails { get; set; }

        /// <summary>
        /// - deprecated - Customer title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// All purpose list of key-value pairs to store specific data for the associated account. It will be added to each payment received to an account.
        /// </summary>
        [JsonProperty("user_defined_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDefinedData> UserDefinedData { get; set; }

        /// <summary>
        /// - deprecated - All purpose field to store specific data for the associated account. It will be added to each payment received to an account.
        /// </summary>
        [JsonProperty("user_defined_information", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDefinedInformation { get; set; }

        /// <summary>
        /// optional validation to apply to the account
        /// </summary>
        [JsonProperty("validation_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ValidationTypeEnum? ValidationType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes other &&                ((this.AcceptanceQualifier == null && other.AcceptanceQualifier == null) || (this.AcceptanceQualifier?.Equals(other.AcceptanceQualifier) == true)) &&
                ((this.AccountClassification == null && other.AccountClassification == null) || (this.AccountClassification?.Equals(other.AccountClassification) == true)) &&
                ((this.AccountMatchingOptOut == null && other.AccountMatchingOptOut == null) || (this.AccountMatchingOptOut?.Equals(other.AccountMatchingOptOut) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AlternativeBankAccountNames == null && other.AlternativeBankAccountNames == null) || (this.AlternativeBankAccountNames?.Equals(other.AlternativeBankAccountNames) == true)) &&
                ((this.AlternativeNames == null && other.AlternativeNames == null) || (this.AlternativeNames?.Equals(other.AlternativeNames) == true)) &&
                ((this.BankAccountName == null && other.BankAccountName == null) || (this.BankAccountName?.Equals(other.BankAccountName) == true)) &&
                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true)) &&
                ((this.BankIdCode == null && other.BankIdCode == null) || (this.BankIdCode?.Equals(other.BankIdCode) == true)) &&
                ((this.BaseCurrency == null && other.BaseCurrency == null) || (this.BaseCurrency?.Equals(other.BaseCurrency) == true)) &&
                ((this.Bic == null && other.Bic == null) || (this.Bic?.Equals(other.Bic) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.Iban == null && other.Iban == null) || (this.Iban?.Equals(other.Iban) == true)) &&
                ((this.JointAccount == null && other.JointAccount == null) || (this.JointAccount?.Equals(other.JointAccount) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.NameMatchingStatus == null && other.NameMatchingStatus == null) || (this.NameMatchingStatus?.Equals(other.NameMatchingStatus) == true)) &&
                ((this.OrganisationIdentification == null && other.OrganisationIdentification == null) || (this.OrganisationIdentification?.Equals(other.OrganisationIdentification) == true)) &&
                ((this.PrivateIdentification == null && other.PrivateIdentification == null) || (this.PrivateIdentification?.Equals(other.PrivateIdentification) == true)) &&
                ((this.ProcessingService == null && other.ProcessingService == null) || (this.ProcessingService?.Equals(other.ProcessingService) == true)) &&
                ((this.ReferenceMask == null && other.ReferenceMask == null) || (this.ReferenceMask?.Equals(other.ReferenceMask) == true)) &&
                ((this.SecondaryIdentification == null && other.SecondaryIdentification == null) || (this.SecondaryIdentification?.Equals(other.SecondaryIdentification) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true)) &&
                ((this.Switched == null && other.Switched == null) || (this.Switched?.Equals(other.Switched) == true)) &&
                ((this.SwitchedAccountDetails == null && other.SwitchedAccountDetails == null) || (this.SwitchedAccountDetails?.Equals(other.SwitchedAccountDetails) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.UserDefinedData == null && other.UserDefinedData == null) || (this.UserDefinedData?.Equals(other.UserDefinedData) == true)) &&
                ((this.UserDefinedInformation == null && other.UserDefinedInformation == null) || (this.UserDefinedInformation?.Equals(other.UserDefinedInformation) == true)) &&
                ((this.ValidationType == null && other.ValidationType == null) || (this.ValidationType?.Equals(other.ValidationType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcceptanceQualifier = {(this.AcceptanceQualifier == null ? "null" : this.AcceptanceQualifier.ToString())}");
            toStringOutput.Add($"this.AccountClassification = {(this.AccountClassification == null ? "null" : this.AccountClassification.ToString())}");
            toStringOutput.Add($"this.AccountMatchingOptOut = {(this.AccountMatchingOptOut == null ? "null" : this.AccountMatchingOptOut.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AlternativeBankAccountNames = {(this.AlternativeBankAccountNames == null ? "null" : $"[{string.Join(", ", this.AlternativeBankAccountNames)} ]")}");
            toStringOutput.Add($"this.AlternativeNames = {(this.AlternativeNames == null ? "null" : $"[{string.Join(", ", this.AlternativeNames)} ]")}");
            toStringOutput.Add($"this.BankAccountName = {(this.BankAccountName == null ? "null" : this.BankAccountName)}");
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
            toStringOutput.Add($"this.BankIdCode = {(this.BankIdCode == null ? "null" : this.BankIdCode)}");
            toStringOutput.Add($"this.BaseCurrency = {(this.BaseCurrency == null ? "null" : this.BaseCurrency)}");
            toStringOutput.Add($"this.Bic = {(this.Bic == null ? "null" : this.Bic)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.Iban = {(this.Iban == null ? "null" : this.Iban)}");
            toStringOutput.Add($"this.JointAccount = {(this.JointAccount == null ? "null" : this.JointAccount.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : $"[{string.Join(", ", this.Name)} ]")}");
            toStringOutput.Add($"this.NameMatchingStatus = {(this.NameMatchingStatus == null ? "null" : this.NameMatchingStatus.ToString())}");
            toStringOutput.Add($"this.OrganisationIdentification = {(this.OrganisationIdentification == null ? "null" : this.OrganisationIdentification.ToString())}");
            toStringOutput.Add($"this.PrivateIdentification = {(this.PrivateIdentification == null ? "null" : this.PrivateIdentification.ToString())}");
            toStringOutput.Add($"this.ProcessingService = {(this.ProcessingService == null ? "null" : this.ProcessingService)}");
            toStringOutput.Add($"this.ReferenceMask = {(this.ReferenceMask == null ? "null" : this.ReferenceMask)}");
            toStringOutput.Add($"this.SecondaryIdentification = {(this.SecondaryIdentification == null ? "null" : this.SecondaryIdentification)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason.ToString())}");
            toStringOutput.Add($"this.Switched = {(this.Switched == null ? "null" : this.Switched.ToString())}");
            toStringOutput.Add($"this.SwitchedAccountDetails = {(this.SwitchedAccountDetails == null ? "null" : this.SwitchedAccountDetails.ToString())}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.UserDefinedData = {(this.UserDefinedData == null ? "null" : $"[{string.Join(", ", this.UserDefinedData)} ]")}");
            toStringOutput.Add($"this.UserDefinedInformation = {(this.UserDefinedInformation == null ? "null" : this.UserDefinedInformation)}");
            toStringOutput.Add($"this.ValidationType = {(this.ValidationType == null ? "null" : this.ValidationType.ToString())}");
        }
    }
}