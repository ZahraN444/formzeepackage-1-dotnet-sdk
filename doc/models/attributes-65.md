
# Attributes 65

## Structure

`Attributes65`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RedirectedAccountNumber` | `string` | Optional | Details of the account to which funds are redirected (if applicable) |
| `RedirectedBankId` | `string` | Optional | Details of the bank to which funds are redirected (if applicable) |
| `Route` | [`Route1Enum?`](../../doc/models/route-1-enum.md) | Optional | Route taken for a return |
| `SchemeStatusCode` | `string` | Optional | Scheme-specific status (if submission has been submitted to a scheme) |
| `SchemeStatusCodeDescription` | `string` | Optional | [Description](http://api-docs.form3.tech/api.html#enumerations-scheme-status-codes-for-bacs) of `scheme_status_code` |
| `SettlementCycle` | `int?` | Optional | Cycle in which the payment will be settled<br>**Constraints**: `>= 0` |
| `SettlementDate` | `DateTime?` | Optional | Date that the payment will be settled |
| `Status` | [`ReturnSubmissionStatusEnum?`](../../doc/models/return-submission-status-enum.md) | Optional | [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-submission-status) of the submission |
| `StatusReason` | `string` | Optional | Description of the submission status |

## Example (as JSON)

```json
{
  "redirected_account_number": "12345678",
  "redirected_bank_id": "400300",
  "scheme_status_code": "0000",
  "scheme_status_code_description": "Field 1 (destination sorting code) was invalid",
  "settlement_cycle": 1,
  "settlement_date": "2017-07-23",
  "status": "accepted",
  "status_reason": "Accepted without qualification",
  "route": "on_us"
}
```

