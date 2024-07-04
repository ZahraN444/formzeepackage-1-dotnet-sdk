// <copyright file="MandatesController.cs" company="APIMatic">
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
    /// MandatesController.
    /// </summary>
    public class MandatesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatesController"/> class.
        /// </summary>
        internal MandatesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List mandates.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterCurrency">Optional parameter: Example: .</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterSchemePaymentType">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterSchemeProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSchemeProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterClearingId">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionSchemeStatusCode">Optional parameter: Filter by admission scheme status code.</param>
        /// <param name="filterAmount">Optional parameter: Filter by amount.</param>
        /// <param name="filterReference">Optional parameter: Filter by reference.</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Filter by unique scheme id.</param>
        /// <param name="filterAllVersions">Optional parameter: Include old versions of mandates.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterStatus">Optional parameter: Filter by mandate status.</param>
        /// <param name="filterStatusReason">Optional parameter: Filter by mandate status reason.</param>
        /// <returns>Returns the Models.MandateDetailsListResponse response from the API call.</returns>
        public Models.MandateDetailsListResponse GetMandates(
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyBankId = null,
                string filterCurrency = null,
                string filterPaymentScheme = null,
                string filterSchemePaymentType = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                DateTime? filterSchemeProcessingDateFrom = null,
                DateTime? filterSchemeProcessingDateTo = null,
                string filterClearingId = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionSchemeStatusCode = null,
                string filterAmount = null,
                string filterReference = null,
                string filterUniqueSchemeId = null,
                bool? filterAllVersions = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterStatus = null,
                string filterStatusReason = null)
            => CoreHelper.RunTask(GetMandatesAsync(pageNumber, pageSize, filterOrganisationId, filterDebtorPartyAccountNumber, filterDebtorPartyBankId, filterBeneficiaryPartyAccountNumber, filterBeneficiaryPartyBankId, filterCurrency, filterPaymentScheme, filterSchemePaymentType, filterProcessingDateFrom, filterProcessingDateTo, filterSchemeProcessingDateFrom, filterSchemeProcessingDateTo, filterClearingId, filterAdmissionAdmissionDateFrom, filterAdmissionAdmissionDateTo, filterAdmissionStatus, filterAdmissionSchemeStatusCode, filterAmount, filterReference, filterUniqueSchemeId, filterAllVersions, filterSubmissionSubmissionDateFrom, filterSubmissionSubmissionDateTo, filterStatus, filterStatusReason));

        /// <summary>
        /// List mandates.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterCurrency">Optional parameter: Example: .</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterSchemePaymentType">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterSchemeProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSchemeProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterClearingId">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionSchemeStatusCode">Optional parameter: Filter by admission scheme status code.</param>
        /// <param name="filterAmount">Optional parameter: Filter by amount.</param>
        /// <param name="filterReference">Optional parameter: Filter by reference.</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Filter by unique scheme id.</param>
        /// <param name="filterAllVersions">Optional parameter: Include old versions of mandates.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterStatus">Optional parameter: Filter by mandate status.</param>
        /// <param name="filterStatusReason">Optional parameter: Filter by mandate status reason.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateDetailsListResponse response from the API call.</returns>
        public async Task<Models.MandateDetailsListResponse> GetMandatesAsync(
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyBankId = null,
                string filterCurrency = null,
                string filterPaymentScheme = null,
                string filterSchemePaymentType = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                DateTime? filterSchemeProcessingDateFrom = null,
                DateTime? filterSchemeProcessingDateTo = null,
                string filterClearingId = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionSchemeStatusCode = null,
                string filterAmount = null,
                string filterReference = null,
                string filterUniqueSchemeId = null,
                bool? filterAllVersions = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterStatus = null,
                string filterStatusReason = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/mandates")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[debtor_party.account_number]", filterDebtorPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[debtor_party.bank_id]", filterDebtorPartyBankId))
                      .Query(_query => _query.Setup("filter[beneficiary_party.account_number]", filterBeneficiaryPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[beneficiary_party.bank_id]", filterBeneficiaryPartyBankId))
                      .Query(_query => _query.Setup("filter[currency]", filterCurrency))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[scheme_payment_type]", filterSchemePaymentType))
                      .Query(_query => _query.Setup("filter[processing_date_from]", filterProcessingDateFrom.HasValue ? filterProcessingDateFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[processing_date_to]", filterProcessingDateTo.HasValue ? filterProcessingDateTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[scheme_processing_date_from]", filterSchemeProcessingDateFrom.HasValue ? filterSchemeProcessingDateFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[scheme_processing_date_to]", filterSchemeProcessingDateTo.HasValue ? filterSchemeProcessingDateTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[clearing_id]", filterClearingId))
                      .Query(_query => _query.Setup("filter[admission.admission_date_from]", filterAdmissionAdmissionDateFrom.HasValue ? filterAdmissionAdmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.admission_date_to]", filterAdmissionAdmissionDateTo.HasValue ? filterAdmissionAdmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.status]", filterAdmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.scheme_status_code]", filterAdmissionSchemeStatusCode))
                      .Query(_query => _query.Setup("filter[amount]", filterAmount))
                      .Query(_query => _query.Setup("filter[reference]", filterReference))
                      .Query(_query => _query.Setup("filter[unique_scheme_id]", filterUniqueSchemeId))
                      .Query(_query => _query.Setup("filter[all_versions]", filterAllVersions))
                      .Query(_query => _query.Setup("filter[submission.submission_date_from]", filterSubmissionSubmissionDateFrom.HasValue ? filterSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.submission_date_to]", filterSubmissionSubmissionDateTo.HasValue ? filterSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[status]", filterStatus))
                      .Query(_query => _query.Setup("filter[status_reason]", filterStatusReason))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Mandate.
        /// </summary>
        /// <param name="mandateCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MandateCreationResponse response from the API call.</returns>
        public Models.MandateCreationResponse PostMandates(
                Models.MandateCreation mandateCreationRequest = null)
            => CoreHelper.RunTask(PostMandatesAsync(mandateCreationRequest));

        /// <summary>
        /// Create Mandate.
        /// </summary>
        /// <param name="mandateCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateCreationResponse response from the API call.</returns>
        public async Task<Models.MandateCreationResponse> PostMandatesAsync(
                Models.MandateCreation mandateCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/mandates")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(mandateCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Mandate creation error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Mandate creation conflict Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch mandate.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <returns>Returns the Models.MandateDetailsResponse response from the API call.</returns>
        public Models.MandateDetailsResponse GetMandatesID(
                Guid id)
            => CoreHelper.RunTask(GetMandatesIDAsync(id));

        /// <summary>
        /// Fetch mandate.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateDetailsResponse> GetMandatesIDAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/mandates/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update mandate.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="mandateAmendment">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MandateDetailsResponse response from the API call.</returns>
        public Models.MandateDetailsResponse PatchMandatesID(
                Guid id,
                Models.MandateAmendment mandateAmendment = null)
            => CoreHelper.RunTask(PatchMandatesIDAsync(id, mandateAmendment));

        /// <summary>
        /// Update mandate.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="mandateAmendment">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateDetailsResponse> PatchMandatesIDAsync(
                Guid id,
                Models.MandateAmendment mandateAmendment = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/transaction/mandates/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(mandateAmendment))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Mandate update error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Mandate Admission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="admissionId">Required parameter: Mandate Admission Id.</param>
        /// <returns>Returns the Models.MandateAdmissionDetailsResponse response from the API call.</returns>
        public Models.MandateAdmissionDetailsResponse GetMandatesIDAdmissionsAdmissionID(
                Guid id,
                Guid admissionId)
            => CoreHelper.RunTask(GetMandatesIDAdmissionsAdmissionIDAsync(id, admissionId));

        /// <summary>
        /// Fetch Mandate Admission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="admissionId">Required parameter: Mandate Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateAdmissionDetailsResponse> GetMandatesIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/mandates/{id}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create mandate return.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MandateReturnCreationResponse response from the API call.</returns>
        public Models.MandateReturnCreationResponse PostMandatesIDReturns(
                Guid id,
                Models.MandateReturnCreation returnCreationRequest = null)
            => CoreHelper.RunTask(PostMandatesIDReturnsAsync(id, returnCreationRequest));

        /// <summary>
        /// Create mandate return.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateReturnCreationResponse response from the API call.</returns>
        public async Task<Models.MandateReturnCreationResponse> PostMandatesIDReturnsAsync(
                Guid id,
                Models.MandateReturnCreation returnCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateReturnCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/mandates/{id}/returns")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(returnCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Return creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch mandate return.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <returns>Returns the Models.MandateReturnDetailsResponse response from the API call.</returns>
        public Models.MandateReturnDetailsResponse GetMandatesIDReturnsReturnID(
                Guid id,
                Guid returnId)
            => CoreHelper.RunTask(GetMandatesIDReturnsReturnIDAsync(id, returnId));

        /// <summary>
        /// Fetch mandate return.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateReturnDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateReturnDetailsResponse> GetMandatesIDReturnsReturnIDAsync(
                Guid id,
                Guid returnId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateReturnDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/mandates/{id}/returns/{returnId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create mandate return submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MandateReturnSubmissionCreationResponse response from the API call.</returns>
        public Models.MandateReturnSubmissionCreationResponse PostMandatesIDReturnsReturnIDSubmissions(
                Guid id,
                Guid returnId,
                Models.MandateReturnSubmissionCreation returnSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostMandatesIDReturnsReturnIDSubmissionsAsync(id, returnId, returnSubmissionCreationRequest));

        /// <summary>
        /// Create mandate return submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateReturnSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.MandateReturnSubmissionCreationResponse> PostMandatesIDReturnsReturnIDSubmissionsAsync(
                Guid id,
                Guid returnId,
                Models.MandateReturnSubmissionCreation returnSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateReturnSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/mandates/{id}/returns/{returnId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(returnSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Return submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.MandateReturnSubmissionDetailsResponse response from the API call.</returns>
        public Models.MandateReturnSubmissionDetailsResponse GetMandatesIDReturnsReturnIDSubmissionsSubmissionID(
                Guid id,
                Guid returnId,
                Guid submissionId)
            => CoreHelper.RunTask(GetMandatesIDReturnsReturnIDSubmissionsSubmissionIDAsync(id, returnId, submissionId));

        /// <summary>
        /// Fetch return submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateReturnSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateReturnSubmissionDetailsResponse> GetMandatesIDReturnsReturnIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid returnId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateReturnSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/mandates/{id}/returns/{returnId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Mandate Submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="mandateSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MandateSubmissionDetailsResponse response from the API call.</returns>
        public Models.MandateSubmissionDetailsResponse PostMandatesIDSubmissions(
                Guid id,
                Models.MandateSubmissionCreation mandateSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostMandatesIDSubmissionsAsync(id, mandateSubmissionCreationRequest));

        /// <summary>
        /// Create Mandate Submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="mandateSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateSubmissionDetailsResponse> PostMandatesIDSubmissionsAsync(
                Guid id,
                Models.MandateSubmissionCreation mandateSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/mandates/{id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(mandateSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Mandate Submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Mandate Submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="submissionId">Required parameter: Mandate Submission Id.</param>
        /// <returns>Returns the Models.MandateSubmissionDetailsResponse response from the API call.</returns>
        public Models.MandateSubmissionDetailsResponse GetMandatesIDSubmissionsSubmissionID(
                Guid id,
                Guid submissionId)
            => CoreHelper.RunTask(GetMandatesIDSubmissionsSubmissionIDAsync(id, submissionId));

        /// <summary>
        /// Fetch Mandate Submission.
        /// </summary>
        /// <param name="id">Required parameter: Mandate Id.</param>
        /// <param name="submissionId">Required parameter: Mandate Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MandateSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.MandateSubmissionDetailsResponse> GetMandatesIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MandateSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/mandates/{id}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}