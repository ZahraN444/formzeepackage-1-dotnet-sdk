// <copyright file="ClaimsController.cs" company="APIMatic">
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
    /// ClaimsController.
    /// </summary>
    public class ClaimsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimsController"/> class.
        /// </summary>
        internal ClaimsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List claims.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterClearingId">Optional parameter: Example: .</param>
        /// <param name="filterReference">Optional parameter: Example: .</param>
        /// <param name="filterReasonCode">Optional parameter: Example: .</param>
        /// <param name="filterContactName">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterOriginalInstructionReference">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterReversalStatus">Optional parameter: Example: .</param>
        /// <param name="filterReversalSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterReversalSubmissionDateTo">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ClaimDetailsListResponse response from the API call.</returns>
        public Models.ClaimDetailsListResponse ListClaims(
                int? pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                string filterPaymentScheme = null,
                string filterClearingId = null,
                string filterReference = null,
                string filterReasonCode = null,
                string filterContactName = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyBankId = null,
                string filterOriginalInstructionReference = null,
                string filterSubmissionStatus = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterReversalStatus = null,
                DateTime? filterReversalSubmissionDateFrom = null,
                DateTime? filterReversalSubmissionDateTo = null)
            => CoreHelper.RunTask(ListClaimsAsync(pageNumber, pageSize, filterOrganisationId, filterPaymentScheme, filterClearingId, filterReference, filterReasonCode, filterContactName, filterDebtorPartyAccountNumber, filterDebtorPartyBankId, filterBeneficiaryPartyAccountNumber, filterBeneficiaryPartyBankId, filterOriginalInstructionReference, filterSubmissionStatus, filterSubmissionSubmissionDateFrom, filterSubmissionSubmissionDateTo, filterReversalStatus, filterReversalSubmissionDateFrom, filterReversalSubmissionDateTo));

        /// <summary>
        /// List claims.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterClearingId">Optional parameter: Example: .</param>
        /// <param name="filterReference">Optional parameter: Example: .</param>
        /// <param name="filterReasonCode">Optional parameter: Example: .</param>
        /// <param name="filterContactName">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterOriginalInstructionReference">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterReversalStatus">Optional parameter: Example: .</param>
        /// <param name="filterReversalSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterReversalSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimDetailsListResponse response from the API call.</returns>
        public async Task<Models.ClaimDetailsListResponse> ListClaimsAsync(
                int? pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                string filterPaymentScheme = null,
                string filterClearingId = null,
                string filterReference = null,
                string filterReasonCode = null,
                string filterContactName = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyBankId = null,
                string filterOriginalInstructionReference = null,
                string filterSubmissionStatus = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterReversalStatus = null,
                DateTime? filterReversalSubmissionDateFrom = null,
                DateTime? filterReversalSubmissionDateTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/claims")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[clearing_id]", filterClearingId))
                      .Query(_query => _query.Setup("filter[reference]", filterReference))
                      .Query(_query => _query.Setup("filter[reason_code]", filterReasonCode))
                      .Query(_query => _query.Setup("filter[contact_name]", filterContactName))
                      .Query(_query => _query.Setup("filter[debtor_party.account_number]", filterDebtorPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[debtor_party.bank_id]", filterDebtorPartyBankId))
                      .Query(_query => _query.Setup("filter[beneficiary_party.account_number]", filterBeneficiaryPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[beneficiary_party.bank_id]", filterBeneficiaryPartyBankId))
                      .Query(_query => _query.Setup("filter[original_instruction.reference]", filterOriginalInstructionReference))
                      .Query(_query => _query.Setup("filter[submission.status]", filterSubmissionStatus))
                      .Query(_query => _query.Setup("filter[submission.submission_date_from]", filterSubmissionSubmissionDateFrom.HasValue ? filterSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.submission_date_to]", filterSubmissionSubmissionDateTo.HasValue ? filterSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[reversal.status]", filterReversalStatus))
                      .Query(_query => _query.Setup("filter[reversal.submission_date_from]", filterReversalSubmissionDateFrom.HasValue ? filterReversalSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[reversal.submission_date_to]", filterReversalSubmissionDateTo.HasValue ? filterReversalSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Claim.
        /// </summary>
        /// <param name="claimCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ClaimDetailsResponse response from the API call.</returns>
        public Models.ClaimDetailsResponse CreateClaim(
                Models.ClaimCreation claimCreationRequest = null)
            => CoreHelper.RunTask(CreateClaimAsync(claimCreationRequest));

        /// <summary>
        /// Create Claim.
        /// </summary>
        /// <param name="claimCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimDetailsResponse> CreateClaimAsync(
                Models.ClaimCreation claimCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/claims")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(claimCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Claim creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch claim.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <returns>Returns the Models.ClaimDetailsResponse response from the API call.</returns>
        public Models.ClaimDetailsResponse FetchClaim(
                Guid id)
            => CoreHelper.RunTask(FetchClaimAsync(id));

        /// <summary>
        /// Fetch claim.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimDetailsResponse> FetchClaimAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/claims/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Claim Reversal.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="claimReversalCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ClaimReversalDetailsResponse response from the API call.</returns>
        public Models.ClaimReversalDetailsResponse CreateClaimReversal(
                Guid id,
                Models.ClaimReversalCreation claimReversalCreationRequest = null)
            => CoreHelper.RunTask(CreateClaimReversalAsync(id, claimReversalCreationRequest));

        /// <summary>
        /// Create Claim Reversal.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="claimReversalCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimReversalDetailsResponse> CreateClaimReversalAsync(
                Guid id,
                Models.ClaimReversalCreation claimReversalCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/claims/{id}/reversals")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(claimReversalCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Claim Reversal creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Claim Reversal.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="reversalId">Required parameter: Claim Reversal Id.</param>
        /// <returns>Returns the Models.ClaimReversalDetailsResponse response from the API call.</returns>
        public Models.ClaimReversalDetailsResponse FetchClaimReversal(
                Guid id,
                Guid reversalId)
            => CoreHelper.RunTask(FetchClaimReversalAsync(id, reversalId));

        /// <summary>
        /// Fetch Claim Reversal.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="reversalId">Required parameter: Claim Reversal Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimReversalDetailsResponse> FetchClaimReversalAsync(
                Guid id,
                Guid reversalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/claims/{id}/reversals/{reversalId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Claim Reversal Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="reversalId">Required parameter: Claim Reversal Id.</param>
        /// <param name="claimReversalSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ClaimReversalSubmissionDetailsResponse response from the API call.</returns>
        public Models.ClaimReversalSubmissionDetailsResponse CreateClaimReversalSubmission(
                Guid id,
                Guid reversalId,
                Models.ClaimReversalSubmissionCreation claimReversalSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateClaimReversalSubmissionAsync(id, reversalId, claimReversalSubmissionCreationRequest));

        /// <summary>
        /// Create Claim Reversal Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="reversalId">Required parameter: Claim Reversal Id.</param>
        /// <param name="claimReversalSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimReversalSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimReversalSubmissionDetailsResponse> CreateClaimReversalSubmissionAsync(
                Guid id,
                Guid reversalId,
                Models.ClaimReversalSubmissionCreation claimReversalSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimReversalSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/claims/{id}/reversals/{reversalId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(claimReversalSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Claim Reversal creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Claim Reversal Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="reversalId">Required parameter: Claim Reversal Id.</param>
        /// <param name="submissionId">Required parameter: Claim Reversal Submission Id.</param>
        /// <returns>Returns the Models.ClaimReversalSubmissionDetailsResponse response from the API call.</returns>
        public Models.ClaimReversalSubmissionDetailsResponse FetchClaimReversalSubmission(
                Guid id,
                Guid reversalId,
                Guid submissionId)
            => CoreHelper.RunTask(FetchClaimReversalSubmissionAsync(id, reversalId, submissionId));

        /// <summary>
        /// Fetch Claim Reversal Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="reversalId">Required parameter: Claim Reversal Id.</param>
        /// <param name="submissionId">Required parameter: Claim Reversal Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimReversalSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimReversalSubmissionDetailsResponse> FetchClaimReversalSubmissionAsync(
                Guid id,
                Guid reversalId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimReversalSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/claims/{id}/reversals/{reversalId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Claim Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="claimSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ClaimSubmissionDetailsResponse response from the API call.</returns>
        public Models.ClaimSubmissionDetailsResponse CreateClaimSubmission(
                Guid id,
                Models.ClaimSubmissionCreation claimSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateClaimSubmissionAsync(id, claimSubmissionCreationRequest));

        /// <summary>
        /// Create Claim Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="claimSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimSubmissionDetailsResponse> CreateClaimSubmissionAsync(
                Guid id,
                Models.ClaimSubmissionCreation claimSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/claims/{id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(claimSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Claim Submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Claim Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="submissionId">Required parameter: Claim Submission Id.</param>
        /// <returns>Returns the Models.ClaimSubmissionDetailsResponse response from the API call.</returns>
        public Models.ClaimSubmissionDetailsResponse FetchClaimSubmission(
                Guid id,
                Guid submissionId)
            => CoreHelper.RunTask(FetchClaimSubmissionAsync(id, submissionId));

        /// <summary>
        /// Fetch Claim Submission.
        /// </summary>
        /// <param name="id">Required parameter: Claim Id.</param>
        /// <param name="submissionId">Required parameter: Claim Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ClaimSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ClaimSubmissionDetailsResponse> FetchClaimSubmissionAsync(
                Guid id,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClaimSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/claims/{id}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}