// <copyright file="PaymentsController.cs" company="APIMatic">
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
    /// PaymentsController.
    /// </summary>
    public class PaymentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsController"/> class.
        /// </summary>
        internal PaymentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List Positions.
        /// </summary>
        /// <returns>Returns the Models.PositionDetailsListResponse response from the API call.</returns>
        public Models.PositionDetailsListResponse ListPositions()
            => CoreHelper.RunTask(ListPositionsAsync());

        /// <summary>
        /// List Positions.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PositionDetailsListResponse response from the API call.</returns>
        public async Task<Models.PositionDetailsListResponse> ListPositionsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PositionDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/positions")
                  .WithAuth("OAuth2"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List payments.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="pageBefore">Optional parameter: Cursor for previous page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the last page, where the value should be set to "end")..</param>
        /// <param name="pageAfter">Optional parameter: Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the first page, where the value should be set to "start")..</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyAccountName">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountName">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterCurrency">Optional parameter: Example: .</param>
        /// <param name="filterEndToEndReference">Optional parameter: Example: .</param>
        /// <param name="filterReturnUniqueSchemeId">Optional parameter: Example: .</param>
        /// <param name="filterSchemeTransactionId">Optional parameter: Example: .</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterPaymentType">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Example: .</param>
        /// <param name="filterAmount">Optional parameter: Example: .</param>
        /// <param name="filterReference">Optional parameter: Example: .</param>
        /// <param name="filterRoute">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Filter by submission status.</param>
        /// <param name="filterSubmissionSchemeStatusCode">Optional parameter: Filter by submission scheme status code.</param>
        /// <param name="filterReturnSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterReturnSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterReturnSubmissionStatus">Optional parameter: Filter by return submission status.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionSchemeStatusCode">Optional parameter: Filter by admission scheme status code.</param>
        /// <param name="filterRelationships">Optional parameter: Filter for payments containing all of the requested relationships.</param>
        /// <param name="filterNotRelationships">Optional parameter: Filter for payments containing none of the requested relationships.</param>
        /// <returns>Returns the Models.PaymentDetailsListResponse response from the API call.</returns>
        public Models.PaymentDetailsListResponse ListPayments(
                string pageNumber = null,
                int? pageSize = null,
                string pageBefore = null,
                string pageAfter = null,
                List<Guid> filterOrganisationId = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyAccountName = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyAccountName = null,
                string filterBeneficiaryPartyBankId = null,
                string filterCurrency = null,
                string filterEndToEndReference = null,
                string filterReturnUniqueSchemeId = null,
                string filterSchemeTransactionId = null,
                string filterPaymentScheme = null,
                string filterPaymentType = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                string filterUniqueSchemeId = null,
                string filterAmount = null,
                string filterReference = null,
                string filterRoute = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterSubmissionStatus = null,
                string filterSubmissionSchemeStatusCode = null,
                DateTime? filterReturnSubmissionSubmissionDateFrom = null,
                DateTime? filterReturnSubmissionSubmissionDateTo = null,
                string filterReturnSubmissionStatus = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionSchemeStatusCode = null,
                List<Models.FilterRelationships1Enum> filterRelationships = null,
                List<Models.FilterNotRelationships1Enum> filterNotRelationships = null)
            => CoreHelper.RunTask(ListPaymentsAsync(pageNumber, pageSize, pageBefore, pageAfter, filterOrganisationId, filterDebtorPartyAccountNumber, filterDebtorPartyAccountName, filterDebtorPartyBankId, filterBeneficiaryPartyAccountNumber, filterBeneficiaryPartyAccountName, filterBeneficiaryPartyBankId, filterCurrency, filterEndToEndReference, filterReturnUniqueSchemeId, filterSchemeTransactionId, filterPaymentScheme, filterPaymentType, filterProcessingDateFrom, filterProcessingDateTo, filterUniqueSchemeId, filterAmount, filterReference, filterRoute, filterSubmissionSubmissionDateFrom, filterSubmissionSubmissionDateTo, filterSubmissionStatus, filterSubmissionSchemeStatusCode, filterReturnSubmissionSubmissionDateFrom, filterReturnSubmissionSubmissionDateTo, filterReturnSubmissionStatus, filterAdmissionAdmissionDateFrom, filterAdmissionAdmissionDateTo, filterAdmissionStatus, filterAdmissionSchemeStatusCode, filterRelationships, filterNotRelationships));

        /// <summary>
        /// List payments.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="pageBefore">Optional parameter: Cursor for previous page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the last page, where the value should be set to "end")..</param>
        /// <param name="pageAfter">Optional parameter: Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the first page, where the value should be set to "start")..</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterDebtorPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyAccountName">Optional parameter: Example: .</param>
        /// <param name="filterDebtorPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountNumber">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyAccountName">Optional parameter: Example: .</param>
        /// <param name="filterBeneficiaryPartyBankId">Optional parameter: Example: .</param>
        /// <param name="filterCurrency">Optional parameter: Example: .</param>
        /// <param name="filterEndToEndReference">Optional parameter: Example: .</param>
        /// <param name="filterReturnUniqueSchemeId">Optional parameter: Example: .</param>
        /// <param name="filterSchemeTransactionId">Optional parameter: Example: .</param>
        /// <param name="filterPaymentScheme">Optional parameter: Example: .</param>
        /// <param name="filterPaymentType">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Example: .</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Example: .</param>
        /// <param name="filterAmount">Optional parameter: Example: .</param>
        /// <param name="filterReference">Optional parameter: Example: .</param>
        /// <param name="filterRoute">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Filter by submission status.</param>
        /// <param name="filterSubmissionSchemeStatusCode">Optional parameter: Filter by submission scheme status code.</param>
        /// <param name="filterReturnSubmissionSubmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterReturnSubmissionSubmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterReturnSubmissionStatus">Optional parameter: Filter by return submission status.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Example: .</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Filter by admission status.</param>
        /// <param name="filterAdmissionSchemeStatusCode">Optional parameter: Filter by admission scheme status code.</param>
        /// <param name="filterRelationships">Optional parameter: Filter for payments containing all of the requested relationships.</param>
        /// <param name="filterNotRelationships">Optional parameter: Filter for payments containing none of the requested relationships.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentDetailsListResponse response from the API call.</returns>
        public async Task<Models.PaymentDetailsListResponse> ListPaymentsAsync(
                string pageNumber = null,
                int? pageSize = null,
                string pageBefore = null,
                string pageAfter = null,
                List<Guid> filterOrganisationId = null,
                string filterDebtorPartyAccountNumber = null,
                string filterDebtorPartyAccountName = null,
                string filterDebtorPartyBankId = null,
                string filterBeneficiaryPartyAccountNumber = null,
                string filterBeneficiaryPartyAccountName = null,
                string filterBeneficiaryPartyBankId = null,
                string filterCurrency = null,
                string filterEndToEndReference = null,
                string filterReturnUniqueSchemeId = null,
                string filterSchemeTransactionId = null,
                string filterPaymentScheme = null,
                string filterPaymentType = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                string filterUniqueSchemeId = null,
                string filterAmount = null,
                string filterReference = null,
                string filterRoute = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterSubmissionStatus = null,
                string filterSubmissionSchemeStatusCode = null,
                DateTime? filterReturnSubmissionSubmissionDateFrom = null,
                DateTime? filterReturnSubmissionSubmissionDateTo = null,
                string filterReturnSubmissionStatus = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                string filterAdmissionStatus = null,
                string filterAdmissionSchemeStatusCode = null,
                List<Models.FilterRelationships1Enum> filterRelationships = null,
                List<Models.FilterNotRelationships1Enum> filterNotRelationships = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("page[before]", pageBefore))
                      .Query(_query => _query.Setup("page[after]", pageAfter))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[debtor_party.account_number]", filterDebtorPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[debtor_party.account_name]", filterDebtorPartyAccountName))
                      .Query(_query => _query.Setup("filter[debtor_party.bank_id]", filterDebtorPartyBankId))
                      .Query(_query => _query.Setup("filter[beneficiary_party.account_number]", filterBeneficiaryPartyAccountNumber))
                      .Query(_query => _query.Setup("filter[beneficiary_party.account_name]", filterBeneficiaryPartyAccountName))
                      .Query(_query => _query.Setup("filter[beneficiary_party.bank_id]", filterBeneficiaryPartyBankId))
                      .Query(_query => _query.Setup("filter[currency]", filterCurrency))
                      .Query(_query => _query.Setup("filter[end_to_end_reference]", filterEndToEndReference))
                      .Query(_query => _query.Setup("filter[return.unique_scheme_id]", filterReturnUniqueSchemeId))
                      .Query(_query => _query.Setup("filter[scheme_transaction_id]", filterSchemeTransactionId))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[payment_type]", filterPaymentType))
                      .Query(_query => _query.Setup("filter[processing_date_from]", filterProcessingDateFrom.HasValue ? filterProcessingDateFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[processing_date_to]", filterProcessingDateTo.HasValue ? filterProcessingDateTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[unique_scheme_id]", filterUniqueSchemeId))
                      .Query(_query => _query.Setup("filter[amount]", filterAmount))
                      .Query(_query => _query.Setup("filter[reference]", filterReference))
                      .Query(_query => _query.Setup("filter[route]", filterRoute))
                      .Query(_query => _query.Setup("filter[submission.submission_date_from]", filterSubmissionSubmissionDateFrom.HasValue ? filterSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.submission_date_to]", filterSubmissionSubmissionDateTo.HasValue ? filterSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.status]", filterSubmissionStatus))
                      .Query(_query => _query.Setup("filter[submission.scheme_status_code]", filterSubmissionSchemeStatusCode))
                      .Query(_query => _query.Setup("filter[return_submission.submission_date_from]", filterReturnSubmissionSubmissionDateFrom.HasValue ? filterReturnSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[return_submission.submission_date_to]", filterReturnSubmissionSubmissionDateTo.HasValue ? filterReturnSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[return_submission.status]", filterReturnSubmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.admission_date_from]", filterAdmissionAdmissionDateFrom.HasValue ? filterAdmissionAdmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.admission_date_to]", filterAdmissionAdmissionDateTo.HasValue ? filterAdmissionAdmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.status]", filterAdmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.scheme_status_code]", filterAdmissionSchemeStatusCode))
                      .Query(_query => _query.Setup("filter[relationships]", filterRelationships?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter[not_relationships]", filterNotRelationships?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create payment.
        /// </summary>
        /// <param name="paymentCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentCreationResponse response from the API call.</returns>
        public Models.PaymentCreationResponse CreatePayment(
                Models.PaymentCreation paymentCreationRequest = null)
            => CoreHelper.RunTask(CreatePaymentAsync(paymentCreationRequest));

        /// <summary>
        /// Create payment.
        /// </summary>
        /// <param name="paymentCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentCreationResponse response from the API call.</returns>
        public async Task<Models.PaymentCreationResponse> CreatePaymentAsync(
                Models.PaymentCreation paymentCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(paymentCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Payment creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch payment.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <returns>Returns the Models.PaymentDetailsResponse response from the API call.</returns>
        public Models.PaymentDetailsResponse FetchPayment(
                Guid id)
            => CoreHelper.RunTask(FetchPaymentAsync(id));

        /// <summary>
        /// Fetch payment.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentDetailsResponse response from the API call.</returns>
        public async Task<Models.PaymentDetailsResponse> FetchPaymentAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.PaymentAdmissionDetailsResponse response from the API call.</returns>
        public Models.PaymentAdmissionDetailsResponse FetchAdmission(
                Guid id,
                Guid admissionId)
            => CoreHelper.RunTask(FetchAdmissionAsync(id, admissionId));

        /// <summary>
        /// Fetch admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.PaymentAdmissionDetailsResponse> FetchAdmissionAsync(
                Guid id,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List tasks.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.PaymentAdmissionTaskListResponse response from the API call.</returns>
        public Models.PaymentAdmissionTaskListResponse ListTasks(
                Guid id,
                Guid admissionId)
            => CoreHelper.RunTask(ListTasksAsync(id, admissionId));

        /// <summary>
        /// List tasks.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentAdmissionTaskListResponse response from the API call.</returns>
        public async Task<Models.PaymentAdmissionTaskListResponse> ListTasksAsync(
                Guid id,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAdmissionTaskListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/admissions/{admissionId}/tasks")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Payment Admission Task By ID.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="taskId">Required parameter: Payment Admission Task Id.</param>
        /// <returns>Returns the Models.PaymentAdmissionTaskDetailsResponse response from the API call.</returns>
        public Models.PaymentAdmissionTaskDetailsResponse GetPaymentAdmissionTaskByID(
                Guid id,
                Guid admissionId,
                Guid taskId)
            => CoreHelper.RunTask(GetPaymentAdmissionTaskByIDAsync(id, admissionId, taskId));

        /// <summary>
        /// Get Payment Admission Task By ID.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="taskId">Required parameter: Payment Admission Task Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentAdmissionTaskDetailsResponse response from the API call.</returns>
        public async Task<Models.PaymentAdmissionTaskDetailsResponse> GetPaymentAdmissionTaskByIDAsync(
                Guid id,
                Guid admissionId,
                Guid taskId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAdmissionTaskDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/admissions/{admissionId}/tasks/{taskId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))
                      .Template(_template => _template.Setup("taskId", taskId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Patch Payment Admission Task.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="taskId">Required parameter: Payment Admission Task Id.</param>
        /// <param name="paymentAdmissionTaskPatchRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentAdmissionTaskDetailsResponse response from the API call.</returns>
        public Models.PaymentAdmissionTaskDetailsResponse PatchPaymentAdmissionTask(
                Guid id,
                Guid admissionId,
                Guid taskId,
                Models.PaymentAdmissionTaskAmendment paymentAdmissionTaskPatchRequest = null)
            => CoreHelper.RunTask(PatchPaymentAdmissionTaskAsync(id, admissionId, taskId, paymentAdmissionTaskPatchRequest));

        /// <summary>
        /// Patch Payment Admission Task.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="taskId">Required parameter: Payment Admission Task Id.</param>
        /// <param name="paymentAdmissionTaskPatchRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentAdmissionTaskDetailsResponse response from the API call.</returns>
        public async Task<Models.PaymentAdmissionTaskDetailsResponse> PatchPaymentAdmissionTaskAsync(
                Guid id,
                Guid admissionId,
                Guid taskId,
                Models.PaymentAdmissionTaskAmendment paymentAdmissionTaskPatchRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAdmissionTaskDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/transaction/payments/{id}/admissions/{admissionId}/tasks/{taskId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(paymentAdmissionTaskPatchRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))
                      .Template(_template => _template.Setup("taskId", taskId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create advice.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AdviceCreationResponse response from the API call.</returns>
        public Models.AdviceCreationResponse CreateAdvice(
                Guid id,
                Models.AdviceCreation adviceCreationRequest = null)
            => CoreHelper.RunTask(CreateAdviceAsync(id, adviceCreationRequest));

        /// <summary>
        /// Create advice.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AdviceCreationResponse response from the API call.</returns>
        public async Task<Models.AdviceCreationResponse> CreateAdviceAsync(
                Guid id,
                Models.AdviceCreation adviceCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AdviceCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/advices")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(adviceCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Advice creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch advice.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceId">Required parameter: Advice Id.</param>
        /// <returns>Returns the Models.AdviceDetailsResponse response from the API call.</returns>
        public Models.AdviceDetailsResponse FetchAdvice(
                Guid id,
                Guid adviceId)
            => CoreHelper.RunTask(FetchAdviceAsync(id, adviceId));

        /// <summary>
        /// Fetch advice.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceId">Required parameter: Advice Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AdviceDetailsResponse response from the API call.</returns>
        public async Task<Models.AdviceDetailsResponse> FetchAdviceAsync(
                Guid id,
                Guid adviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AdviceDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/advices/{adviceId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("adviceId", adviceId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create advice submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceId">Required parameter: Advice Id.</param>
        /// <param name="adviceSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AdviceSubmissionCreationResponse response from the API call.</returns>
        public Models.AdviceSubmissionCreationResponse CreateAdviceSubmission(
                Guid id,
                Guid adviceId,
                Models.AdviceSubmissionCreation adviceSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateAdviceSubmissionAsync(id, adviceId, adviceSubmissionCreationRequest));

        /// <summary>
        /// create advice submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceId">Required parameter: Advice Id.</param>
        /// <param name="adviceSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AdviceSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.AdviceSubmissionCreationResponse> CreateAdviceSubmissionAsync(
                Guid id,
                Guid adviceId,
                Models.AdviceSubmissionCreation adviceSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AdviceSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/advices/{adviceId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(adviceSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("adviceId", adviceId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Advice submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch advice submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceId">Required parameter: Advice Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.AdviceSubmissionDetailsResponse response from the API call.</returns>
        public Models.AdviceSubmissionDetailsResponse FetchAdviceSubmission(
                Guid id,
                Guid adviceId,
                Guid submissionId)
            => CoreHelper.RunTask(FetchAdviceSubmissionAsync(id, adviceId, submissionId));

        /// <summary>
        /// Fetch advice submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="adviceId">Required parameter: Advice Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AdviceSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.AdviceSubmissionDetailsResponse> FetchAdviceSubmissionAsync(
                Guid id,
                Guid adviceId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AdviceSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/advices/{adviceId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("adviceId", adviceId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create recall.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.RecallCreationResponse response from the API call.</returns>
        public Models.RecallCreationResponse CreateRecall(
                Guid id,
                Models.RecallCreation recallCreationRequest = null)
            => CoreHelper.RunTask(CreateRecallAsync(id, recallCreationRequest));

        /// <summary>
        /// Create recall.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallCreationResponse response from the API call.</returns>
        public async Task<Models.RecallCreationResponse> CreateRecallAsync(
                Guid id,
                Models.RecallCreation recallCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/recalls")
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
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <returns>Returns the Models.RecallDetailsResponse response from the API call.</returns>
        public Models.RecallDetailsResponse FetchRecall(
                Guid id,
                Guid recallId)
            => CoreHelper.RunTask(FetchRecallAsync(id, recallId));

        /// <summary>
        /// Fetch recall.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallDetailsResponse> FetchRecallAsync(
                Guid id,
                Guid recallId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.RecallAdmissionDetailsResponse response from the API call.</returns>
        public Models.RecallAdmissionDetailsResponse FetchRecallAdmission(
                Guid id,
                Guid recallId,
                Guid admissionId)
            => CoreHelper.RunTask(FetchRecallAdmissionAsync(id, recallId, admissionId));

        /// <summary>
        /// Fetch recall admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallAdmissionDetailsResponse> FetchRecallAdmissionAsync(
                Guid id,
                Guid recallId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create recall decision.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="recallDecisionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.RecallDecisionCreationResponse response from the API call.</returns>
        public Models.RecallDecisionCreationResponse CreateRecallDecision(
                Guid id,
                Guid recallId,
                Models.RecallDecisionCreation recallDecisionCreationRequest = null)
            => CoreHelper.RunTask(CreateRecallDecisionAsync(id, recallId, recallDecisionCreationRequest));

        /// <summary>
        /// Create recall decision.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="recallDecisionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallDecisionCreationResponse response from the API call.</returns>
        public async Task<Models.RecallDecisionCreationResponse> CreateRecallDecisionAsync(
                Guid id,
                Guid recallId,
                Models.RecallDecisionCreation recallDecisionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallDecisionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/recalls/{recallId}/decisions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(recallDecisionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Recall decision creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall decision.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <returns>Returns the Models.RecallDecisionDetailsResponse response from the API call.</returns>
        public Models.RecallDecisionDetailsResponse FetchRecallDecision(
                Guid id,
                Guid recallId,
                Guid decisionId)
            => CoreHelper.RunTask(FetchRecallDecisionAsync(id, recallId, decisionId));

        /// <summary>
        /// Fetch recall decision.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallDecisionDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallDecisionDetailsResponse> FetchRecallDecisionAsync(
                Guid id,
                Guid recallId,
                Guid decisionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallDecisionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/decisions/{decisionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("decisionId", decisionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall decision admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.RecallDecisionAdmissionDetailsResponse response from the API call.</returns>
        public Models.RecallDecisionAdmissionDetailsResponse FetchRecallDecisionAdmission(
                Guid id,
                Guid recallId,
                Guid decisionId,
                Guid admissionId)
            => CoreHelper.RunTask(FetchRecallDecisionAdmissionAsync(id, recallId, decisionId, admissionId));

        /// <summary>
        /// Fetch recall decision admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallDecisionAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallDecisionAdmissionDetailsResponse> FetchRecallDecisionAdmissionAsync(
                Guid id,
                Guid recallId,
                Guid decisionId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallDecisionAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/decisions/{decisionId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create recall decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="recallDecisionSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.RecallDecisionSubmissionCreationResponse response from the API call.</returns>
        public Models.RecallDecisionSubmissionCreationResponse CreateRecallDecisionSubmission(
                Guid id,
                Guid recallId,
                Guid decisionId,
                Models.RecallDecisionSubmissionCreation recallDecisionSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateRecallDecisionSubmissionAsync(id, recallId, decisionId, recallDecisionSubmissionCreationRequest));

        /// <summary>
        /// create recall decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="recallDecisionSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallDecisionSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.RecallDecisionSubmissionCreationResponse> CreateRecallDecisionSubmissionAsync(
                Guid id,
                Guid recallId,
                Guid decisionId,
                Models.RecallDecisionSubmissionCreation recallDecisionSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallDecisionSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/recalls/{recallId}/decisions/{decisionId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(recallDecisionSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Recall decision submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.RecallDecisionSubmissionDetailsResponse response from the API call.</returns>
        public Models.RecallDecisionSubmissionDetailsResponse FetchRecallDecisionSubmission(
                Guid id,
                Guid recallId,
                Guid decisionId,
                Guid submissionId)
            => CoreHelper.RunTask(FetchRecallDecisionSubmissionAsync(id, recallId, decisionId, submissionId));

        /// <summary>
        /// Fetch recall decision submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="decisionId">Required parameter: Decision Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallDecisionSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallDecisionSubmissionDetailsResponse> FetchRecallDecisionSubmissionAsync(
                Guid id,
                Guid recallId,
                Guid decisionId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallDecisionSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/decisions/{decisionId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("decisionId", decisionId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <returns>Returns the Models.RecallReversalDetailsResponse response from the API call.</returns>
        public Models.RecallReversalDetailsResponse FetchRecallReversal(
                Guid id,
                Guid recallId,
                Guid reversalId)
            => CoreHelper.RunTask(FetchRecallReversalAsync(id, recallId, reversalId));

        /// <summary>
        /// Fetch recall reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallReversalDetailsResponse> FetchRecallReversalAsync(
                Guid id,
                Guid recallId,
                Guid reversalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/reversals/{reversalId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("reversalId", reversalId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.RecallReversalAdmissionDetailsResponse response from the API call.</returns>
        public Models.RecallReversalAdmissionDetailsResponse FetchRecallReversalAdmission(
                Guid id,
                Guid recallId,
                Guid reversalId,
                Guid admissionId)
            => CoreHelper.RunTask(FetchRecallReversalAdmissionAsync(id, recallId, reversalId, admissionId));

        /// <summary>
        /// Fetch recall reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallReversalAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallReversalAdmissionDetailsResponse> FetchRecallReversalAdmissionAsync(
                Guid id,
                Guid recallId,
                Guid reversalId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallReversalAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/reversals/{reversalId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create recall submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="recallSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.RecallSubmissionCreationResponse response from the API call.</returns>
        public Models.RecallSubmissionCreationResponse CreateRecallSubmission(
                Guid id,
                Guid recallId,
                Models.RecallSubmissionCreation recallSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateRecallSubmissionAsync(id, recallId, recallSubmissionCreationRequest));

        /// <summary>
        /// create recall submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="recallSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.RecallSubmissionCreationResponse> CreateRecallSubmissionAsync(
                Guid id,
                Guid recallId,
                Models.RecallSubmissionCreation recallSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/recalls/{recallId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(recallSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Recall submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch recall submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.RecallSubmissionDetailsResponse response from the API call.</returns>
        public Models.RecallSubmissionDetailsResponse FetchRecallSubmission(
                Guid id,
                Guid recallId,
                Guid submissionId)
            => CoreHelper.RunTask(FetchRecallSubmissionAsync(id, recallId, submissionId));

        /// <summary>
        /// Fetch recall submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="recallId">Required parameter: Recall Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecallSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.RecallSubmissionDetailsResponse> FetchRecallSubmissionAsync(
                Guid id,
                Guid recallId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecallSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/recalls/{recallId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("recallId", recallId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create return.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReturnCreationResponse response from the API call.</returns>
        public Models.ReturnCreationResponse CreateReturn(
                Guid id,
                Models.ReturnCreation returnCreationRequest = null)
            => CoreHelper.RunTask(CreateReturnAsync(id, returnCreationRequest));

        /// <summary>
        /// Create return.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnCreationResponse response from the API call.</returns>
        public async Task<Models.ReturnCreationResponse> CreateReturnAsync(
                Guid id,
                Models.ReturnCreation returnCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/returns")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(returnCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Return creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <returns>Returns the Models.ReturnDetailsResponse response from the API call.</returns>
        public Models.ReturnDetailsResponse FetchReturn(
                Guid id,
                Guid returnId)
            => CoreHelper.RunTask(FetchReturnAsync(id, returnId));

        /// <summary>
        /// Fetch return.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnDetailsResponse response from the API call.</returns>
        public async Task<Models.ReturnDetailsResponse> FetchReturnAsync(
                Guid id,
                Guid returnId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/returns/{returnId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.ReturnAdmissionFetchResponse response from the API call.</returns>
        public Models.ReturnAdmissionFetchResponse FetchReturnAdmission(
                Guid id,
                Guid returnId,
                Guid admissionId)
            => CoreHelper.RunTask(FetchReturnAdmissionAsync(id, returnId, admissionId));

        /// <summary>
        /// Fetch return admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnAdmissionFetchResponse response from the API call.</returns>
        public async Task<Models.ReturnAdmissionFetchResponse> FetchReturnAdmissionAsync(
                Guid id,
                Guid returnId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnAdmissionFetchResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/returns/{returnId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create return reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnReversalCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReturnReversalCreationResponse response from the API call.</returns>
        public Models.ReturnReversalCreationResponse CreateReturnReversal(
                Guid id,
                Guid returnId,
                Models.ReturnReversalCreation returnReversalCreationRequest = null)
            => CoreHelper.RunTask(CreateReturnReversalAsync(id, returnId, returnReversalCreationRequest));

        /// <summary>
        /// Create return reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnReversalCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnReversalCreationResponse response from the API call.</returns>
        public async Task<Models.ReturnReversalCreationResponse> CreateReturnReversalAsync(
                Guid id,
                Guid returnId,
                Models.ReturnReversalCreation returnReversalCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnReversalCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/returns/{returnId}/reversals")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(returnReversalCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reversal creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <returns>Returns the Models.ReturnReversalDetailsResponse response from the API call.</returns>
        public Models.ReturnReversalDetailsResponse FetchReturnReversal(
                Guid id,
                Guid returnId,
                Guid reversalId)
            => CoreHelper.RunTask(FetchReturnReversalAsync(id, returnId, reversalId));

        /// <summary>
        /// Fetch return reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.ReturnReversalDetailsResponse> FetchReturnReversalAsync(
                Guid id,
                Guid returnId,
                Guid reversalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/returns/{returnId}/reversals/{reversalId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("reversalId", reversalId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch return reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.ReturnReversalAdmissionDetailsResponse response from the API call.</returns>
        public Models.ReturnReversalAdmissionDetailsResponse FetchReturnReversalAdmission(
                Guid id,
                Guid returnId,
                Guid reversalId,
                Guid admissionId)
            => CoreHelper.RunTask(FetchReturnReversalAdmissionAsync(id, returnId, reversalId, admissionId));

        /// <summary>
        /// Fetch return reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnReversalAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ReturnReversalAdmissionDetailsResponse> FetchReturnReversalAdmissionAsync(
                Guid id,
                Guid returnId,
                Guid reversalId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnReversalAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/returns/{returnId}/reversals/{reversalId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create return submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReturnSubmissionCreationResponse response from the API call.</returns>
        public Models.ReturnSubmissionCreationResponse CreateReturnSubmission(
                Guid id,
                Guid returnId,
                Models.ReturnSubmissionCreation returnSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateReturnSubmissionAsync(id, returnId, returnSubmissionCreationRequest));

        /// <summary>
        /// create return submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="returnSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.ReturnSubmissionCreationResponse> CreateReturnSubmissionAsync(
                Guid id,
                Guid returnId,
                Models.ReturnSubmissionCreation returnSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/returns/{returnId}/submissions")
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
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.ReturnSubmissionDetailsResponse response from the API call.</returns>
        public Models.ReturnSubmissionDetailsResponse FetchReturnSubmission(
                Guid id,
                Guid returnId,
                Guid submissionId)
            => CoreHelper.RunTask(FetchReturnSubmissionAsync(id, returnId, submissionId));

        /// <summary>
        /// Fetch return submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="returnId">Required parameter: Return Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ReturnSubmissionDetailsResponse> FetchReturnSubmissionAsync(
                Guid id,
                Guid returnId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/returns/{returnId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReversalCreationResponse response from the API call.</returns>
        public Models.ReversalCreationResponse CreateReversal(
                Guid id,
                Models.ReversalCreation reversalCreationRequest = null)
            => CoreHelper.RunTask(CreateReversalAsync(id, reversalCreationRequest));

        /// <summary>
        /// Create reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReversalCreationResponse response from the API call.</returns>
        public async Task<Models.ReversalCreationResponse> CreateReversalAsync(
                Guid id,
                Models.ReversalCreation reversalCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReversalCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/reversals")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(reversalCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reversal creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <returns>Returns the Models.ReversalDetailsResponse response from the API call.</returns>
        public Models.ReversalDetailsResponse FetchReversal(
                Guid id,
                Guid reversalId)
            => CoreHelper.RunTask(FetchReversalAsync(id, reversalId));

        /// <summary>
        /// Fetch reversal.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReversalDetailsResponse response from the API call.</returns>
        public async Task<Models.ReversalDetailsResponse> FetchReversalAsync(
                Guid id,
                Guid reversalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReversalDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/reversals/{reversalId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <returns>Returns the Models.ReversalAdmissionDetailsResponse response from the API call.</returns>
        public Models.ReversalAdmissionDetailsResponse FetchReversalAdmission(
                Guid id,
                Guid reversalId,
                Guid admissionId)
            => CoreHelper.RunTask(FetchReversalAdmissionAsync(id, reversalId, admissionId));

        /// <summary>
        /// Fetch reversal admission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="admissionId">Required parameter: Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReversalAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ReversalAdmissionDetailsResponse> FetchReversalAdmissionAsync(
                Guid id,
                Guid reversalId,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReversalAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/reversals/{reversalId}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="reversalSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReversalSubmissionCreationResponse response from the API call.</returns>
        public Models.ReversalSubmissionCreationResponse CreateReversalSubmission(
                Guid id,
                Guid reversalId,
                Models.ReversalSubmissionCreation reversalSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateReversalSubmissionAsync(id, reversalId, reversalSubmissionCreationRequest));

        /// <summary>
        /// Create reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="reversalSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReversalSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.ReversalSubmissionCreationResponse> CreateReversalSubmissionAsync(
                Guid id,
                Guid reversalId,
                Models.ReversalSubmissionCreation reversalSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReversalSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/reversals/{reversalId}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(reversalSubmissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnc.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reversal submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.ReversalSubmissionDetailsResponse response from the API call.</returns>
        public Models.ReversalSubmissionDetailsResponse FetchReversalSubmission(
                Guid id,
                Guid reversalId,
                Guid submissionId)
            => CoreHelper.RunTask(FetchReversalSubmissionAsync(id, reversalId, submissionId));

        /// <summary>
        /// Fetch reversal submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="reversalId">Required parameter: Reversal Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReversalSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ReversalSubmissionDetailsResponse> FetchReversalSubmissionAsync(
                Guid id,
                Guid reversalId,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReversalSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/reversals/{reversalId}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("reversalId", reversalId))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// create submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="submissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentSubmissionCreationResponse response from the API call.</returns>
        public Models.PaymentSubmissionCreationResponse CreateSubmission(
                Guid id,
                Models.PaymentSubmissionCreation submissionCreationRequest = null)
            => CoreHelper.RunTask(CreateSubmissionAsync(id, submissionCreationRequest));

        /// <summary>
        /// create submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="submissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentSubmissionCreationResponse response from the API call.</returns>
        public async Task<Models.PaymentSubmissionCreationResponse> CreateSubmissionAsync(
                Guid id,
                Models.PaymentSubmissionCreation submissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentSubmissionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/payments/{id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(submissionCreationRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Submission creation error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <returns>Returns the Models.PaymentSubmissionDetailsResponse response from the API call.</returns>
        public Models.PaymentSubmissionDetailsResponse FetchSubmission(
                Guid id,
                Guid submissionId)
            => CoreHelper.RunTask(FetchSubmissionAsync(id, submissionId));

        /// <summary>
        /// Fetch submission.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentSubmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.PaymentSubmissionDetailsResponse> FetchSubmissionAsync(
                Guid id,
                Guid submissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentSubmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/payments/{id}/submissions/{submissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("submissionId", submissionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Patch Payment Submission Task.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="taskId">Required parameter: Payment Submission Task Id.</param>
        /// <param name="paymentSubmissionTaskPatchRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentSubmissionTaskDetailsResponse response from the API call.</returns>
        public Models.PaymentSubmissionTaskDetailsResponse PatchPaymentSubmissionTask(
                Guid id,
                Guid submissionId,
                Guid taskId,
                Models.PaymentSubmissionTaskAmendment paymentSubmissionTaskPatchRequest = null)
            => CoreHelper.RunTask(PatchPaymentSubmissionTaskAsync(id, submissionId, taskId, paymentSubmissionTaskPatchRequest));

        /// <summary>
        /// Patch Payment Submission Task.
        /// </summary>
        /// <param name="id">Required parameter: Payment Id.</param>
        /// <param name="submissionId">Required parameter: Submission Id.</param>
        /// <param name="taskId">Required parameter: Payment Submission Task Id.</param>
        /// <param name="paymentSubmissionTaskPatchRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentSubmissionTaskDetailsResponse response from the API call.</returns>
        public async Task<Models.PaymentSubmissionTaskDetailsResponse> PatchPaymentSubmissionTaskAsync(
                Guid id,
                Guid submissionId,
                Guid taskId,
                Models.PaymentSubmissionTaskAmendment paymentSubmissionTaskPatchRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentSubmissionTaskDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/transaction/payments/{id}/submissions/{submissionId}/tasks/{taskId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(paymentSubmissionTaskPatchRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("submissionId", submissionId))
                      .Template(_template => _template.Setup("taskId", taskId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Patch Return Submission Task.
        /// </summary>
        /// <param name="paymentId">Required parameter: Payment ID.</param>
        /// <param name="returnId">Required parameter: Return ID.</param>
        /// <param name="returnSubmissionId">Required parameter: Return Submission ID.</param>
        /// <param name="taskId">Required parameter: Return Submission Task Id.</param>
        /// <param name="returnSubmissionTaskPatchRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReturnSubmissionTaskDetailsResponse response from the API call.</returns>
        public Models.ReturnSubmissionTaskDetailsResponse PatchReturnSubmissionTask(
                Guid paymentId,
                Guid returnId,
                Guid returnSubmissionId,
                Guid taskId,
                Models.ReturnSubmissionTaskAmendment returnSubmissionTaskPatchRequest = null)
            => CoreHelper.RunTask(PatchReturnSubmissionTaskAsync(paymentId, returnId, returnSubmissionId, taskId, returnSubmissionTaskPatchRequest));

        /// <summary>
        /// Patch Return Submission Task.
        /// </summary>
        /// <param name="paymentId">Required parameter: Payment ID.</param>
        /// <param name="returnId">Required parameter: Return ID.</param>
        /// <param name="returnSubmissionId">Required parameter: Return Submission ID.</param>
        /// <param name="taskId">Required parameter: Return Submission Task Id.</param>
        /// <param name="returnSubmissionTaskPatchRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReturnSubmissionTaskDetailsResponse response from the API call.</returns>
        public async Task<Models.ReturnSubmissionTaskDetailsResponse> PatchReturnSubmissionTaskAsync(
                Guid paymentId,
                Guid returnId,
                Guid returnSubmissionId,
                Guid taskId,
                Models.ReturnSubmissionTaskAmendment returnSubmissionTaskPatchRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReturnSubmissionTaskDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/transaction/payments/{paymentId}/returns/{returnId}/submissions/{returnSubmissionId}/tasks/{taskId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(returnSubmissionTaskPatchRequest))
                      .Template(_template => _template.Setup("paymentId", paymentId))
                      .Template(_template => _template.Setup("returnId", returnId))
                      .Template(_template => _template.Setup("returnSubmissionId", returnSubmissionId))
                      .Template(_template => _template.Setup("taskId", taskId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}