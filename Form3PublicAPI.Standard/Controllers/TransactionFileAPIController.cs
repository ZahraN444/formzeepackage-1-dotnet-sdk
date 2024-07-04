// <copyright file="TransactionFileAPIController.cs" company="APIMatic">
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
    /// TransactionFileAPIController.
    /// </summary>
    public class TransactionFileAPIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileAPIController"/> class.
        /// </summary>
        internal TransactionFileAPIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List transaction files.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Find all File resources with a given organisation ID.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Find File resources by a certain scheme.</param>
        /// <param name="filterFileFormat">Optional parameter: Find File resources by the format of the file.</param>
        /// <param name="filterCreatedOnFrom">Optional parameter: Find all File resources created from this date, in format YYYY-MM-DD.</param>
        /// <param name="filterCreatedOnTo">Optional parameter: Find all File resources created up to this date, in format YYYY-MM-DD.</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Find all File resources with a certain submission status.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Find all File resources submitted from and including this date/time.</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Find all File resources submitted up to and included this date/time.</param>
        /// <param name="filterSubmissionSchemeReferencesFileIdentifier">Optional parameter: Find File resources the id of the submission to to the scheme.</param>
        /// <param name="filterSubmissionSchemeReferencesFileNumber">Optional parameter: Find File resources by the id of the file sent to the scheme.</param>
        /// <param name="filterSubmissionSchemeReferencesClearingId">Optional parameter: Find File resources by the Service User Number (SUN) of the payment originator.</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Find all File resources with a certain admission status.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Find all File resources admitted from and including this date/time.</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Find all File resources admitted up to and included this date/time.</param>
        /// <returns>Returns the Models.ListTransactionFilesResponse response from the API call.</returns>
        public Models.ListTransactionFilesResponse ListTransactionFiles(
                string pageNumber = null,
                int? pageSize = 100,
                List<Guid> filterOrganisationId = null,
                string filterPaymentScheme = null,
                string filterFileFormat = null,
                DateTime? filterCreatedOnFrom = null,
                DateTime? filterCreatedOnTo = null,
                string filterSubmissionStatus = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterSubmissionSchemeReferencesFileIdentifier = null,
                string filterSubmissionSchemeReferencesFileNumber = null,
                string filterSubmissionSchemeReferencesClearingId = null,
                string filterAdmissionStatus = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null)
            => CoreHelper.RunTask(ListTransactionFilesAsync(pageNumber, pageSize, filterOrganisationId, filterPaymentScheme, filterFileFormat, filterCreatedOnFrom, filterCreatedOnTo, filterSubmissionStatus, filterSubmissionSubmissionDateFrom, filterSubmissionSubmissionDateTo, filterSubmissionSchemeReferencesFileIdentifier, filterSubmissionSchemeReferencesFileNumber, filterSubmissionSchemeReferencesClearingId, filterAdmissionStatus, filterAdmissionAdmissionDateFrom, filterAdmissionAdmissionDateTo));

        /// <summary>
        /// List transaction files.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Find all File resources with a given organisation ID.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Find File resources by a certain scheme.</param>
        /// <param name="filterFileFormat">Optional parameter: Find File resources by the format of the file.</param>
        /// <param name="filterCreatedOnFrom">Optional parameter: Find all File resources created from this date, in format YYYY-MM-DD.</param>
        /// <param name="filterCreatedOnTo">Optional parameter: Find all File resources created up to this date, in format YYYY-MM-DD.</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Find all File resources with a certain submission status.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Find all File resources submitted from and including this date/time.</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Find all File resources submitted up to and included this date/time.</param>
        /// <param name="filterSubmissionSchemeReferencesFileIdentifier">Optional parameter: Find File resources the id of the submission to to the scheme.</param>
        /// <param name="filterSubmissionSchemeReferencesFileNumber">Optional parameter: Find File resources by the id of the file sent to the scheme.</param>
        /// <param name="filterSubmissionSchemeReferencesClearingId">Optional parameter: Find File resources by the Service User Number (SUN) of the payment originator.</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Find all File resources with a certain admission status.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Find all File resources admitted from and including this date/time.</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Find all File resources admitted up to and included this date/time.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransactionFilesResponse response from the API call.</returns>
        public async Task<Models.ListTransactionFilesResponse> ListTransactionFilesAsync(
                string pageNumber = null,
                int? pageSize = 100,
                List<Guid> filterOrganisationId = null,
                string filterPaymentScheme = null,
                string filterFileFormat = null,
                DateTime? filterCreatedOnFrom = null,
                DateTime? filterCreatedOnTo = null,
                string filterSubmissionStatus = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterSubmissionSchemeReferencesFileIdentifier = null,
                string filterSubmissionSchemeReferencesFileNumber = null,
                string filterSubmissionSchemeReferencesClearingId = null,
                string filterAdmissionStatus = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListTransactionFilesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/transactions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", (pageSize != null) ? pageSize : 100))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[file_format]", filterFileFormat))
                      .Query(_query => _query.Setup("filter[created_on_from]", filterCreatedOnFrom.HasValue ? filterCreatedOnFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[created_on_to]", filterCreatedOnTo.HasValue ? filterCreatedOnTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[submission.status]", filterSubmissionStatus))
                      .Query(_query => _query.Setup("filter[submission.submission_date_from]", filterSubmissionSubmissionDateFrom.HasValue ? filterSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.submission_date_to]", filterSubmissionSubmissionDateTo.HasValue ? filterSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.scheme_references.file_identifier]", filterSubmissionSchemeReferencesFileIdentifier))
                      .Query(_query => _query.Setup("filter[submission.scheme_references.file_number]", filterSubmissionSchemeReferencesFileNumber))
                      .Query(_query => _query.Setup("filter[submission.scheme_references.clearing_id]", filterSubmissionSchemeReferencesClearingId))
                      .Query(_query => _query.Setup("filter[admission.status]", filterAdmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.admission_date_from]", filterAdmissionAdmissionDateFrom.HasValue ? filterAdmissionAdmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.admission_date_to]", filterAdmissionAdmissionDateTo.HasValue ? filterAdmissionAdmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reports bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Transaction File.
        /// </summary>
        /// <param name="transactionFileCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.TransactionFileResponse response from the API call.</returns>
        public Models.TransactionFileResponse CreateTransactionFile(
                Models.TransactionFileCreation transactionFileCreationRequest = null)
            => CoreHelper.RunTask(CreateTransactionFileAsync(transactionFileCreationRequest));

        /// <summary>
        /// Creates a Transaction File.
        /// </summary>
        /// <param name="transactionFileCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileResponse response from the API call.</returns>
        public async Task<Models.TransactionFileResponse> CreateTransactionFileAsync(
                Models.TransactionFileCreation transactionFileCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/transactions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(transactionFileCreationRequest))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch transaction file.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="accept">Optional parameter: Acceptable Formats, possible values are "application/vnd.api+json", "application/x-ndjson" and "application/x.form3.standard18".</param>
        /// <returns>Returns the Models.TransactionFileResponse response from the API call.</returns>
        public Models.TransactionFileResponse GetTransactionFile(
                Guid transactionFileId,
                string accept = null)
            => CoreHelper.RunTask(GetTransactionFileAsync(transactionFileId, accept));

        /// <summary>
        /// Fetch transaction file.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="accept">Optional parameter: Acceptable Formats, possible values are "application/vnd.api+json", "application/x-ndjson" and "application/x.form3.standard18".</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileResponse response from the API call.</returns>
        public async Task<Models.TransactionFileResponse> GetTransactionFileAsync(
                Guid transactionFileId,
                string accept = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/transactions/{transaction_file_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transaction_file_id", transactionFileId))
                      .Header(_header => _header.Setup("Accept", accept))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Put Transaction file chunk.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="xForm3UploadPart">Required parameter: Which part of the file we are uploading.</param>
        /// <param name="payload">Required parameter: Example: .</param>
        /// <returns>Returns the Models.TransactionFileResponse response from the API call.</returns>
        public Models.TransactionFileResponse UploadTransactionFile(
                Guid transactionFileId,
                string xForm3UploadPart,
                FileStreamInfo payload)
            => CoreHelper.RunTask(UploadTransactionFileAsync(transactionFileId, xForm3UploadPart, payload));

        /// <summary>
        /// Put Transaction file chunk.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="xForm3UploadPart">Required parameter: Which part of the file we are uploading.</param>
        /// <param name="payload">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileResponse response from the API call.</returns>
        public async Task<Models.TransactionFileResponse> UploadTransactionFileAsync(
                Guid transactionFileId,
                string xForm3UploadPart,
                FileStreamInfo payload,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/files/transactions/{transaction_file_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transaction_file_id", transactionFileId))
                      .Header(_header => _header.Setup("X-Form3-Upload-Part", xForm3UploadPart))
                      .Form(_form => _form.Setup("payload", payload))
                      .Header(_header => _header.Setup("Content-Type", "application/octet-stream"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Transaction File Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Transaction File Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Transaction File Admission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileAdmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.TransactionFileAdmissionResponse response from the API call.</returns>
        public Models.TransactionFileAdmissionResponse CreateTransactionFileAdmission(
                Guid transactionFileId,
                Models.TransactionFileAdmissionCreation transactionFileAdmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateTransactionFileAdmissionAsync(transactionFileId, transactionFileAdmissionCreationRequest));

        /// <summary>
        /// Creates a Transaction File Admission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileAdmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileAdmissionResponse response from the API call.</returns>
        public async Task<Models.TransactionFileAdmissionResponse> CreateTransactionFileAdmissionAsync(
                Guid transactionFileId,
                Models.TransactionFileAdmissionCreation transactionFileAdmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileAdmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/transactions/{transaction_file_id}/admissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(transactionFileAdmissionCreationRequest))
                      .Template(_template => _template.Setup("transaction_file_id", transactionFileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Transaction File Admission Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch transaction file admission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileAdmissionId">Required parameter: Transaction File Admission Id.</param>
        /// <returns>Returns the Models.TransactionFileAdmissionResponse response from the API call.</returns>
        public Models.TransactionFileAdmissionResponse GetTransactionFileAdmission(
                Guid transactionFileId,
                Guid transactionFileAdmissionId)
            => CoreHelper.RunTask(GetTransactionFileAdmissionAsync(transactionFileId, transactionFileAdmissionId));

        /// <summary>
        /// Fetch transaction file admission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileAdmissionId">Required parameter: Transaction File Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileAdmissionResponse response from the API call.</returns>
        public async Task<Models.TransactionFileAdmissionResponse> GetTransactionFileAdmissionAsync(
                Guid transactionFileId,
                Guid transactionFileAdmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileAdmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/transactions/{transaction_file_id}/admissions/{transaction_file_admission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transaction_file_id", transactionFileId))
                      .Template(_template => _template.Setup("transaction_file_admission_id", transactionFileAdmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Transaction File Submission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.TransactionFileSubmissionResponse response from the API call.</returns>
        public Models.TransactionFileSubmissionResponse CreateTransactionFileSubmission(
                Guid transactionFileId,
                Models.TransactionFileSubmissionCreation transactionFileSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateTransactionFileSubmissionAsync(transactionFileId, transactionFileSubmissionCreationRequest));

        /// <summary>
        /// Creates a Transaction File Submission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileSubmissionResponse response from the API call.</returns>
        public async Task<Models.TransactionFileSubmissionResponse> CreateTransactionFileSubmissionAsync(
                Guid transactionFileId,
                Models.TransactionFileSubmissionCreation transactionFileSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileSubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/transactions/{transaction_file_id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(transactionFileSubmissionCreationRequest))
                      .Template(_template => _template.Setup("transaction_file_id", transactionFileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Transaction File Submission Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch transaction file submission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileSubmissionId">Required parameter: Transaction File Submission Id.</param>
        /// <returns>Returns the Models.TransactionFileSubmissionResponse response from the API call.</returns>
        public Models.TransactionFileSubmissionResponse GetTransactionFileSubmission(
                Guid transactionFileId,
                Guid transactionFileSubmissionId)
            => CoreHelper.RunTask(GetTransactionFileSubmissionAsync(transactionFileId, transactionFileSubmissionId));

        /// <summary>
        /// Fetch transaction file submission.
        /// </summary>
        /// <param name="transactionFileId">Required parameter: Transaction File Id.</param>
        /// <param name="transactionFileSubmissionId">Required parameter: Transaction File Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFileSubmissionResponse response from the API call.</returns>
        public async Task<Models.TransactionFileSubmissionResponse> GetTransactionFileSubmissionAsync(
                Guid transactionFileId,
                Guid transactionFileSubmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFileSubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/transactions/{transaction_file_id}/submissions/{transaction_file_submission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transaction_file_id", transactionFileId))
                      .Template(_template => _template.Setup("transaction_file_submission_id", transactionFileSubmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}