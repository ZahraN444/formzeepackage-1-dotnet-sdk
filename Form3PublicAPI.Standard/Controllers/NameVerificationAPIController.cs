// <copyright file="NameVerificationAPIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Exceptions;
    using Form3PublicAPI.Standard.Http.Client;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// NameVerificationAPIController.
    /// </summary>
    public class NameVerificationAPIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAPIController"/> class.
        /// </summary>
        internal NameVerificationAPIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List name verifications.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterAccountClassification">Optional parameter: Filter by account classification.</param>
        /// <param name="filterAccountNumber">Optional parameter: Filter by account number.</param>
        /// <param name="filterBankId">Optional parameter: Filter by bank id.</param>
        /// <param name="filterBankIdCode">Optional parameter: Filter by bank id code.</param>
        /// <param name="filterName">Optional parameter: Filter by name.</param>
        /// <param name="filterSecondaryIdentification">Optional parameter: Filter by secondary identification.</param>
        /// <param name="filterCreatedDateFrom">Optional parameter: Filter by created date from.</param>
        /// <param name="filterCreatedDateTo">Optional parameter: Filter by created date to.</param>
        /// <param name="filterModifiedDateFrom">Optional parameter: Filter by modified date from.</param>
        /// <param name="filterModifiedDateTo">Optional parameter: Filter by modified date to.</param>
        /// <param name="filterAdmissionCreatedDateFrom">Optional parameter: Filter by admission created date from.</param>
        /// <param name="filterAdmissionCreatedDateTo">Optional parameter: Filter by admission created date to.</param>
        /// <param name="filterAdmissionModifiedDateFrom">Optional parameter: Filter by admission modified date from.</param>
        /// <param name="filterAdmissionModifiedDateTo">Optional parameter: Filter by admission modified date to.</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionAnswer">Optional parameter: Filter by admission answer.</param>
        /// <param name="filterAdmissionActualName">Optional parameter: Filter by admission actual name.</param>
        /// <param name="filterAdmissionReason">Optional parameter: Filter by admission reason.</param>
        /// <param name="filterAdmissionReasonCode">Optional parameter: Filter by admission reason code.</param>
        /// <param name="filterSubmissionCreatedDateFrom">Optional parameter: Filter by submission created date from.</param>
        /// <param name="filterSubmissionCreatedDateTo">Optional parameter: Filter by submission created date to.</param>
        /// <param name="filterSubmissionModifiedDateFrom">Optional parameter: Filter by submission modified date from.</param>
        /// <param name="filterSubmissionModifiedDateTo">Optional parameter: Filter by submission modified date to.</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Filter by submission status.</param>
        /// <param name="filterSubmissionAnswer">Optional parameter: Filter by submission answer.</param>
        /// <param name="filterSubmissionActualName">Optional parameter: Filter by submission actual name.</param>
        /// <param name="filterSubmissionReason">Optional parameter: Filter by submission reason.</param>
        /// <param name="filterSubmissionReasonCode">Optional parameter: Filter by submission reason code.</param>
        /// <returns>Returns the Models.NameVerificationDetailsListResponse response from the API call.</returns>
        public Models.NameVerificationDetailsListResponse ListNameVerifications(
                int? pageNumber = null,
                int? pageSize = null,
                Guid? filterOrganisationId = null,
                string filterAccountClassification = null,
                string filterAccountNumber = null,
                string filterBankId = null,
                string filterBankIdCode = null,
                List<string> filterName = null,
                string filterSecondaryIdentification = null,
                DateTime? filterCreatedDateFrom = null,
                DateTime? filterCreatedDateTo = null,
                DateTime? filterModifiedDateFrom = null,
                DateTime? filterModifiedDateTo = null,
                DateTime? filterAdmissionCreatedDateFrom = null,
                DateTime? filterAdmissionCreatedDateTo = null,
                DateTime? filterAdmissionModifiedDateFrom = null,
                DateTime? filterAdmissionModifiedDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionAnswer = null,
                string filterAdmissionActualName = null,
                string filterAdmissionReason = null,
                string filterAdmissionReasonCode = null,
                DateTime? filterSubmissionCreatedDateFrom = null,
                DateTime? filterSubmissionCreatedDateTo = null,
                DateTime? filterSubmissionModifiedDateFrom = null,
                DateTime? filterSubmissionModifiedDateTo = null,
                string filterSubmissionStatus = null,
                string filterSubmissionAnswer = null,
                string filterSubmissionActualName = null,
                string filterSubmissionReason = null,
                string filterSubmissionReasonCode = null)
            => CoreHelper.RunTask(ListNameVerificationsAsync(pageNumber, pageSize, filterOrganisationId, filterAccountClassification, filterAccountNumber, filterBankId, filterBankIdCode, filterName, filterSecondaryIdentification, filterCreatedDateFrom, filterCreatedDateTo, filterModifiedDateFrom, filterModifiedDateTo, filterAdmissionCreatedDateFrom, filterAdmissionCreatedDateTo, filterAdmissionModifiedDateFrom, filterAdmissionModifiedDateTo, filterAdmissionStatus, filterAdmissionAnswer, filterAdmissionActualName, filterAdmissionReason, filterAdmissionReasonCode, filterSubmissionCreatedDateFrom, filterSubmissionCreatedDateTo, filterSubmissionModifiedDateFrom, filterSubmissionModifiedDateTo, filterSubmissionStatus, filterSubmissionAnswer, filterSubmissionActualName, filterSubmissionReason, filterSubmissionReasonCode));

        /// <summary>
        /// List name verifications.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterAccountClassification">Optional parameter: Filter by account classification.</param>
        /// <param name="filterAccountNumber">Optional parameter: Filter by account number.</param>
        /// <param name="filterBankId">Optional parameter: Filter by bank id.</param>
        /// <param name="filterBankIdCode">Optional parameter: Filter by bank id code.</param>
        /// <param name="filterName">Optional parameter: Filter by name.</param>
        /// <param name="filterSecondaryIdentification">Optional parameter: Filter by secondary identification.</param>
        /// <param name="filterCreatedDateFrom">Optional parameter: Filter by created date from.</param>
        /// <param name="filterCreatedDateTo">Optional parameter: Filter by created date to.</param>
        /// <param name="filterModifiedDateFrom">Optional parameter: Filter by modified date from.</param>
        /// <param name="filterModifiedDateTo">Optional parameter: Filter by modified date to.</param>
        /// <param name="filterAdmissionCreatedDateFrom">Optional parameter: Filter by admission created date from.</param>
        /// <param name="filterAdmissionCreatedDateTo">Optional parameter: Filter by admission created date to.</param>
        /// <param name="filterAdmissionModifiedDateFrom">Optional parameter: Filter by admission modified date from.</param>
        /// <param name="filterAdmissionModifiedDateTo">Optional parameter: Filter by admission modified date to.</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionAnswer">Optional parameter: Filter by admission answer.</param>
        /// <param name="filterAdmissionActualName">Optional parameter: Filter by admission actual name.</param>
        /// <param name="filterAdmissionReason">Optional parameter: Filter by admission reason.</param>
        /// <param name="filterAdmissionReasonCode">Optional parameter: Filter by admission reason code.</param>
        /// <param name="filterSubmissionCreatedDateFrom">Optional parameter: Filter by submission created date from.</param>
        /// <param name="filterSubmissionCreatedDateTo">Optional parameter: Filter by submission created date to.</param>
        /// <param name="filterSubmissionModifiedDateFrom">Optional parameter: Filter by submission modified date from.</param>
        /// <param name="filterSubmissionModifiedDateTo">Optional parameter: Filter by submission modified date to.</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Filter by submission status.</param>
        /// <param name="filterSubmissionAnswer">Optional parameter: Filter by submission answer.</param>
        /// <param name="filterSubmissionActualName">Optional parameter: Filter by submission actual name.</param>
        /// <param name="filterSubmissionReason">Optional parameter: Filter by submission reason.</param>
        /// <param name="filterSubmissionReasonCode">Optional parameter: Filter by submission reason code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NameVerificationDetailsListResponse response from the API call.</returns>
        public async Task<Models.NameVerificationDetailsListResponse> ListNameVerificationsAsync(
                int? pageNumber = null,
                int? pageSize = null,
                Guid? filterOrganisationId = null,
                string filterAccountClassification = null,
                string filterAccountNumber = null,
                string filterBankId = null,
                string filterBankIdCode = null,
                List<string> filterName = null,
                string filterSecondaryIdentification = null,
                DateTime? filterCreatedDateFrom = null,
                DateTime? filterCreatedDateTo = null,
                DateTime? filterModifiedDateFrom = null,
                DateTime? filterModifiedDateTo = null,
                DateTime? filterAdmissionCreatedDateFrom = null,
                DateTime? filterAdmissionCreatedDateTo = null,
                DateTime? filterAdmissionModifiedDateFrom = null,
                DateTime? filterAdmissionModifiedDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionAnswer = null,
                string filterAdmissionActualName = null,
                string filterAdmissionReason = null,
                string filterAdmissionReasonCode = null,
                DateTime? filterSubmissionCreatedDateFrom = null,
                DateTime? filterSubmissionCreatedDateTo = null,
                DateTime? filterSubmissionModifiedDateFrom = null,
                DateTime? filterSubmissionModifiedDateTo = null,
                string filterSubmissionStatus = null,
                string filterSubmissionAnswer = null,
                string filterSubmissionActualName = null,
                string filterSubmissionReason = null,
                string filterSubmissionReasonCode = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NameVerificationDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/nameverifications")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[account_classification]", filterAccountClassification))
                      .Query(_query => _query.Setup("filter[account_number]", filterAccountNumber))
                      .Query(_query => _query.Setup("filter[bank_id]", filterBankId))
                      .Query(_query => _query.Setup("filter[bank_id_code]", filterBankIdCode))
                      .Query(_query => _query.Setup("filter[name]", filterName))
                      .Query(_query => _query.Setup("filter[secondary_identification]", filterSecondaryIdentification))
                      .Query(_query => _query.Setup("filter[created_date_from]", filterCreatedDateFrom.HasValue ? filterCreatedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[created_date_to]", filterCreatedDateTo.HasValue ? filterCreatedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[modified_date_from]", filterModifiedDateFrom.HasValue ? filterModifiedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[modified_date_to]", filterModifiedDateTo.HasValue ? filterModifiedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.created_date_from]", filterAdmissionCreatedDateFrom.HasValue ? filterAdmissionCreatedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.created_date_to]", filterAdmissionCreatedDateTo.HasValue ? filterAdmissionCreatedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.modified_date_from]", filterAdmissionModifiedDateFrom.HasValue ? filterAdmissionModifiedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.modified_date_to]", filterAdmissionModifiedDateTo.HasValue ? filterAdmissionModifiedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.status]", filterAdmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.answer]", filterAdmissionAnswer))
                      .Query(_query => _query.Setup("filter[admission.actual_name]", filterAdmissionActualName))
                      .Query(_query => _query.Setup("filter[admission.reason]", filterAdmissionReason))
                      .Query(_query => _query.Setup("filter[admission.reason_code]", filterAdmissionReasonCode))
                      .Query(_query => _query.Setup("filter[submission.created_date_from]", filterSubmissionCreatedDateFrom.HasValue ? filterSubmissionCreatedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.created_date_to]", filterSubmissionCreatedDateTo.HasValue ? filterSubmissionCreatedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.modified_date_from]", filterSubmissionModifiedDateFrom.HasValue ? filterSubmissionModifiedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.modified_date_to]", filterSubmissionModifiedDateTo.HasValue ? filterSubmissionModifiedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.status]", filterSubmissionStatus))
                      .Query(_query => _query.Setup("filter[submission.answer]", filterSubmissionAnswer))
                      .Query(_query => _query.Setup("filter[submission.actual_name]", filterSubmissionActualName))
                      .Query(_query => _query.Setup("filter[submission.reason]", filterSubmissionReason))
                      .Query(_query => _query.Setup("filter[submission.reason_code]", filterSubmissionReasonCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Name verification creation request.
        /// </summary>
        /// <param name="nameVerificationCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.NameVerificationCreationResponse response from the API call.</returns>
        public Models.NameVerificationCreationResponse NameVerificationCreationRequest(
                Models.NameVerificationCreation nameVerificationCreationRequest = null)
            => CoreHelper.RunTask(NameVerificationCreationRequestAsync(nameVerificationCreationRequest));

        /// <summary>
        /// Name verification creation request.
        /// </summary>
        /// <param name="nameVerificationCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NameVerificationCreationResponse response from the API call.</returns>
        public async Task<Models.NameVerificationCreationResponse> NameVerificationCreationRequestAsync(
                Models.NameVerificationCreation nameVerificationCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NameVerificationCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/organisation/nameverifications")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(nameVerificationCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch name verification resource.
        /// </summary>
        /// <param name="id">Required parameter: Name Verification ID.</param>
        /// <returns>Returns the Models.NameVerificationDetailsResponse response from the API call.</returns>
        public Models.NameVerificationDetailsResponse FetchNameVerificationResource(
                Guid id)
            => CoreHelper.RunTask(FetchNameVerificationResourceAsync(id));

        /// <summary>
        /// Fetch name verification resource.
        /// </summary>
        /// <param name="id">Required parameter: Name Verification ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NameVerificationDetailsResponse response from the API call.</returns>
        public async Task<Models.NameVerificationDetailsResponse> FetchNameVerificationResourceAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NameVerificationDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/nameverifications/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Name verification admission fetch request.
        /// </summary>
        /// <param name="nameVerificationId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.NameVerificationAdmissionDetailsResponse response from the API call.</returns>
        public Models.NameVerificationAdmissionDetailsResponse NameVerificationAdmissionFetchRequest(
                Guid nameVerificationId,
                Guid id)
            => CoreHelper.RunTask(NameVerificationAdmissionFetchRequestAsync(nameVerificationId, id));

        /// <summary>
        /// Name verification admission fetch request.
        /// </summary>
        /// <param name="nameVerificationId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NameVerificationAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.NameVerificationAdmissionDetailsResponse> NameVerificationAdmissionFetchRequestAsync(
                Guid nameVerificationId,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NameVerificationAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/nameverifications/{name_verification_id}/admissions/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("name_verification_id", nameVerificationId))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}