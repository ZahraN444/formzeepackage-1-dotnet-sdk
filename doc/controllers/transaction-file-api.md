# Transaction File API

```csharp
TransactionFileAPIController transactionFileAPIController = client.TransactionFileAPIController;
```

## Class Name

`TransactionFileAPIController`

## Methods

* [List Transaction Files](../../doc/controllers/transaction-file-api.md#list-transaction-files)
* [Create Transaction File](../../doc/controllers/transaction-file-api.md#create-transaction-file)
* [Get Transaction File](../../doc/controllers/transaction-file-api.md#get-transaction-file)
* [Upload Transaction File](../../doc/controllers/transaction-file-api.md#upload-transaction-file)
* [Create Transaction File Admission](../../doc/controllers/transaction-file-api.md#create-transaction-file-admission)
* [Get Transaction File Admission](../../doc/controllers/transaction-file-api.md#get-transaction-file-admission)
* [Create Transaction File Submission](../../doc/controllers/transaction-file-api.md#create-transaction-file-submission)
* [Get Transaction File Submission](../../doc/controllers/transaction-file-api.md#get-transaction-file-submission)


# List Transaction Files

List transaction files

```csharp
ListTransactionFilesAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Find all File resources with a given organisation ID |
| `filterPaymentScheme` | `string` | Query, Optional | Find File resources by a certain scheme |
| `filterFileFormat` | `string` | Query, Optional | Find File resources by the format of the file |
| `filterCreatedOnFrom` | `DateTime?` | Query, Optional | Find all File resources created from this date, in format YYYY-MM-DD |
| `filterCreatedOnTo` | `DateTime?` | Query, Optional | Find all File resources created up to this date, in format YYYY-MM-DD |
| `filterSubmissionStatus` | `string` | Query, Optional | Find all File resources with a certain submission status |
| `filterSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | Find all File resources submitted from and including this date/time |
| `filterSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | Find all File resources submitted up to and included this date/time |
| `filterSubmissionSchemeReferencesFileIdentifier` | `string` | Query, Optional | Find File resources the id of the submission to to the scheme |
| `filterSubmissionSchemeReferencesFileNumber` | `string` | Query, Optional | Find File resources by the id of the file sent to the scheme |
| `filterSubmissionSchemeReferencesClearingId` | `string` | Query, Optional | Find File resources by the Service User Number (SUN) of the payment originator |
| `filterAdmissionStatus` | `string` | Query, Optional | Find all File resources with a certain admission status |
| `filterAdmissionAdmissionDateFrom` | `DateTime?` | Query, Optional | Find all File resources admitted from and including this date/time |
| `filterAdmissionAdmissionDateTo` | `DateTime?` | Query, Optional | Find all File resources admitted up to and included this date/time |

## Response Type

[`Task<Models.ListTransactionFilesResponse>`](../../doc/models/list-transaction-files-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    ListTransactionFilesResponse result = await transactionFileAPIController.ListTransactionFilesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Reports bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Transaction File

Creates a Transaction File

```csharp
CreateTransactionFileAsync(
    Models.TransactionFileCreation transactionFileCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileCreationRequest` | [`TransactionFileCreation`](../../doc/models/transaction-file-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.TransactionFileResponse>`](../../doc/models/transaction-file-response.md)

## Example Usage

```csharp
TransactionFileCreation transactionFileCreationRequest = new TransactionFileCreation
{
    Data = new NewTransactionFile
    {
        Attributes = new Attributes52
        {
            FileFormat = FileFormatEnum.Ndjson,
            FileHash = "f60071837de834af950f070aa08fc1e0e3e4b1f7014a6251eabf207eba10c817",
            FileSize = 1024,
            HashingAlgorithm = "SHA256",
            NumberOfParts = 1,
            PaymentScheme = "BACS",
            TransactionCount = 1,
            TransactionSum = "1.00",
        },
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        CreatedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ModifiedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Version = 0,
    },
};

try
{
    TransactionFileResponse result = await transactionFileAPIController.CreateTransactionFileAsync(transactionFileCreationRequest);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Transaction File

Fetch transaction file

```csharp
GetTransactionFileAsync(
    Guid transactionFileId,
    string accept = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileId` | `Guid` | Template, Required | Transaction File Id |
| `accept` | `string` | Header, Optional | Acceptable Formats, possible values are "application/vnd.api+json", "application/x-ndjson" and "application/x.form3.standard18" |

## Response Type

[`Task<Models.TransactionFileResponse>`](../../doc/models/transaction-file-response.md)

## Example Usage

```csharp
Guid transactionFileId = new Guid("00001854-0000-0000-0000-000000000000");
try
{
    TransactionFileResponse result = await transactionFileAPIController.GetTransactionFileAsync(transactionFileId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Upload Transaction File

Put Transaction file chunk

```csharp
UploadTransactionFileAsync(
    Guid transactionFileId,
    string xForm3UploadPart,
    FileStreamInfo payload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileId` | `Guid` | Template, Required | Transaction File Id |
| `xForm3UploadPart` | `string` | Header, Required | Which part of the file we are uploading |
| `payload` | `FileStreamInfo` | Form, Required | - |

## Response Type

[`Task<Models.TransactionFileResponse>`](../../doc/models/transaction-file-response.md)

## Example Usage

```csharp
Guid transactionFileId = new Guid("00001854-0000-0000-0000-000000000000");
string xForm3UploadPart = "X-Form3-Upload-Part2";
FileStreamInfo payload = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    TransactionFileResponse result = await transactionFileAPIController.UploadTransactionFileAsync(
        transactionFileId,
        xForm3UploadPart,
        payload
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Transaction File Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Transaction File Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Transaction File Admission

Creates a Transaction File Admission

```csharp
CreateTransactionFileAdmissionAsync(
    Guid transactionFileId,
    Models.TransactionFileAdmissionCreation transactionFileAdmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileId` | `Guid` | Template, Required | Transaction File Id |
| `transactionFileAdmissionCreationRequest` | [`TransactionFileAdmissionCreation`](../../doc/models/transaction-file-admission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.TransactionFileAdmissionResponse>`](../../doc/models/transaction-file-admission-response.md)

## Example Usage

```csharp
Guid transactionFileId = new Guid("00001854-0000-0000-0000-000000000000");
TransactionFileAdmissionCreation transactionFileAdmissionCreationRequest = new TransactionFileAdmissionCreation
{
    Data = new TransactionFileAdmission
    {
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        CreatedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ModifiedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Version = 0,
    },
};

try
{
    TransactionFileAdmissionResponse result = await transactionFileAPIController.CreateTransactionFileAdmissionAsync(
        transactionFileId,
        transactionFileAdmissionCreationRequest
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Transaction File Admission Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Transaction File Admission

Fetch transaction file admission

```csharp
GetTransactionFileAdmissionAsync(
    Guid transactionFileId,
    Guid transactionFileAdmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileId` | `Guid` | Template, Required | Transaction File Id |
| `transactionFileAdmissionId` | `Guid` | Template, Required | Transaction File Admission Id |

## Response Type

[`Task<Models.TransactionFileAdmissionResponse>`](../../doc/models/transaction-file-admission-response.md)

## Example Usage

```csharp
Guid transactionFileId = new Guid("00001854-0000-0000-0000-000000000000");
Guid transactionFileAdmissionId = new Guid("00001a86-0000-0000-0000-000000000000");
try
{
    TransactionFileAdmissionResponse result = await transactionFileAPIController.GetTransactionFileAdmissionAsync(
        transactionFileId,
        transactionFileAdmissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Transaction File Submission

Creates a Transaction File Submission

```csharp
CreateTransactionFileSubmissionAsync(
    Guid transactionFileId,
    Models.TransactionFileSubmissionCreation transactionFileSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileId` | `Guid` | Template, Required | Transaction File Id |
| `transactionFileSubmissionCreationRequest` | [`TransactionFileSubmissionCreation`](../../doc/models/transaction-file-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.TransactionFileSubmissionResponse>`](../../doc/models/transaction-file-submission-response.md)

## Example Usage

```csharp
Guid transactionFileId = new Guid("00001854-0000-0000-0000-000000000000");
TransactionFileSubmissionCreation transactionFileSubmissionCreationRequest = new TransactionFileSubmissionCreation
{
    Data = new TransactionFileSubmission
    {
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        CreatedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ModifiedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Version = 0,
    },
};

try
{
    TransactionFileSubmissionResponse result = await transactionFileAPIController.CreateTransactionFileSubmissionAsync(
        transactionFileId,
        transactionFileSubmissionCreationRequest
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Transaction File Submission Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Transaction File Submission

Fetch transaction file submission

```csharp
GetTransactionFileSubmissionAsync(
    Guid transactionFileId,
    Guid transactionFileSubmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionFileId` | `Guid` | Template, Required | Transaction File Id |
| `transactionFileSubmissionId` | `Guid` | Template, Required | Transaction File Submission Id |

## Response Type

[`Task<Models.TransactionFileSubmissionResponse>`](../../doc/models/transaction-file-submission-response.md)

## Example Usage

```csharp
Guid transactionFileId = new Guid("00001854-0000-0000-0000-000000000000");
Guid transactionFileSubmissionId = new Guid("00000bd8-0000-0000-0000-000000000000");
try
{
    TransactionFileSubmissionResponse result = await transactionFileAPIController.GetTransactionFileSubmissionAsync(
        transactionFileId,
        transactionFileSubmissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

