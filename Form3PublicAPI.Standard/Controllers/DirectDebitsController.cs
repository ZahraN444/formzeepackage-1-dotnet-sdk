// <copyright file="DirectDebitsController.cs" company="APIMatic">
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
    /// DirectDebitsController.
    /// </summary>
    public class DirectDebitsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitsController"/> class.
        /// </summary>
        internal DirectDebitsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List direct debits.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageBefore">Optional parameter: Cursor for previous page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the last page, where the value should be set to "end")..</param>
        /// <param name="pageAfter">Optional parameter: Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the first page, where the value should be set to "start")..</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterCreatedDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterCreatedDateTo">Optional parameter: Example: .</param>
        /// <param name="filterModifiedDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterModifiedDateTo">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterCurrency">Optional parameter: Example: .</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterPaymentType">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterClearingId">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionSchemeStatusCode">Optional parameter: Filter by admission scheme status code.</param>
        /// <param name="filterAmount">Optional parameter: Filter by amount.</param>
        /// <param name="filterReference">Optional parameter: Filter by reference.</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Filter by unique scheme id.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Filter by submission status.</param>
        /// <param name="filterSubmissionSchemeStatusCode">Optional parameter: Filter by submission scheme status code.</param>
        /// <param name="filterRelationships">Optional parameter: Filter for direct debits containing all of the requested relationships.</param>
        /// <param name="filterNotRelationships">Optional parameter: Filter for direct debits containing none of the requested relationships.</param>
        /// <returns>Returns the Models.DirectDebitDetailsListResponse response from the API call.</returns>
        public Models.DirectDebitDetailsListResponse GetDirectdebits(
                string pageNumber = null,
                string pageBefore = null,
                string pageAfter = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                DateTime? filterCreatedDateFrom = null,
                DateTime? filterCreatedDateTo = null,
                DateTime? filterModifiedDateFrom = null,
                DateTime? filterModifiedDateTo = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyBankId = null,
                string filterCurrency = null,
                string filterPaymentScheme = null,
                string filterPaymentType = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                string filterClearingId = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionSchemeStatusCode = null,
                string filterAmount = null,
                string filterReference = null,
                string filterUniqueSchemeId = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterSubmissionStatus = null,
                string filterSubmissionSchemeStatusCode = null,
                List<Models.FilterRelationshipsEnum> filterRelationships = null,
                List<Models.FilterNotRelationshipsEnum> filterNotRelationships = null)
            => CoreHelper.RunTask(GetDirectdebitsAsync(pageNumber, pageBefore, pageAfter, pageSize, filterOrganisationId, filterCreatedDateFrom, filterCreatedDateTo, filterModifiedDateFrom, filterModifiedDateTo, filterDebtorPartyAccountNumber, filterDebtorPartyBankId, filterBeneficiaryPartyAccountNumber, filterBeneficiaryPartyBankId, filterCurrency, filterPaymentScheme, filterPaymentType, filterProcessingDateFrom, filterProcessingDateTo, filterClearingId, filterAdmissionAdmissionDateFrom, filterAdmissionAdmissionDateTo, filterAdmissionStatus, filterAdmissionSchemeStatusCode, filterAmount, filterReference, filterUniqueSchemeId, filterSubmissionSubmissionDateFrom, filterSubmissionSubmissionDateTo, filterSubmissionStatus, filterSubmissionSchemeStatusCode, filterRelationships, filterNotRelationships));

        /// <summary>
        /// List direct debits.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageBefore">Optional parameter: Cursor for previous page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the last page, where the value should be set to "end")..</param>
        /// <param name="pageAfter">Optional parameter: Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the first page, where the value should be set to "start")..</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterCreatedDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterCreatedDateTo">Optional parameter: Example: .</param>
        /// <param name="filterModifiedDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterModifiedDateTo">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterCurrency">Optional parameter: Example: .</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterPaymentType">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterClearingId">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionSchemeStatusCode">Optional parameter: Filter by admission scheme status code.</param>
        /// <param name="filterAmount">Optional parameter: Filter by amount.</param>
        /// <param name="filterReference">Optional parameter: Filter by reference.</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Filter by unique scheme id.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Filter by submission status.</param>
        /// <param name="filterSubmissionSchemeStatusCode">Optional parameter: Filter by submission scheme status code.</param>
        /// <param name="filterRelationships">Optional parameter: Filter for direct debits containing all of the requested relationships.</param>
        /// <param name="filterNotRelationships">Optional parameter: Filter for direct debits containing none of the requested relationships.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDetailsListResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDetailsListResponse> GetDirectdebitsAsync(
                string pageNumber = null,
                string pageBefore = null,
                string pageAfter = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                DateTime? filterCreatedDateFrom = null,
                DateTime? filterCreatedDateTo = null,
                DateTime? filterModifiedDateFrom = null,
                DateTime? filterModifiedDateTo = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyBankId = null,
                string filterCurrency = null,
                string filterPaymentScheme = null,
                string filterPaymentType = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                string filterClearingId = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionSchemeStatusCode = null,
                string filterAmount = null,
                string filterReference = null,
                string filterUniqueSchemeId = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterSubmissionStatus = null,
                string filterSubmissionSchemeStatusCode = null,
                List<Models.FilterRelationshipsEnum> filterRelationships = null,
                List<Models.FilterNotRelationshipsEnum> filterNotRelationships = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[before]", pageBefore))
                      .Query(_query => _query.Setup("page[after]", pageAfter))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[created_date_from]", filterCreatedDateFrom.HasValue ? filterCreatedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[created_date_to]", filterCreatedDateTo.HasValue ? filterCreatedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[modified_date_from]", filterModifiedDateFrom.HasValue ? filterModifiedDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[modified_date_to]", filterModifiedDateTo.HasValue ? filterModifiedDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[debtor_party.account_number]", filterDebtorPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[debtor_party.bank_id]", filterDebtorPartyBankId))
                      .Query(_query => _query.Setup("filter[beneficiary_party.account_number]", filterBeneficiaryPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[beneficiary_party.bank_id]", filterBeneficiaryPartyBankId))
                      .Query(_query => _query.Setup("filter[currency]", filterCurrency))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[payment_type]", filterPaymentType))
                      .Query(_query => _query.Setup("filter[processing_date_from]", filterProcessingDateFrom.HasValue ? filterProcessingDateFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[processing_date_to]", filterProcessingDateTo.HasValue ? filterProcessingDateTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[clearing_id]", filterClearingId))
                      .Query(_query => _query.Setup("filter[admission.admission_date_from]", filterAdmissionAdmissionDateFrom.HasValue ? filterAdmissionAdmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.admission_date_to]", filterAdmissionAdmissionDateTo.HasValue ? filterAdmissionAdmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.status]", filterAdmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.scheme_status_code]", filterAdmissionSchemeStatusCode))
                      .Query(_query => _query.Setup("filter[amount]", filterAmount))
                      .Query(_query => _query.Setup("filter[reference]", filterReference))
                      .Query(_query => _query.Setup("filter[unique_scheme_id]", filterUniqueSchemeId))
                      .Query(_query => _query.Setup("filter[submission.submission_date_from]", filterSubmissionSubmissionDateFrom.HasValue ? filterSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.submission_date_to]", filterSubmissionSubmissionDateTo.HasValue ? filterSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.status]", filterSubmissionStatus))
                      .Query(_query => _query.Setup("filter[submission.scheme_status_code]", filterSubmissionSchemeStatusCode))
                      .Query(_query => _query.Setup("filter[relationships]", filterRelationships?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter[not_relationships]", filterNotRelationships?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Direct debit.
        /// </summary>
        /// <param name="directDebitCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitCreationResponse response from the API call.</returns>
        public Models.DirectDebitCreationResponse PostDirectdebits(
                Models.DirectDebitCreation directDebitCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsAsync(directDebitCreationRequest));

        /// <summary>
        /// Create Direct debit.
        /// </summary>
        /// <param name="directDebitCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitCreationResponse> PostDirectdebitsAsync(
                Models.DirectDebitCreation directDebitCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(directDebitCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Direct Debit creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch direct debit.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <returns>Returns the Models.DirectDebitDetailsResponse response from the API call.</returns>
        public Models.DirectDebitDetailsResponse GetDirectdebitsID(
                Guid id)
            => CoreHelper.RunTask(GetDirectdebitsIDAsync(id));

        /// <summary>
        /// Fetch direct debit.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDetailsResponse> GetDirectdebitsIDAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Direct Debit Admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <returns>Returns the Models.DirectDebitAdmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitAdmissionDetailsResponse GetDirectdebitsIDAdmissionsAdmissionID(
                Guid id,
                Guid admissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDAdmissionsAdmissionIDAsync(id, admissionId));

        /// <summary>
        /// Fetch Direct Debit Admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitAdmissionDetailsResponse> GetDirectdebitsIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create direct debit decision.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="directDebitDecisionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitDecisionCreationResponse response from the API call.</returns>
        public Models.DirectDebitDecisionCreationResponse PostDirectdebitsIDDecisions(
                Guid id,
                Models.DirectDebitDecisionCreation directDebitDecisionCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDDecisionsAsync(id, directDebitDecisionCreationRequest));

        /// <summary>
        /// Create direct debit decision.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="directDebitDecisionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDecisionCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDecisionCreationResponse> PostDirectdebitsIDDecisionsAsync(
                Guid id,
                Models.DirectDebitDecisionCreation directDebitDecisionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDecisionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/decisions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(directDebitDecisionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Direct Debit decision creation error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Direct Debit decision creation conflict error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get direct debit decision.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <returns>Returns the Models.DirectDebitDecisionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitDecisionDetailsResponse GetDirectdebitsIDDecisionsDecisionID(
                Guid id,
                Guid decisionId)
            => CoreHelper.RunTask(GetDirectdebitsIDDecisionsDecisionIDAsync(id, decisionId));

        /// <summary>
        /// Get direct debit decision.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDecisionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDecisionDetailsResponse> GetDirectdebitsIDDecisionsDecisionIDAsync(
                Guid id,
                Guid decisionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDecisionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/decisions/{decisionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("decisionId", decisionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create direct debit decision admissions.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="directDebitAdmissionSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitDecisionAdmissionCreationResponse response from the API call.</returns>
        public Models.DirectDebitDecisionAdmissionCreationResponse PostDirectdebitsIDDecisionsDecisionIDAdmissions(
                Guid id,
                Guid decisionId,
                Models.DirectDebitDecisionAdmissionCreation directDebitAdmissionSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDDecisionsDecisionIDAdmissionsAsync(id, decisionId, directDebitAdmissionSubmissionCreationRequest));

        /// <summary>
        /// Create direct debit decision admissions.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="directDebitAdmissionSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDecisionAdmissionCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDecisionAdmissionCreationResponse> PostDirectdebitsIDDecisionsDecisionIDAdmissionsAsync(
                Guid id,
                Guid decisionId,
                Models.DirectDebitDecisionAdmissionCreation directDebitAdmissionSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDecisionAdmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/decisions/{decisionId}/admissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(directDebitAdmissionSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Direct Debit decision admission creation error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Direct Debit decision submission creation conflict error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch decision admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <returns>Returns the Models.DirectDebitDecisionAdmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitDecisionAdmissionDetailsResponse GetDirectdebitsIDDecisionsDecisionIDAdmissionsAdmissionID(
                Guid id,
                Guid decisionId,
                Guid admissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDDecisionsDecisionIDAdmissionsAdmissionIDAsync(id, decisionId, admissionId));

        /// <summary>
        /// Fetch decision admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDecisionAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDecisionAdmissionDetailsResponse> GetDirectdebitsIDDecisionsDecisionIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid decisionId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDecisionAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/decisions/{decisionId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create direct debit decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="directDebitDecisionSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitDecisionSubmissionCreationResponse response from the API call.</returns>
        public Models.DirectDebitDecisionSubmissionCreationResponse PostDirectdebitsIDDecisionsDecisionIDSubmissions(
                Guid id,
                Guid decisionId,
                Models.DirectDebitDecisionSubmissionCreation directDebitDecisionSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDDecisionsDecisionIDSubmissionsAsync(id, decisionId, directDebitDecisionSubmissionCreationRequest));

        /// <summary>
        /// Create direct debit decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="directDebitDecisionSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDecisionSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDecisionSubmissionCreationResponse> PostDirectdebitsIDDecisionsDecisionIDSubmissionsAsync(
                Guid id,
                Guid decisionId,
                Models.DirectDebitDecisionSubmissionCreation directDebitDecisionSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDecisionSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/decisions/{decisionId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(directDebitDecisionSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Direct Debit decision submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Direct Debit decision submission creation conflict error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get direct debit decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <returns>Returns the Models.DirectDebitDecisionSubmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitDecisionSubmissionDetailsResponse GetDirectdebitsIDDecisionsDecisionIDSubmissionsSubmissionID(
                Guid id,
                Guid decisionId,
                Guid submissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDDecisionsDecisionIDSubmissionsSubmissionIDAsync(id, decisionId, submissionId));

        /// <summary>
        /// Get direct debit decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="decisionId">Required parameter: Direct Debit decision id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitDecisionSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitDecisionSubmissionDetailsResponse> GetDirectdebitsIDDecisionsDecisionIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid decisionId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitDecisionSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/decisions/{decisionId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create recall.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitRecallCreationResponse response from the API call.</returns>
        public Models.DirectDebitRecallCreationResponse PostDirectdebitsIDRecalls(
                Guid id,
                Models.DirectDebitRecallCreation recallCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDRecallsAsync(id, recallCreationRequest));

        /// <summary>
        /// Create recall.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitRecallCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitRecallCreationResponse> PostDirectdebitsIDRecallsAsync(
                Guid id,
                Models.DirectDebitRecallCreation recallCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitRecallCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/recalls")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(recallCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Recall creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <returns>Returns the Models.DirectDebitRecallDetailsResponse response from the API call.</returns>
        public Models.DirectDebitRecallDetailsResponse GetDirectdebitsIDRecallsRecallID(
                Guid id,
                Guid recallId)
            => CoreHelper.RunTask(GetDirectdebitsIDRecallsRecallIDAsync(id, recallId));

        /// <summary>
        /// Fetch recall.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitRecallDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitRecallDetailsResponse> GetDirectdebitsIDRecallsRecallIDAsync(
                Guid id,
                Guid recallId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitRecallDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/recalls/{recallId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <returns>Returns the Models.DirectDebitRecallAdmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitRecallAdmissionDetailsResponse GetDirectdebitsIDRecallsRecallIDAdmissionsAdmissionID(
                Guid id,
                Guid recallId,
                Guid admissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDRecallsRecallIDAdmissionsAdmissionIDAsync(id, recallId, admissionId));

        /// <summary>
        /// Fetch recall admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitRecallAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitRecallAdmissionDetailsResponse> GetDirectdebitsIDRecallsRecallIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid recallId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitRecallAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/recalls/{recallId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <returns>Returns the Models.DirectDebitRecallSubmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitRecallSubmissionDetailsResponse GetDirectdebitsIDRecallsRecallIDSubmissionsSubmissionID(
                Guid id,
                Guid recallId,
                Guid submissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDRecallsRecallIDSubmissionsSubmissionIDAsync(id, recallId, submissionId));

        /// <summary>
        /// Fetch recall submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitRecallSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitRecallSubmissionDetailsResponse> GetDirectdebitsIDRecallsRecallIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid recallId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitRecallSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/recalls/{recallId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create direct debit return.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitReturnCreationResponse response from the API call.</returns>
        public Models.DirectDebitReturnCreationResponse PostDirectdebitsIDReturns(
                Guid id,
                Models.DirectDebitReturnCreation returnCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDReturnsAsync(id, returnCreationRequest));

        /// <summary>
        /// Create direct debit return.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnCreationResponse> PostDirectdebitsIDReturnsAsync(
                Guid id,
                Models.DirectDebitReturnCreation returnCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/returns")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(returnCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Return creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch direct debit return.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <returns>Returns the Models.DirectDebitReturnDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReturnDetailsResponse GetDirectdebitsIDReturnsReturnID(
                Guid id,
                Guid returnId)
            => CoreHelper.RunTask(GetDirectdebitsIDReturnsReturnIDAsync(id, returnId));

        /// <summary>
        /// Fetch direct debit return.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnDetailsResponse> GetDirectdebitsIDReturnsReturnIDAsync(
                Guid id,
                Guid returnId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/returns/{returnId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <returns>Returns the Models.DirectDebitReturnAdmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReturnAdmissionDetailsResponse GetDirectdebitsIDReturnsReturnIDAdmissionsAdmissionID(
                Guid id,
                Guid returnId,
                Guid admissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDReturnsReturnIDAdmissionsAdmissionIDAsync(id, returnId, admissionId));

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnAdmissionDetailsResponse> GetDirectdebitsIDReturnsReturnIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid returnId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/returns/{returnId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <returns>Returns the Models.DirectDebitReturnReversalDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReturnReversalDetailsResponse GetDirectdebitsIDReturnsReturnIDReversalsReversalID(
                Guid id,
                Guid returnId,
                Guid reversalId)
            => CoreHelper.RunTask(GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAsync(id, returnId, reversalId));

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnReversalDetailsResponse> GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAsync(
                Guid id,
                Guid returnId,
                Guid reversalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/returns/{returnId}/reversals/{reversalId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("reversalId", reversalId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <returns>Returns the Models.DirectDebitReturnReversalAdmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReturnReversalAdmissionDetailsResponse GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAdmissionsAdmissionID(
                Guid id,
                Guid returnId,
                Guid reversalId,
                Guid admissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAdmissionsAdmissionIDAsync(id, returnId, reversalId, admissionId));

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnReversalAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnReversalAdmissionDetailsResponse> GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid returnId,
                Guid reversalId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnReversalAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/returns/{returnId}/reversals/{reversalId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create direct debit return submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitReturnSubmissionCreationResponse response from the API call.</returns>
        public Models.DirectDebitReturnSubmissionCreationResponse PostDirectdebitsIDReturnsReturnIDSubmissions(
                Guid id,
                Guid returnId,
                Models.DirectDebitReturnSubmissionCreation returnSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDReturnsReturnIDSubmissionsAsync(id, returnId, returnSubmissionCreationRequest));

        /// <summary>
        /// create direct debit return submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnSubmissionCreationResponse> PostDirectdebitsIDReturnsReturnIDSubmissionsAsync(
                Guid id,
                Guid returnId,
                Models.DirectDebitReturnSubmissionCreation returnSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/returns/{returnId}/submissions")
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
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <returns>Returns the Models.DirectDebitReturnSubmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReturnSubmissionDetailsResponse GetDirectdebitsIDReturnsReturnIDSubmissionsSubmissionID(
                Guid id,
                Guid returnId,
                Guid submissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDReturnsReturnIDSubmissionsSubmissionIDAsync(id, returnId, submissionId));

        /// <summary>
        /// Fetch return submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReturnSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReturnSubmissionDetailsResponse> GetDirectdebitsIDReturnsReturnIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid returnId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReturnSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/returns/{returnId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create direct debit reversal.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitReversalCreationResponse response from the API call.</returns>
        public Models.DirectDebitReversalCreationResponse PostDirectdebitsIDReversals(
                Guid id,
                Models.DirectDebitReversalCreation reversalCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDReversalsAsync(id, reversalCreationRequest));

        /// <summary>
        /// Create direct debit reversal.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReversalCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReversalCreationResponse> PostDirectdebitsIDReversalsAsync(
                Guid id,
                Models.DirectDebitReversalCreation reversalCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReversalCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/reversals")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(reversalCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reversal creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch direct debit reversal.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <returns>Returns the Models.DirectDebitReversalDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReversalDetailsResponse GetDirectdebitsIDReversalsReversalID(
                Guid id,
                Guid reversalId)
            => CoreHelper.RunTask(GetDirectdebitsIDReversalsReversalIDAsync(id, reversalId));

        /// <summary>
        /// Fetch direct debit reversal.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReversalDetailsResponse> GetDirectdebitsIDReversalsReversalIDAsync(
                Guid id,
                Guid reversalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/reversals/{reversalId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <returns>Returns the Models.DirectDebitReversalAdmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReversalAdmissionDetailsResponse GetDirectdebitsIDReversalsReversalIDAdmissionsAdmissionID(
                Guid id,
                Guid reversalId,
                Guid admissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDReversalsReversalIDAdmissionsAdmissionIDAsync(id, reversalId, admissionId));

        /// <summary>
        /// Fetch reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Direct Debit Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReversalAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReversalAdmissionDetailsResponse> GetDirectdebitsIDReversalsReversalIDAdmissionsAdmissionIDAsync(
                Guid id,
                Guid reversalId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReversalAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/reversals/{reversalId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="reversalSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitReversalSubmissionCreationResponse response from the API call.</returns>
        public Models.DirectDebitReversalSubmissionCreationResponse PostDirectdebitsIDReversalsReversalIDSubmissions(
                Guid id,
                Guid reversalId,
                Models.DirectDebitReversalSubmissionCreation reversalSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDReversalsReversalIDSubmissionsAsync(id, reversalId, reversalSubmissionCreationRequest));

        /// <summary>
        /// create reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="reversalSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReversalSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReversalSubmissionCreationResponse> PostDirectdebitsIDReversalsReversalIDSubmissionsAsync(
                Guid id,
                Guid reversalId,
                Models.DirectDebitReversalSubmissionCreation reversalSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReversalSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/reversals/{reversalId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(reversalSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reversal submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <returns>Returns the Models.DirectDebitReversalSubmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitReversalSubmissionDetailsResponse GetDirectdebitsIDReversalsReversalIDSubmissionsSubmissionID(
                Guid id,
                Guid reversalId,
                Guid submissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDReversalsReversalIDSubmissionsSubmissionIDAsync(id, reversalId, submissionId));

        /// <summary>
        /// Fetch reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitReversalSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitReversalSubmissionDetailsResponse> GetDirectdebitsIDReversalsReversalIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid reversalId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitReversalSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/reversals/{reversalId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create direct debit submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="directDebitSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DirectDebitSubmissionCreationResponse response from the API call.</returns>
        public Models.DirectDebitSubmissionCreationResponse PostDirectdebitsIDSubmissions(
                Guid id,
                Models.DirectDebitSubmissionCreation directDebitSubmissionCreationRequest = null)
            => CoreHelper.RunTask(PostDirectdebitsIDSubmissionsAsync(id, directDebitSubmissionCreationRequest));

        /// <summary>
        /// Create direct debit submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="directDebitSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.DirectDebitSubmissionCreationResponse> PostDirectdebitsIDSubmissionsAsync(
                Guid id,
                Models.DirectDebitSubmissionCreation directDebitSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/directdebits/{id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(directDebitSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Return submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get direct debit submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <returns>Returns the Models.DirectDebitSubmissionDetailsResponse response from the API call.</returns>
        public Models.DirectDebitSubmissionDetailsResponse GetDirectdebitsIDSubmissionsSubmissionID(
                Guid id,
                Guid submissionId)
            => CoreHelper.RunTask(GetDirectdebitsIDSubmissionsSubmissionIDAsync(id, submissionId));

        /// <summary>
        /// Get direct debit submission.
        /// </summary>
        /// <param name="id">Required parameter: Direct Debit Id.</param>
        /// <param name="submissionId">Required parameter: Direct Debit decision submission id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DirectDebitSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.DirectDebitSubmissionDetailsResponse> GetDirectdebitsIDSubmissionsSubmissionIDAsync(
                Guid id,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/directdebits/{id}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}