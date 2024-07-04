# Direct Debits

```csharp
DirectDebitsController directDebitsController = client.DirectDebitsController;
```

## Class Name

`DirectDebitsController`

## Methods

* [Get Directdebits](../../doc/controllers/direct-debits.md#get-directdebits)
* [Post Directdebits](../../doc/controllers/direct-debits.md#post-directdebits)
* [Get Directdebits ID](../../doc/controllers/direct-debits.md#get-directdebits-id)
* [Get Directdebits ID Admissions Admission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-admissions-admission-id)
* [Post Directdebits ID Decisions](../../doc/controllers/direct-debits.md#post-directdebits-id-decisions)
* [Get Directdebits ID Decisions Decision ID](../../doc/controllers/direct-debits.md#get-directdebits-id-decisions-decision-id)
* [Post Directdebits ID Decisions Decision ID Admissions](../../doc/controllers/direct-debits.md#post-directdebits-id-decisions-decision-id-admissions)
* [Get Directdebits ID Decisions Decision ID Admissions Admission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-decisions-decision-id-admissions-admission-id)
* [Post Directdebits ID Decisions Decision ID Submissions](../../doc/controllers/direct-debits.md#post-directdebits-id-decisions-decision-id-submissions)
* [Get Directdebits ID Decisions Decision ID Submissions Submission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-decisions-decision-id-submissions-submission-id)
* [Post Directdebits ID Recalls](../../doc/controllers/direct-debits.md#post-directdebits-id-recalls)
* [Get Directdebits ID Recalls Recall ID](../../doc/controllers/direct-debits.md#get-directdebits-id-recalls-recall-id)
* [Get Directdebits ID Recalls Recall ID Admissions Admission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-recalls-recall-id-admissions-admission-id)
* [Get Directdebits ID Recalls Recall ID Submissions Submission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-recalls-recall-id-submissions-submission-id)
* [Post Directdebits ID Returns](../../doc/controllers/direct-debits.md#post-directdebits-id-returns)
* [Get Directdebits ID Returns Return ID](../../doc/controllers/direct-debits.md#get-directdebits-id-returns-return-id)
* [Get Directdebits ID Returns Return ID Admissions Admission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-returns-return-id-admissions-admission-id)
* [Get Directdebits ID Returns Return ID Reversals Reversal ID](../../doc/controllers/direct-debits.md#get-directdebits-id-returns-return-id-reversals-reversal-id)
* [Get Directdebits ID Returns Return ID Reversals Reversal ID Admissions Admission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-returns-return-id-reversals-reversal-id-admissions-admission-id)
* [Post Directdebits ID Returns Return ID Submissions](../../doc/controllers/direct-debits.md#post-directdebits-id-returns-return-id-submissions)
* [Get Directdebits ID Returns Return ID Submissions Submission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-returns-return-id-submissions-submission-id)
* [Post Directdebits ID Reversals](../../doc/controllers/direct-debits.md#post-directdebits-id-reversals)
* [Get Directdebits ID Reversals Reversal ID](../../doc/controllers/direct-debits.md#get-directdebits-id-reversals-reversal-id)
* [Get Directdebits ID Reversals Reversal ID Admissions Admission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-reversals-reversal-id-admissions-admission-id)
* [Post Directdebits ID Reversals Reversal ID Submissions](../../doc/controllers/direct-debits.md#post-directdebits-id-reversals-reversal-id-submissions)
* [Get Directdebits ID Reversals Reversal ID Submissions Submission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-reversals-reversal-id-submissions-submission-id)
* [Post Directdebits ID Submissions](../../doc/controllers/direct-debits.md#post-directdebits-id-submissions)
* [Get Directdebits ID Submissions Submission ID](../../doc/controllers/direct-debits.md#get-directdebits-id-submissions-submission-id)


# Get Directdebits

List direct debits

```csharp
GetDirectdebitsAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageBefore` | `string` | Query, Optional | Cursor for previous page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the last page, where the value should be set to "end"). |
| `pageAfter` | `string` | Query, Optional | Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the first page, where the value should be set to "start"). |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterCreatedDateFrom` | `DateTime?` | Query, Optional | - |
| `filterCreatedDateTo` | `DateTime?` | Query, Optional | - |
| `filterModifiedDateFrom` | `DateTime?` | Query, Optional | - |
| `filterModifiedDateTo` | `DateTime?` | Query, Optional | - |
| `filterDebtorPartyAccountNumber` | `string` | Query, Optional | - |
| `filterDebtorPartyBankId` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyAccountNumber` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyBankId` | `string` | Query, Optional | - |
| `filterCurrency` | `string` | Query, Optional | - |
| `filterPaymentScheme` | `string` | Query, Optional | - |
| `filterPaymentType` | `string` | Query, Optional | - |
| `filterProcessingDateFrom` | `DateTime?` | Query, Optional | - |
| `filterProcessingDateTo` | `DateTime?` | Query, Optional | - |
| `filterClearingId` | `string` | Query, Optional | - |
| `filterAdmissionAdmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterAdmissionAdmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterAdmissionStatus` | `string` | Query, Optional | Filter by admission status |
| `filterAdmissionSchemeStatusCode` | `string` | Query, Optional | Filter by admission scheme status code |
| `filterAmount` | `string` | Query, Optional | Filter by amount |
| `filterReference` | `string` | Query, Optional | Filter by reference |
| `filterUniqueSchemeId` | `string` | Query, Optional | Filter by unique scheme id |
| `filterSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterSubmissionStatus` | `string` | Query, Optional | Filter by submission status |
| `filterSubmissionSchemeStatusCode` | `string` | Query, Optional | Filter by submission scheme status code |
| `filterRelationships` | [`List<FilterRelationshipsEnum>`](../../doc/models/filter-relationships-enum.md) | Query, Optional | Filter for direct debits containing all of the requested relationships |
| `filterNotRelationships` | [`List<FilterNotRelationshipsEnum>`](../../doc/models/filter-not-relationships-enum.md) | Query, Optional | Filter for direct debits containing none of the requested relationships |

## Response Type

[`Task<Models.DirectDebitDetailsListResponse>`](../../doc/models/direct-debit-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    DirectDebitDetailsListResponse result = await directDebitsController.GetDirectdebitsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits

Create Direct debit

```csharp
PostDirectdebitsAsync(
    Models.DirectDebitCreation directDebitCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `directDebitCreationRequest` | [`DirectDebitCreation`](../../doc/models/direct-debit-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitCreationResponse>`](../../doc/models/direct-debit-creation-response.md)

## Example Usage

```csharp
try
{
    DirectDebitCreationResponse result = await directDebitsController.PostDirectdebitsAsync();
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
| 400 | Direct Debit creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID

Fetch direct debit

```csharp
GetDirectdebitsIDAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |

## Response Type

[`Task<Models.DirectDebitDetailsResponse>`](../../doc/models/direct-debit-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    DirectDebitDetailsResponse result = await directDebitsController.GetDirectdebitsIDAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Directdebits ID Admissions Admission ID

Fetch Direct Debit Admission

```csharp
GetDirectdebitsIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `admissionId` | `Guid` | Template, Required | Direct Debit Admission Id |

## Response Type

[`Task<Models.DirectDebitAdmissionDetailsResponse>`](../../doc/models/direct-debit-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    DirectDebitAdmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDAdmissionsAdmissionIDAsync(
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


# Post Directdebits ID Decisions

Create direct debit decision

```csharp
PostDirectdebitsIDDecisionsAsync(
    Guid id,
    Models.DirectDebitDecisionCreation directDebitDecisionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `directDebitDecisionCreationRequest` | [`DirectDebitDecisionCreation`](../../doc/models/direct-debit-decision-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitDecisionCreationResponse>`](../../doc/models/direct-debit-decision-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    DirectDebitDecisionCreationResponse result = await directDebitsController.PostDirectdebitsIDDecisionsAsync(id);
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
| 400 | Direct Debit decision creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Direct Debit decision creation conflict error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID Decisions Decision ID

Get direct debit decision

```csharp
GetDirectdebitsIDDecisionsDecisionIDAsync(
    Guid id,
    Guid decisionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `decisionId` | `Guid` | Template, Required | Direct Debit decision id |

## Response Type

[`Task<Models.DirectDebitDecisionDetailsResponse>`](../../doc/models/direct-debit-decision-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
try
{
    DirectDebitDecisionDetailsResponse result = await directDebitsController.GetDirectdebitsIDDecisionsDecisionIDAsync(
        id,
        decisionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Decisions Decision ID Admissions

Create direct debit decision admissions

```csharp
PostDirectdebitsIDDecisionsDecisionIDAdmissionsAsync(
    Guid id,
    Guid decisionId,
    Models.DirectDebitDecisionAdmissionCreation directDebitAdmissionSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `decisionId` | `Guid` | Template, Required | Direct Debit decision id |
| `directDebitAdmissionSubmissionCreationRequest` | [`DirectDebitDecisionAdmissionCreation`](../../doc/models/direct-debit-decision-admission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitDecisionAdmissionCreationResponse>`](../../doc/models/direct-debit-decision-admission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
try
{
    DirectDebitDecisionAdmissionCreationResponse result = await directDebitsController.PostDirectdebitsIDDecisionsDecisionIDAdmissionsAsync(
        id,
        decisionId
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
| 400 | Direct Debit decision admission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Direct Debit decision submission creation conflict error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID Decisions Decision ID Admissions Admission ID

Fetch decision admission

```csharp
GetDirectdebitsIDDecisionsDecisionIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid decisionId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `decisionId` | `Guid` | Template, Required | Direct Debit decision id |
| `admissionId` | `Guid` | Template, Required | Direct Debit Admission Id |

## Response Type

[`Task<Models.DirectDebitDecisionAdmissionDetailsResponse>`](../../doc/models/direct-debit-decision-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    DirectDebitDecisionAdmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDDecisionsDecisionIDAdmissionsAdmissionIDAsync(
        id,
        decisionId,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Decisions Decision ID Submissions

Create direct debit decision submission

```csharp
PostDirectdebitsIDDecisionsDecisionIDSubmissionsAsync(
    Guid id,
    Guid decisionId,
    Models.DirectDebitDecisionSubmissionCreation directDebitDecisionSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `decisionId` | `Guid` | Template, Required | Direct Debit decision id |
| `directDebitDecisionSubmissionCreationRequest` | [`DirectDebitDecisionSubmissionCreation`](../../doc/models/direct-debit-decision-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitDecisionSubmissionCreationResponse>`](../../doc/models/direct-debit-decision-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
try
{
    DirectDebitDecisionSubmissionCreationResponse result = await directDebitsController.PostDirectdebitsIDDecisionsDecisionIDSubmissionsAsync(
        id,
        decisionId
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
| 400 | Direct Debit decision submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Direct Debit decision submission creation conflict error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID Decisions Decision ID Submissions Submission ID

Get direct debit decision submission

```csharp
GetDirectdebitsIDDecisionsDecisionIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid decisionId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `decisionId` | `Guid` | Template, Required | Direct Debit decision id |
| `submissionId` | `Guid` | Template, Required | Direct Debit decision submission id |

## Response Type

[`Task<Models.DirectDebitDecisionSubmissionDetailsResponse>`](../../doc/models/direct-debit-decision-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    DirectDebitDecisionSubmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDDecisionsDecisionIDSubmissionsSubmissionIDAsync(
        id,
        decisionId,
        submissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Recalls

Create recall

```csharp
PostDirectdebitsIDRecallsAsync(
    Guid id,
    Models.DirectDebitRecallCreation recallCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `recallCreationRequest` | [`DirectDebitRecallCreation`](../../doc/models/direct-debit-recall-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitRecallCreationResponse>`](../../doc/models/direct-debit-recall-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    DirectDebitRecallCreationResponse result = await directDebitsController.PostDirectdebitsIDRecallsAsync(id);
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
| 400 | Recall creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID Recalls Recall ID

Fetch recall

```csharp
GetDirectdebitsIDRecallsRecallIDAsync(
    Guid id,
    Guid recallId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `recallId` | `Guid` | Template, Required | Recall Id |

## Response Type

[`Task<Models.DirectDebitRecallDetailsResponse>`](../../doc/models/direct-debit-recall-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
try
{
    DirectDebitRecallDetailsResponse result = await directDebitsController.GetDirectdebitsIDRecallsRecallIDAsync(
        id,
        recallId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Directdebits ID Recalls Recall ID Admissions Admission ID

Fetch recall admission

```csharp
GetDirectdebitsIDRecallsRecallIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid recallId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `admissionId` | `Guid` | Template, Required | Direct Debit Admission Id |

## Response Type

[`Task<Models.DirectDebitRecallAdmissionDetailsResponse>`](../../doc/models/direct-debit-recall-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    DirectDebitRecallAdmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDRecallsRecallIDAdmissionsAdmissionIDAsync(
        id,
        recallId,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Directdebits ID Recalls Recall ID Submissions Submission ID

Fetch recall submission

```csharp
GetDirectdebitsIDRecallsRecallIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid recallId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `submissionId` | `Guid` | Template, Required | Direct Debit decision submission id |

## Response Type

[`Task<Models.DirectDebitRecallSubmissionDetailsResponse>`](../../doc/models/direct-debit-recall-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    DirectDebitRecallSubmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDRecallsRecallIDSubmissionsSubmissionIDAsync(
        id,
        recallId,
        submissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Returns

Create direct debit return

```csharp
PostDirectdebitsIDReturnsAsync(
    Guid id,
    Models.DirectDebitReturnCreation returnCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnCreationRequest` | [`DirectDebitReturnCreation`](../../doc/models/direct-debit-return-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitReturnCreationResponse>`](../../doc/models/direct-debit-return-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnCreationResponse result = await directDebitsController.PostDirectdebitsIDReturnsAsync(id);
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


# Get Directdebits ID Returns Return ID

Fetch direct debit return

```csharp
GetDirectdebitsIDReturnsReturnIDAsync(
    Guid id,
    Guid returnId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnId` | `Guid` | Template, Required | Return Id |

## Response Type

[`Task<Models.DirectDebitReturnDetailsResponse>`](../../doc/models/direct-debit-return-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnDetailsResponse result = await directDebitsController.GetDirectdebitsIDReturnsReturnIDAsync(
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


# Get Directdebits ID Returns Return ID Admissions Admission ID

Fetch return admission

```csharp
GetDirectdebitsIDReturnsReturnIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid returnId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `admissionId` | `Guid` | Template, Required | Direct Debit Admission Id |

## Response Type

[`Task<Models.DirectDebitReturnAdmissionDetailsResponse>`](../../doc/models/direct-debit-return-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnAdmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDReturnsReturnIDAdmissionsAdmissionIDAsync(
        id,
        returnId,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Directdebits ID Returns Return ID Reversals Reversal ID

Fetch return admission

```csharp
GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAsync(
    Guid id,
    Guid returnId,
    Guid reversalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |

## Response Type

[`Task<Models.DirectDebitReturnReversalDetailsResponse>`](../../doc/models/direct-debit-return-reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnReversalDetailsResponse result = await directDebitsController.GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAsync(
        id,
        returnId,
        reversalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Directdebits ID Returns Return ID Reversals Reversal ID Admissions Admission ID

Fetch return admission

```csharp
GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid returnId,
    Guid reversalId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `admissionId` | `Guid` | Template, Required | Direct Debit Admission Id |

## Response Type

[`Task<Models.DirectDebitReturnReversalAdmissionDetailsResponse>`](../../doc/models/direct-debit-return-reversal-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnReversalAdmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDReturnsReturnIDReversalsReversalIDAdmissionsAdmissionIDAsync(
        id,
        returnId,
        reversalId,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Returns Return ID Submissions

create direct debit return submission

```csharp
PostDirectdebitsIDReturnsReturnIDSubmissionsAsync(
    Guid id,
    Guid returnId,
    Models.DirectDebitReturnSubmissionCreation returnSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `returnSubmissionCreationRequest` | [`DirectDebitReturnSubmissionCreation`](../../doc/models/direct-debit-return-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitReturnSubmissionCreationResponse>`](../../doc/models/direct-debit-return-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnSubmissionCreationResponse result = await directDebitsController.PostDirectdebitsIDReturnsReturnIDSubmissionsAsync(
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


# Get Directdebits ID Returns Return ID Submissions Submission ID

Fetch return submission

```csharp
GetDirectdebitsIDReturnsReturnIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid returnId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `submissionId` | `Guid` | Template, Required | Direct Debit decision submission id |

## Response Type

[`Task<Models.DirectDebitReturnSubmissionDetailsResponse>`](../../doc/models/direct-debit-return-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    DirectDebitReturnSubmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDReturnsReturnIDSubmissionsSubmissionIDAsync(
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


# Post Directdebits ID Reversals

Create direct debit reversal

```csharp
PostDirectdebitsIDReversalsAsync(
    Guid id,
    Models.DirectDebitReversalCreation reversalCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `reversalCreationRequest` | [`DirectDebitReversalCreation`](../../doc/models/direct-debit-reversal-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitReversalCreationResponse>`](../../doc/models/direct-debit-reversal-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    DirectDebitReversalCreationResponse result = await directDebitsController.PostDirectdebitsIDReversalsAsync(id);
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
| 400 | Reversal creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID Reversals Reversal ID

Fetch direct debit reversal

```csharp
GetDirectdebitsIDReversalsReversalIDAsync(
    Guid id,
    Guid reversalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |

## Response Type

[`Task<Models.DirectDebitReversalDetailsResponse>`](../../doc/models/direct-debit-reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    DirectDebitReversalDetailsResponse result = await directDebitsController.GetDirectdebitsIDReversalsReversalIDAsync(
        id,
        reversalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Directdebits ID Reversals Reversal ID Admissions Admission ID

Fetch reversal admission

```csharp
GetDirectdebitsIDReversalsReversalIDAdmissionsAdmissionIDAsync(
    Guid id,
    Guid reversalId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `admissionId` | `Guid` | Template, Required | Direct Debit Admission Id |

## Response Type

[`Task<Models.DirectDebitReversalAdmissionDetailsResponse>`](../../doc/models/direct-debit-reversal-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    DirectDebitReversalAdmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDReversalsReversalIDAdmissionsAdmissionIDAsync(
        id,
        reversalId,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Reversals Reversal ID Submissions

create reversal submission

```csharp
PostDirectdebitsIDReversalsReversalIDSubmissionsAsync(
    Guid id,
    Guid reversalId,
    Models.DirectDebitReversalSubmissionCreation reversalSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `reversalSubmissionCreationRequest` | [`DirectDebitReversalSubmissionCreation`](../../doc/models/direct-debit-reversal-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitReversalSubmissionCreationResponse>`](../../doc/models/direct-debit-reversal-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    DirectDebitReversalSubmissionCreationResponse result = await directDebitsController.PostDirectdebitsIDReversalsReversalIDSubmissionsAsync(
        id,
        reversalId
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
| 400 | Reversal submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Directdebits ID Reversals Reversal ID Submissions Submission ID

Fetch reversal submission

```csharp
GetDirectdebitsIDReversalsReversalIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid reversalId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `submissionId` | `Guid` | Template, Required | Direct Debit decision submission id |

## Response Type

[`Task<Models.DirectDebitReversalSubmissionDetailsResponse>`](../../doc/models/direct-debit-reversal-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    DirectDebitReversalSubmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDReversalsReversalIDSubmissionsSubmissionIDAsync(
        id,
        reversalId,
        submissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Directdebits ID Submissions

Create direct debit submission

```csharp
PostDirectdebitsIDSubmissionsAsync(
    Guid id,
    Models.DirectDebitSubmissionCreation directDebitSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `directDebitSubmissionCreationRequest` | [`DirectDebitSubmissionCreation`](../../doc/models/direct-debit-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.DirectDebitSubmissionCreationResponse>`](../../doc/models/direct-debit-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    DirectDebitSubmissionCreationResponse result = await directDebitsController.PostDirectdebitsIDSubmissionsAsync(id);
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


# Get Directdebits ID Submissions Submission ID

Get direct debit submission

```csharp
GetDirectdebitsIDSubmissionsSubmissionIDAsync(
    Guid id,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Direct Debit Id |
| `submissionId` | `Guid` | Template, Required | Direct Debit decision submission id |

## Response Type

[`Task<Models.DirectDebitSubmissionDetailsResponse>`](../../doc/models/direct-debit-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    DirectDebitSubmissionDetailsResponse result = await directDebitsController.GetDirectdebitsIDSubmissionsSubmissionIDAsync(
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

