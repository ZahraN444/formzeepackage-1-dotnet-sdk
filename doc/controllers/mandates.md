# Mandates

```csharp
MandatesController mandatesController = client.MandatesController;
```

## Class Name

`MandatesController`

## Methods

* [Get Mandates](../../doc/controllers/mandates.md#get-mandates)
* [Post Mandates](../../doc/controllers/mandates.md#post-mandates)
* [Get Mandates ID](../../doc/controllers/mandates.md#get-mandates-id)
* [Patch Mandates ID](../../doc/controllers/mandates.md#patch-mandates-id)
* [Get Mandates ID Admissions Admission ID](../../doc/controllers/mandates.md#get-mandates-id-admissions-admission-id)
* [Post Mandates ID Returns](../../doc/controllers/mandates.md#post-mandates-id-returns)
* [Get Mandates ID Returns Return ID](../../doc/controllers/mandates.md#get-mandates-id-returns-return-id)
* [Post Mandates ID Returns Return ID Submissions](../../doc/controllers/mandates.md#post-mandates-id-returns-return-id-submissions)
* [Get Mandates ID Returns Return ID Submissions Submission ID](../../doc/controllers/mandates.md#get-mandates-id-returns-return-id-submissions-submission-id)
* [Post Mandates ID Submissions](../../doc/controllers/mandates.md#post-mandates-id-submissions)
* [Get Mandates ID Submissions Submission ID](../../doc/controllers/mandates.md#get-mandates-id-submissions-submission-id)


# Get Mandates

List mandates

```csharp
GetMandatesAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterDebtorPartyAccountNumber` | `string` | Query, Optional | - |
| `filterDebtorPartyBankId` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyAccountNumber` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyBankId` | `string` | Query, Optional | - |
| `filterCurrency` | `string` | Query, Optional | - |
| `filterPaymentScheme` | `string` | Query, Optional | - |
| `filterSchemePaymentType` | `string` | Query, Optional | - |
| `filterProcessingDateFrom` | `DateTime?` | Query, Optional | - |
| `filterProcessingDateTo` | `DateTime?` | Query, Optional | - |
| `filterSchemeProcessingDateFrom` | `DateTime?` | Query, Optional | - |
| `filterSchemeProcessingDateTo` | `DateTime?` | Query, Optional | - |
| `filterClearingId` | `string` | Query, Optional | - |
| `filterAdmissionAdmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterAdmissionAdmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterAdmissionStatus` | `string` | Query, Optional | Filter by admission status |
| `filterAdmissionSchemeStatusCode` | `string` | Query, Optional | Filter by admission scheme status code |
| `filterAmount` | `string` | Query, Optional | Filter by amount |
| `filterReference` | `string` | Query, Optional | Filter by reference |
| `filterUniqueSchemeId` | `string` | Query, Optional | Filter by unique scheme id |
| `filterAllVersions` | `bool?` | Query, Optional | Include old versions of mandates |
| `filterSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterStatus` | `string` | Query, Optional | Filter by mandate status |
| `filterStatusReason` | `string` | Query, Optional | Filter by mandate status reason |

## Response Type

[`Task<Models.MandateDetailsListResponse>`](../../doc/models/mandate-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    MandateDetailsListResponse result = await mandatesController.GetMandatesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Mandates

Create Mandate

```csharp
PostMandatesAsync(
    Models.MandateCreation mandateCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mandateCreationRequest` | [`MandateCreation`](../../doc/models/mandate-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.MandateCreationResponse>`](../../doc/models/mandate-creation-response.md)

## Example Usage

```csharp
try
{
    MandateCreationResponse result = await mandatesController.PostMandatesAsync();
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
| 400 | Mandate creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Mandate creation conflict Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Mandates ID

Fetch mandate

```csharp
GetMandatesIDAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |

## Response Type

[`Task<Models.MandateDetailsResponse>`](../../doc/models/mandate-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    MandateDetailsResponse result = await mandatesController.GetMandatesIDAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Patch Mandates ID

Update mandate

```csharp
PatchMandatesIDAsync(
    Guid id,
    Models.MandateAmendment mandateAmendment = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `mandateAmendment` | [`MandateAmendment`](../../doc/models/mandate-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.MandateDetailsResponse>`](../../doc/models/mandate-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    MandateDetailsResponse result = await mandatesController.PatchMandatesIDAsync(id);
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
| 400 | Mandate update error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Mandates ID Admissions Admission ID

Fetch Mandate Admission

```csharp
GetMandatesIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `admissionId` | `Guid` | Template, Required | Mandate Admission Id |

## Response Type

[`Task<Models.MandateAdmissionDetailsResponse>`](../../doc/models/mandate-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    MandateAdmissionDetailsResponse result = await mandatesController.GetMandatesIDAdmissionsAdmissionIDAsync(
        id,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Mandates ID Returns

Create mandate return

```csharp
PostMandatesIDReturnsAsync(
    Guid id,
    Models.MandateReturnCreation returnCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `returnCreationRequest` | [`MandateReturnCreation`](../../doc/models/mandate-return-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.MandateReturnCreationResponse>`](../../doc/models/mandate-return-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    MandateReturnCreationResponse result = await mandatesController.PostMandatesIDReturnsAsync(id);
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
| 400 | Return creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Mandates ID Returns Return ID

Fetch mandate return

```csharp
GetMandatesIDReturnsReturnIDAsync(
    Guid id,
    Guid returnId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `returnId` | `Guid` | Template, Required | Return Id |

## Response Type

[`Task<Models.MandateReturnDetailsResponse>`](../../doc/models/mandate-return-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    MandateReturnDetailsResponse result = await mandatesController.GetMandatesIDReturnsReturnIDAsync(
        id,
        returnId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Mandates ID Returns Return ID Submissions

Create mandate return submission

```csharp
PostMandatesIDReturnsReturnIDSubmissionsAsync(
    Guid id,
    Guid returnId,
    Models.MandateReturnSubmissionCreation returnSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `returnSubmissionCreationRequest` | [`MandateReturnSubmissionCreation`](../../doc/models/mandate-return-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.MandateReturnSubmissionCreationResponse>`](../../doc/models/mandate-return-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    MandateReturnSubmissionCreationResponse result = await mandatesController.PostMandatesIDReturnsReturnIDSubmissionsAsync(
        id,
        returnId
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
| 400 | Return submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Mandates ID Returns Return ID Submissions Submission ID

Fetch return submission

```csharp
GetMandatesIDReturnsReturnIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid returnId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.MandateReturnSubmissionDetailsResponse>`](../../doc/models/mandate-return-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    MandateReturnSubmissionDetailsResponse result = await mandatesController.GetMandatesIDReturnsReturnIDSubmissionsSubmissionIDAsync(
        id,
        returnId,
        submissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Mandates ID Submissions

Create Mandate Submission

```csharp
PostMandatesIDSubmissionsAsync(
    Guid id,
    Models.MandateSubmissionCreation mandateSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `mandateSubmissionCreationRequest` | [`MandateSubmissionCreation`](../../doc/models/mandate-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.MandateSubmissionDetailsResponse>`](../../doc/models/mandate-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    MandateSubmissionDetailsResponse result = await mandatesController.PostMandatesIDSubmissionsAsync(id);
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
| 400 | Mandate Submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Mandates ID Submissions Submission ID

Fetch Mandate Submission

```csharp
GetMandatesIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Mandate Id |
| `submissionId` | `Guid` | Template, Required | Mandate Submission Id |

## Response Type

[`Task<Models.MandateSubmissionDetailsResponse>`](../../doc/models/mandate-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    MandateSubmissionDetailsResponse result = await mandatesController.GetMandatesIDSubmissionsSubmissionIDAsync(
        id,
        submissionId
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
| 400 | Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

