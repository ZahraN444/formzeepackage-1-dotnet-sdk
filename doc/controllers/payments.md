# Payments

```csharp
PaymentsController paymentsController = client.PaymentsController;
```

## Class Name

`PaymentsController`

## Methods

* [List Positions](../../doc/controllers/payments.md#list-positions)
* [List Payments](../../doc/controllers/payments.md#list-payments)
* [Create Payment](../../doc/controllers/payments.md#create-payment)
* [Fetch Payment](../../doc/controllers/payments.md#fetch-payment)
* [Fetch Admission](../../doc/controllers/payments.md#fetch-admission)
* [List Tasks](../../doc/controllers/payments.md#list-tasks)
* [Get Payment Admission Task by ID](../../doc/controllers/payments.md#get-payment-admission-task-by-id)
* [Patch Payment Admission Task](../../doc/controllers/payments.md#patch-payment-admission-task)
* [Create Advice](../../doc/controllers/payments.md#create-advice)
* [Fetch Advice](../../doc/controllers/payments.md#fetch-advice)
* [Create Advice Submission](../../doc/controllers/payments.md#create-advice-submission)
* [Fetch Advice Submission](../../doc/controllers/payments.md#fetch-advice-submission)
* [Create Recall](../../doc/controllers/payments.md#create-recall)
* [Fetch Recall](../../doc/controllers/payments.md#fetch-recall)
* [Fetch Recall Admission](../../doc/controllers/payments.md#fetch-recall-admission)
* [Create Recall Decision](../../doc/controllers/payments.md#create-recall-decision)
* [Fetch Recall Decision](../../doc/controllers/payments.md#fetch-recall-decision)
* [Fetch Recall Decision Admission](../../doc/controllers/payments.md#fetch-recall-decision-admission)
* [Create Recall Decision Submission](../../doc/controllers/payments.md#create-recall-decision-submission)
* [Fetch Recall Decision Submission](../../doc/controllers/payments.md#fetch-recall-decision-submission)
* [Fetch Recall Reversal](../../doc/controllers/payments.md#fetch-recall-reversal)
* [Fetch Recall Reversal Admission](../../doc/controllers/payments.md#fetch-recall-reversal-admission)
* [Create Recall Submission](../../doc/controllers/payments.md#create-recall-submission)
* [Fetch Recall Submission](../../doc/controllers/payments.md#fetch-recall-submission)
* [Create Return](../../doc/controllers/payments.md#create-return)
* [Fetch Return](../../doc/controllers/payments.md#fetch-return)
* [Fetch Return Admission](../../doc/controllers/payments.md#fetch-return-admission)
* [Create Return Reversal](../../doc/controllers/payments.md#create-return-reversal)
* [Fetch Return Reversal](../../doc/controllers/payments.md#fetch-return-reversal)
* [Fetch Return Reversal Admission](../../doc/controllers/payments.md#fetch-return-reversal-admission)
* [Create Return Submission](../../doc/controllers/payments.md#create-return-submission)
* [Fetch Return Submission](../../doc/controllers/payments.md#fetch-return-submission)
* [Create Reversal](../../doc/controllers/payments.md#create-reversal)
* [Fetch Reversal](../../doc/controllers/payments.md#fetch-reversal)
* [Fetch Reversal Admission](../../doc/controllers/payments.md#fetch-reversal-admission)
* [Create Reversal Submission](../../doc/controllers/payments.md#create-reversal-submission)
* [Fetch Reversal Submission](../../doc/controllers/payments.md#fetch-reversal-submission)
* [Create Submission](../../doc/controllers/payments.md#create-submission)
* [Fetch Submission](../../doc/controllers/payments.md#fetch-submission)
* [Patch Payment Submission Task](../../doc/controllers/payments.md#patch-payment-submission-task)
* [Patch Return Submission Task](../../doc/controllers/payments.md#patch-return-submission-task)


# List Positions

List Positions

```csharp
ListPositionsAsync()
```

## Response Type

[`Task<Models.PositionDetailsListResponse>`](../../doc/models/position-details-list-response.md)

## Example Usage

```csharp
try
{
    PositionDetailsListResponse result = await paymentsController.ListPositionsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# List Payments

List payments

```csharp
ListPaymentsAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `pageBefore` | `string` | Query, Optional | Cursor for previous page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the last page, where the value should be set to "end"). |
| `pageAfter` | `string` | Query, Optional | Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated, unless requesting the first page, where the value should be set to "start"). |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterDebtorPartyAccountNumber` | `string` | Query, Optional | - |
| `filterDebtorPartyAccountName` | `string` | Query, Optional | - |
| `filterDebtorPartyBankId` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyAccountNumber` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyAccountName` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyBankId` | `string` | Query, Optional | - |
| `filterCurrency` | `string` | Query, Optional | - |
| `filterEndToEndReference` | `string` | Query, Optional | - |
| `filterReturnUniqueSchemeId` | `string` | Query, Optional | - |
| `filterSchemeTransactionId` | `string` | Query, Optional | - |
| `filterPaymentScheme` | `string` | Query, Optional | - |
| `filterPaymentType` | `string` | Query, Optional | - |
| `filterProcessingDateFrom` | `DateTime?` | Query, Optional | - |
| `filterProcessingDateTo` | `DateTime?` | Query, Optional | - |
| `filterUniqueSchemeId` | `string` | Query, Optional | - |
| `filterAmount` | `string` | Query, Optional | - |
| `filterReference` | `string` | Query, Optional | - |
| `filterRoute` | `string` | Query, Optional | - |
| `filterSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterSubmissionStatus` | `string` | Query, Optional | Filter by submission status |
| `filterSubmissionSchemeStatusCode` | `string` | Query, Optional | Filter by submission scheme status code |
| `filterReturnSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterReturnSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterReturnSubmissionStatus` | `string` | Query, Optional | Filter by return submission status |
| `filterAdmissionAdmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterAdmissionAdmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterAdmissionStatus` | `string` | Query, Optional | Filter by admission status |
| `filterAdmissionSchemeStatusCode` | `string` | Query, Optional | Filter by admission scheme status code |
| `filterRelationships` | [`List<FilterRelationships1Enum>`](../../doc/models/filter-relationships-1-enum.md) | Query, Optional | Filter for payments containing all of the requested relationships |
| `filterNotRelationships` | [`List<FilterNotRelationships1Enum>`](../../doc/models/filter-not-relationships-1-enum.md) | Query, Optional | Filter for payments containing none of the requested relationships |

## Response Type

[`Task<Models.PaymentDetailsListResponse>`](../../doc/models/payment-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    PaymentDetailsListResponse result = await paymentsController.ListPaymentsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Payment

Create payment

```csharp
CreatePaymentAsync(
    Models.PaymentCreation paymentCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentCreationRequest` | [`PaymentCreation`](../../doc/models/payment-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentCreationResponse>`](../../doc/models/payment-creation-response.md)

## Example Usage

```csharp
try
{
    PaymentCreationResponse result = await paymentsController.CreatePaymentAsync();
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
| 400 | Payment creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Payment

Fetch payment

```csharp
FetchPaymentAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |

## Response Type

[`Task<Models.PaymentDetailsResponse>`](../../doc/models/payment-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    PaymentDetailsResponse result = await paymentsController.FetchPaymentAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Admission

Fetch admission

```csharp
FetchAdmissionAsync(
    Guid id,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.PaymentAdmissionDetailsResponse>`](../../doc/models/payment-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    PaymentAdmissionDetailsResponse result = await paymentsController.FetchAdmissionAsync(
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


# List Tasks

List tasks

```csharp
ListTasksAsync(
    Guid id,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.PaymentAdmissionTaskListResponse>`](../../doc/models/payment-admission-task-list-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    PaymentAdmissionTaskListResponse result = await paymentsController.ListTasksAsync(
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


# Get Payment Admission Task by ID

Get Payment Admission Task By ID

```csharp
GetPaymentAdmissionTaskByIDAsync(
    Guid id,
    Guid admissionId,
    Guid taskId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |
| `taskId` | `Guid` | Template, Required | Payment Admission Task Id |

## Response Type

[`Task<Models.PaymentAdmissionTaskDetailsResponse>`](../../doc/models/payment-admission-task-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
Guid taskId = new Guid("0000075c-0000-0000-0000-000000000000");
try
{
    PaymentAdmissionTaskDetailsResponse result = await paymentsController.GetPaymentAdmissionTaskByIDAsync(
        id,
        admissionId,
        taskId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Patch Payment Admission Task

Patch Payment Admission Task

```csharp
PatchPaymentAdmissionTaskAsync(
    Guid id,
    Guid admissionId,
    Guid taskId,
    Models.PaymentAdmissionTaskAmendment paymentAdmissionTaskPatchRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |
| `taskId` | `Guid` | Template, Required | Payment Admission Task Id |
| `paymentAdmissionTaskPatchRequest` | [`PaymentAdmissionTaskAmendment`](../../doc/models/payment-admission-task-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentAdmissionTaskDetailsResponse>`](../../doc/models/payment-admission-task-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
Guid taskId = new Guid("0000075c-0000-0000-0000-000000000000");
try
{
    PaymentAdmissionTaskDetailsResponse result = await paymentsController.PatchPaymentAdmissionTaskAsync(
        id,
        admissionId,
        taskId
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
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Advice

Create advice

```csharp
CreateAdviceAsync(
    Guid id,
    Models.AdviceCreation adviceCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `adviceCreationRequest` | [`AdviceCreation`](../../doc/models/advice-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.AdviceCreationResponse>`](../../doc/models/advice-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    AdviceCreationResponse result = await paymentsController.CreateAdviceAsync(id);
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
| 400 | Advice creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Advice

Fetch advice

```csharp
FetchAdviceAsync(
    Guid id,
    Guid adviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `adviceId` | `Guid` | Template, Required | Advice Id |

## Response Type

[`Task<Models.AdviceDetailsResponse>`](../../doc/models/advice-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid adviceId = new Guid("00002670-0000-0000-0000-000000000000");
try
{
    AdviceDetailsResponse result = await paymentsController.FetchAdviceAsync(
        id,
        adviceId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Advice Submission

create advice submission

```csharp
CreateAdviceSubmissionAsync(
    Guid id,
    Guid adviceId,
    Models.AdviceSubmissionCreation adviceSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `adviceId` | `Guid` | Template, Required | Advice Id |
| `adviceSubmissionCreationRequest` | [`AdviceSubmissionCreation`](../../doc/models/advice-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.AdviceSubmissionCreationResponse>`](../../doc/models/advice-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid adviceId = new Guid("00002670-0000-0000-0000-000000000000");
try
{
    AdviceSubmissionCreationResponse result = await paymentsController.CreateAdviceSubmissionAsync(
        id,
        adviceId
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
| 400 | Advice submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Advice Submission

Fetch advice submission

```csharp
FetchAdviceSubmissionAsync(
    Guid id,
    Guid adviceId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `adviceId` | `Guid` | Template, Required | Advice Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.AdviceSubmissionDetailsResponse>`](../../doc/models/advice-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid adviceId = new Guid("00002670-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    AdviceSubmissionDetailsResponse result = await paymentsController.FetchAdviceSubmissionAsync(
        id,
        adviceId,
        submissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Recall

Create recall

```csharp
CreateRecallAsync(
    Guid id,
    Models.RecallCreation recallCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallCreationRequest` | [`RecallCreation`](../../doc/models/recall-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.RecallCreationResponse>`](../../doc/models/recall-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    RecallCreationResponse result = await paymentsController.CreateRecallAsync(id);
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


# Fetch Recall

Fetch recall

```csharp
FetchRecallAsync(
    Guid id,
    Guid recallId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |

## Response Type

[`Task<Models.RecallDetailsResponse>`](../../doc/models/recall-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
try
{
    RecallDetailsResponse result = await paymentsController.FetchRecallAsync(
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


# Fetch Recall Admission

Fetch recall admission

```csharp
FetchRecallAdmissionAsync(
    Guid id,
    Guid recallId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.RecallAdmissionDetailsResponse>`](../../doc/models/recall-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    RecallAdmissionDetailsResponse result = await paymentsController.FetchRecallAdmissionAsync(
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


# Create Recall Decision

Create recall decision

```csharp
CreateRecallDecisionAsync(
    Guid id,
    Guid recallId,
    Models.RecallDecisionCreation recallDecisionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `recallDecisionCreationRequest` | [`RecallDecisionCreation`](../../doc/models/recall-decision-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.RecallDecisionCreationResponse>`](../../doc/models/recall-decision-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
try
{
    RecallDecisionCreationResponse result = await paymentsController.CreateRecallDecisionAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Recall decision creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Recall Decision

Fetch recall decision

```csharp
FetchRecallDecisionAsync(
    Guid id,
    Guid recallId,
    Guid decisionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `decisionId` | `Guid` | Template, Required | Decision Id |

## Response Type

[`Task<Models.RecallDecisionDetailsResponse>`](../../doc/models/recall-decision-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
try
{
    RecallDecisionDetailsResponse result = await paymentsController.FetchRecallDecisionAsync(
        id,
        recallId,
        decisionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Recall Decision Admission

Fetch recall decision admission

```csharp
FetchRecallDecisionAdmissionAsync(
    Guid id,
    Guid recallId,
    Guid decisionId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `decisionId` | `Guid` | Template, Required | Decision Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.RecallDecisionAdmissionDetailsResponse>`](../../doc/models/recall-decision-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    RecallDecisionAdmissionDetailsResponse result = await paymentsController.FetchRecallDecisionAdmissionAsync(
        id,
        recallId,
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


# Create Recall Decision Submission

create recall decision submission

```csharp
CreateRecallDecisionSubmissionAsync(
    Guid id,
    Guid recallId,
    Guid decisionId,
    Models.RecallDecisionSubmissionCreation recallDecisionSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `decisionId` | `Guid` | Template, Required | Decision Id |
| `recallDecisionSubmissionCreationRequest` | [`RecallDecisionSubmissionCreation`](../../doc/models/recall-decision-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.RecallDecisionSubmissionCreationResponse>`](../../doc/models/recall-decision-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
try
{
    RecallDecisionSubmissionCreationResponse result = await paymentsController.CreateRecallDecisionSubmissionAsync(
        id,
        recallId,
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
| 400 | Recall decision submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Recall Decision Submission

Fetch recall decision submission

```csharp
FetchRecallDecisionSubmissionAsync(
    Guid id,
    Guid recallId,
    Guid decisionId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `decisionId` | `Guid` | Template, Required | Decision Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.RecallDecisionSubmissionDetailsResponse>`](../../doc/models/recall-decision-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid decisionId = new Guid("0000256a-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    RecallDecisionSubmissionDetailsResponse result = await paymentsController.FetchRecallDecisionSubmissionAsync(
        id,
        recallId,
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


# Fetch Recall Reversal

Fetch recall reversal

```csharp
FetchRecallReversalAsync(
    Guid id,
    Guid recallId,
    Guid reversalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |

## Response Type

[`Task<Models.RecallReversalDetailsResponse>`](../../doc/models/recall-reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    RecallReversalDetailsResponse result = await paymentsController.FetchRecallReversalAsync(
        id,
        recallId,
        reversalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Recall Reversal Admission

Fetch recall reversal admission

```csharp
FetchRecallReversalAdmissionAsync(
    Guid id,
    Guid recallId,
    Guid reversalId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.RecallReversalAdmissionDetailsResponse>`](../../doc/models/recall-reversal-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    RecallReversalAdmissionDetailsResponse result = await paymentsController.FetchRecallReversalAdmissionAsync(
        id,
        recallId,
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


# Create Recall Submission

create recall submission

```csharp
CreateRecallSubmissionAsync(
    Guid id,
    Guid recallId,
    Models.RecallSubmissionCreation recallSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `recallSubmissionCreationRequest` | [`RecallSubmissionCreation`](../../doc/models/recall-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.RecallSubmissionCreationResponse>`](../../doc/models/recall-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
try
{
    RecallSubmissionCreationResponse result = await paymentsController.CreateRecallSubmissionAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Recall submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Recall Submission

Fetch recall submission

```csharp
FetchRecallSubmissionAsync(
    Guid id,
    Guid recallId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `recallId` | `Guid` | Template, Required | Recall Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.RecallSubmissionDetailsResponse>`](../../doc/models/recall-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid recallId = new Guid("000009bc-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    RecallSubmissionDetailsResponse result = await paymentsController.FetchRecallSubmissionAsync(
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


# Create Return

Create return

```csharp
CreateReturnAsync(
    Guid id,
    Models.ReturnCreation returnCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnCreationRequest` | [`ReturnCreation`](../../doc/models/return-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ReturnCreationResponse>`](../../doc/models/return-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    ReturnCreationResponse result = await paymentsController.CreateReturnAsync(id);
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


# Fetch Return

Fetch return

```csharp
FetchReturnAsync(
    Guid id,
    Guid returnId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |

## Response Type

[`Task<Models.ReturnDetailsResponse>`](../../doc/models/return-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    ReturnDetailsResponse result = await paymentsController.FetchReturnAsync(
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


# Fetch Return Admission

Fetch return admission

```csharp
FetchReturnAdmissionAsync(
    Guid id,
    Guid returnId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.ReturnAdmissionFetchResponse>`](../../doc/models/return-admission-fetch-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    ReturnAdmissionFetchResponse result = await paymentsController.FetchReturnAdmissionAsync(
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


# Create Return Reversal

Create return reversal

```csharp
CreateReturnReversalAsync(
    Guid id,
    Guid returnId,
    Models.ReturnReversalCreation returnReversalCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `returnReversalCreationRequest` | [`ReturnReversalCreation`](../../doc/models/return-reversal-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ReturnReversalCreationResponse>`](../../doc/models/return-reversal-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    ReturnReversalCreationResponse result = await paymentsController.CreateReturnReversalAsync(
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
| 400 | Reversal creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Return Reversal

Fetch return reversal

```csharp
FetchReturnReversalAsync(
    Guid id,
    Guid returnId,
    Guid reversalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |

## Response Type

[`Task<Models.ReturnReversalDetailsResponse>`](../../doc/models/return-reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    ReturnReversalDetailsResponse result = await paymentsController.FetchReturnReversalAsync(
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


# Fetch Return Reversal Admission

Fetch return reversal admission

```csharp
FetchReturnReversalAdmissionAsync(
    Guid id,
    Guid returnId,
    Guid reversalId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.ReturnReversalAdmissionDetailsResponse>`](../../doc/models/return-reversal-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    ReturnReversalAdmissionDetailsResponse result = await paymentsController.FetchReturnReversalAdmissionAsync(
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


# Create Return Submission

create return submission

```csharp
CreateReturnSubmissionAsync(
    Guid id,
    Guid returnId,
    Models.ReturnSubmissionCreation returnSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `returnSubmissionCreationRequest` | [`ReturnSubmissionCreation`](../../doc/models/return-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ReturnSubmissionCreationResponse>`](../../doc/models/return-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
try
{
    ReturnSubmissionCreationResponse result = await paymentsController.CreateReturnSubmissionAsync(
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


# Fetch Return Submission

Fetch return submission

```csharp
FetchReturnSubmissionAsync(
    Guid id,
    Guid returnId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `returnId` | `Guid` | Template, Required | Return Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.ReturnSubmissionDetailsResponse>`](../../doc/models/return-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    ReturnSubmissionDetailsResponse result = await paymentsController.FetchReturnSubmissionAsync(
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


# Create Reversal

Create reversal

```csharp
CreateReversalAsync(
    Guid id,
    Models.ReversalCreation reversalCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `reversalCreationRequest` | [`ReversalCreation`](../../doc/models/reversal-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ReversalCreationResponse>`](../../doc/models/reversal-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    ReversalCreationResponse result = await paymentsController.CreateReversalAsync(id);
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


# Fetch Reversal

Fetch reversal

```csharp
FetchReversalAsync(
    Guid id,
    Guid reversalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |

## Response Type

[`Task<Models.ReversalDetailsResponse>`](../../doc/models/reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    ReversalDetailsResponse result = await paymentsController.FetchReversalAsync(
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


# Fetch Reversal Admission

Fetch reversal admission

```csharp
FetchReversalAdmissionAsync(
    Guid id,
    Guid reversalId,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `admissionId` | `Guid` | Template, Required | Admission Id |

## Response Type

[`Task<Models.ReversalAdmissionDetailsResponse>`](../../doc/models/reversal-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    ReversalAdmissionDetailsResponse result = await paymentsController.FetchReversalAdmissionAsync(
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


# Create Reversal Submission

Create reversal submission

```csharp
CreateReversalSubmissionAsync(
    Guid id,
    Guid reversalId,
    Models.ReversalSubmissionCreation reversalSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `reversalSubmissionCreationRequest` | [`ReversalSubmissionCreation`](../../doc/models/reversal-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ReversalSubmissionCreationResponse>`](../../doc/models/reversal-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    ReversalSubmissionCreationResponse result = await paymentsController.CreateReversalSubmissionAsync(
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


# Fetch Reversal Submission

Fetch reversal submission

```csharp
FetchReversalSubmissionAsync(
    Guid id,
    Guid reversalId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `reversalId` | `Guid` | Template, Required | Reversal Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.ReversalSubmissionDetailsResponse>`](../../doc/models/reversal-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    ReversalSubmissionDetailsResponse result = await paymentsController.FetchReversalSubmissionAsync(
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


# Create Submission

create submission

```csharp
CreateSubmissionAsync(
    Guid id,
    Models.PaymentSubmissionCreation submissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `submissionCreationRequest` | [`PaymentSubmissionCreation`](../../doc/models/payment-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentSubmissionCreationResponse>`](../../doc/models/payment-submission-creation-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    PaymentSubmissionCreationResponse result = await paymentsController.CreateSubmissionAsync(id);
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
| 400 | Submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Submission

Fetch submission

```csharp
FetchSubmissionAsync(
    Guid id,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |

## Response Type

[`Task<Models.PaymentSubmissionDetailsResponse>`](../../doc/models/payment-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    PaymentSubmissionDetailsResponse result = await paymentsController.FetchSubmissionAsync(
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


# Patch Payment Submission Task

Patch Payment Submission Task

```csharp
PatchPaymentSubmissionTaskAsync(
    Guid id,
    Guid submissionId,
    Guid taskId,
    Models.PaymentSubmissionTaskAmendment paymentSubmissionTaskPatchRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Payment Id |
| `submissionId` | `Guid` | Template, Required | Submission Id |
| `taskId` | `Guid` | Template, Required | Payment Submission Task Id |
| `paymentSubmissionTaskPatchRequest` | [`PaymentSubmissionTaskAmendment`](../../doc/models/payment-submission-task-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentSubmissionTaskDetailsResponse>`](../../doc/models/payment-submission-task-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
Guid taskId = new Guid("0000075c-0000-0000-0000-000000000000");
try
{
    PaymentSubmissionTaskDetailsResponse result = await paymentsController.PatchPaymentSubmissionTaskAsync(
        id,
        submissionId,
        taskId
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
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Patch Return Submission Task

Patch Return Submission Task

```csharp
PatchReturnSubmissionTaskAsync(
    Guid paymentId,
    Guid returnId,
    Guid returnSubmissionId,
    Guid taskId,
    Models.ReturnSubmissionTaskAmendment returnSubmissionTaskPatchRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentId` | `Guid` | Template, Required | Payment ID |
| `returnId` | `Guid` | Template, Required | Return ID |
| `returnSubmissionId` | `Guid` | Template, Required | Return Submission ID |
| `taskId` | `Guid` | Template, Required | Return Submission Task Id |
| `returnSubmissionTaskPatchRequest` | [`ReturnSubmissionTaskAmendment`](../../doc/models/return-submission-task-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.ReturnSubmissionTaskDetailsResponse>`](../../doc/models/return-submission-task-details-response.md)

## Example Usage

```csharp
Guid paymentId = new Guid("000003ea-0000-0000-0000-000000000000");
Guid returnId = new Guid("00001dea-0000-0000-0000-000000000000");
Guid returnSubmissionId = new Guid("00001b42-0000-0000-0000-000000000000");
Guid taskId = new Guid("0000075c-0000-0000-0000-000000000000");
try
{
    ReturnSubmissionTaskDetailsResponse result = await paymentsController.PatchReturnSubmissionTaskAsync(
        paymentId,
        returnId,
        returnSubmissionId,
        taskId
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
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

