# Account Validation

```csharp
AccountValidationController accountValidationController = client.AccountValidationController;
```

## Class Name

`AccountValidationController`

## Methods

* [Fetch Sort Code Details](../../doc/controllers/account-validation.md#fetch-sort-code-details)
* [Validate Sortcode and Account Number Details](../../doc/controllers/account-validation.md#validate-sortcode-and-account-number-details)


# Fetch Sort Code Details

Fetch sort code details

```csharp
FetchSortCodeDetailsAsync(
    string sortcode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sortcode` | `string` | Template, Required | Sort code |

## Response Type

[`Task<Models.SortCodeDetailsResponse>`](../../doc/models/sort-code-details-response.md)

## Example Usage

```csharp
string sortcode = "sortcode4";
try
{
    SortCodeDetailsResponse result = await accountValidationController.FetchSortCodeDetailsAsync(sortcode);
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
| 400 | Validation failed | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Validate Sortcode and Account Number Details

Validate sortcode and account number details

```csharp
ValidateSortcodeAndAccountNumberDetailsAsync(
    string sortcode,
    string accountnumber)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sortcode` | `string` | Template, Required | Sort code |
| `accountnumber` | `string` | Template, Required | Account number |

## Response Type

[`Task<Models.AccountNumberDetailsResponse>`](../../doc/models/account-number-details-response.md)

## Example Usage

```csharp
string sortcode = "sortcode4";
string accountnumber = "accountnumber2";
try
{
    AccountNumberDetailsResponse result = await accountValidationController.ValidateSortcodeAndAccountNumberDetailsAsync(
        sortcode,
        accountnumber
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
| 400 | Validation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Validation failed | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

